using XVM.Runtime.Execution;

namespace XVM.Runtime.OpCodes;

internal class Ret : IOpCode
{
	public byte Code => VMInstance.STATIC_Instance.Data.Constants.OP_RET;

	public void Run(VMContext ctx, out ExecutionState state)
	{
		uint u = ctx.Registers[ctx.Data.Constants.REG_SP].U4;
		VMSlot vMSlot = ctx.Stack[u];
		ctx.Stack.SetTopPosition(--u);
		ctx.Registers[ctx.Data.Constants.REG_SP].U4 = u;
		ctx.Registers[ctx.Data.Constants.REG_IP].U8 = vMSlot.U8;
		state = ExecutionState.Next;
	}
}
