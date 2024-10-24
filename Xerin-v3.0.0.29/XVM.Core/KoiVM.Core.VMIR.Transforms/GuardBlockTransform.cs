using KoiVM.Core.AST.IR;
using KoiVM.Core.CFG;

namespace KoiVM.Core.VMIR.Transforms;

public class GuardBlockTransform : ITransform
{
	private BasicBlock<IRInstrList> epilog;

	private BasicBlock<IRInstrList> prolog;

	public void Initialize(IRTransformer tr)
	{
		int maxId = 0;
		BasicBlock<IRInstrList> entry = null;
		tr.RootScope.ProcessBasicBlocks(delegate(BasicBlock<IRInstrList> block)
		{
			block.Id++;
			if (block.Id > maxId)
			{
				maxId = block.Id;
			}
			if (entry == null)
			{
				entry = block;
			}
		});
		prolog = new BasicBlock<IRInstrList>(0, new IRInstrList
		{
			new IRInstruction(IROpCode.__ENTRY),
			new IRInstruction(IROpCode.JMP, new IRBlockTarget(entry))
		});
		prolog.Targets.Add(entry);
		entry.Sources.Add(prolog);
		epilog = new BasicBlock<IRInstrList>(maxId + 1, new IRInstrList
		{
			new IRInstruction(IROpCode.__EXIT)
		});
		InsertProlog(tr.RootScope);
		InsertEpilog(tr.RootScope);
	}

	public void Transform(IRTransformer tr)
	{
		tr.Instructions.VisitInstrs(VisitInstr, tr);
	}

	private void InsertProlog(ScopeBlock block)
	{
		if (block.Children.Count > 0)
		{
			if (block.Children[0].Type == ScopeType.None)
			{
				InsertProlog(block.Children[0]);
				return;
			}
			ScopeBlock scopeBlock = new ScopeBlock();
			scopeBlock.Content.Add(prolog);
			block.Children.Insert(0, scopeBlock);
		}
		else
		{
			block.Content.Insert(0, prolog);
		}
	}

	private void InsertEpilog(ScopeBlock block)
	{
		if (block.Children.Count > 0)
		{
			if (block.Children[block.Children.Count - 1].Type == ScopeType.None)
			{
				InsertEpilog(block.Children[block.Children.Count - 1]);
				return;
			}
			ScopeBlock scopeBlock = new ScopeBlock();
			scopeBlock.Content.Add(epilog);
			block.Children.Insert(block.Children.Count, scopeBlock);
		}
		else
		{
			block.Content.Insert(block.Content.Count, epilog);
		}
	}

	private void VisitInstr(IRInstrList instrs, IRInstruction instr, ref int index, IRTransformer tr)
	{
		if (instr.OpCode == IROpCode.RET)
		{
			instrs.Replace(index, new IRInstruction[1]
			{
				new IRInstruction(IROpCode.JMP, new IRBlockTarget(epilog))
			});
			if (!tr.Block.Targets.Contains(epilog))
			{
				tr.Block.Targets.Add(epilog);
				epilog.Sources.Add(tr.Block);
			}
		}
	}
}
