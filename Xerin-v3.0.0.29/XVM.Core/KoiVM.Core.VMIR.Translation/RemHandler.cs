#define DEBUG
using System.Diagnostics;
using dnlib.DotNet.Emit;
using KoiVM.Core.AST.ILAST;
using KoiVM.Core.AST.IR;

namespace KoiVM.Core.VMIR.Translation;

public class RemHandler : ITranslationHandler
{
	public Code ILCode => Code.Rem;

	public IIROperand Translate(ILASTExpression expr, IRTranslator tr)
	{
		Debug.Assert(expr.Arguments.Length == 2);
		IRVariable iRVariable = tr.Context.AllocateVRegister(expr.Type.Value);
		tr.Instructions.Add(new IRInstruction(IROpCode.MOV)
		{
			Operand1 = iRVariable,
			Operand2 = tr.Translate(expr.Arguments[0])
		});
		tr.Instructions.Add(new IRInstruction(IROpCode.REM)
		{
			Operand1 = iRVariable,
			Operand2 = tr.Translate(expr.Arguments[1])
		});
		return iRVariable;
	}
}
