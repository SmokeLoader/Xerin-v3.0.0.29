using System;
using KoiVM.Core.AST;
using KoiVM.Core.AST.IL;
using KoiVM.Core.AST.IR;
using KoiVM.Core.VMIR;

namespace KoiVM.Core.VMIL.Translation;

public class DivHandler : ITranslationHandler
{
	public IROpCode IRCode => IROpCode.DIV;

	public void Translate(IRInstruction instr, ILTranslator tr)
	{
		tr.PushOperand(instr.Operand1);
		tr.PushOperand(instr.Operand2);
		switch (TypeInference.InferBinaryOp(instr.Operand1.Type, instr.Operand2.Type))
		{
		case ASTType.I4:
			tr.Instructions.Add(new ILInstruction(ILOpCode.DIV_DWORD));
			break;
		case ASTType.I8:
		case ASTType.Ptr:
		case ASTType.ByRef:
			tr.Instructions.Add(new ILInstruction(ILOpCode.DIV_QWORD));
			break;
		case ASTType.R4:
			tr.Instructions.Add(new ILInstruction(ILOpCode.DIV_R32));
			break;
		case ASTType.R8:
			tr.Instructions.Add(new ILInstruction(ILOpCode.DIV_R64));
			break;
		default:
			throw new NotSupportedException();
		}
		tr.PopOperand(instr.Operand1);
	}
}
