using XVM.Runtime.Execution;

namespace XVM.Runtime.OpCodes;

internal class PushRByte : IOpCode
{
	public byte Code => VMInstance.STATIC_Instance.Data.Constants.OP_PUSHR_BYTE;

	public void Run(VMContext ctx, out ExecutionState state)
	{
		uint u = ctx.Registers[ctx.Data.Constants.REG_SP].U4;
		ctx.Stack.SetTopPosition(++u);
		byte b = ctx.ReadByte();
		VMSlot vMSlot = ctx.Registers[b];
		ctx.Stack[u] = new VMSlot
		{
			U1 = vMSlot.U1
		};
		ctx.Registers[ctx.Data.Constants.REG_SP].U4 = u;
		state = ExecutionState.Next;
	}
}
