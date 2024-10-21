using XVM.Runtime.Execution;

namespace XVM.Runtime.OpCodes;

internal class SindQword : IOpCode
{
	public byte Code => VMInstance.STATIC_Instance.Data.Constants.OP_SIND_QWORD;

	public unsafe void Run(VMContext ctx, out ExecutionState state)
	{
		uint u = ctx.Registers[ctx.Data.Constants.REG_SP].U4;
		VMSlot vMSlot = ctx.Stack[u--];
		VMSlot slot = ctx.Stack[u--];
		ctx.Stack.SetTopPosition(u);
		ctx.Registers[ctx.Data.Constants.REG_SP].U4 = u;
		if (vMSlot.O is IReference)
		{
			((IReference)vMSlot.O).SetValue(ctx, slot, PointerType.QWORD);
		}
		else
		{
			ulong u2 = slot.U8;
			ulong* ptr = (ulong*)vMSlot.U8;
			*ptr = u2;
		}
		state = ExecutionState.Next;
	}
}
