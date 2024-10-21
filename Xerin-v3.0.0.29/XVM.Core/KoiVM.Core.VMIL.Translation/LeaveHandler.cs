using KoiVM.Core.AST.IL;
using KoiVM.Core.AST.IR;
using KoiVM.Core.VMIR;

namespace KoiVM.Core.VMIL.Translation;

public class LeaveHandler : ITranslationHandler
{
	public IROpCode IRCode => IROpCode.LEAVE;

	public void Translate(IRInstruction instr, ILTranslator tr)
	{
		tr.PushOperand(instr.Operand1);
		tr.Instructions.Add(new ILInstruction(ILOpCode.LEAVE)
		{
			Annotation = instr.Annotation
		});
	}
}
