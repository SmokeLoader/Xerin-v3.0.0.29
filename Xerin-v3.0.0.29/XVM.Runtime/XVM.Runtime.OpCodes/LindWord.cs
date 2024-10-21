using XVM.Runtime.Execution;

namespace XVM.Runtime.OpCodes;

internal class LindWord : IOpCode
{
	public byte Code => VMInstance.STATIC_Instance.Data.Constants.OP_LIND_WORD;

	public unsafe void Run(VMContext ctx, out ExecutionState state)
	{
		uint u = ctx.Registers[ctx.Data.Constants.REG_SP].U4;
		VMSlot vMSlot = ctx.Stack[u];
		VMSlot value;
		if (vMSlot.O is IReference)
		{
			value = ((IReference)vMSlot.O).GetValue(ctx, PointerType.WORD);
		}
		else
		{
			ushort* ptr = (ushort*)vMSlot.U8;
			VMSlot vMSlot2 = default(VMSlot);
			vMSlot2.U2 = *ptr;
			value = vMSlot2;
		}
		ctx.Stack[u] = value;
		state = ExecutionState.Next;
	}
}
