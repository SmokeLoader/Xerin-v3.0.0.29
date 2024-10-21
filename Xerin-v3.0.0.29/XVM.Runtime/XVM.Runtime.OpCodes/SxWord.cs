using XVM.Runtime.Execution;

namespace XVM.Runtime.OpCodes;

internal class SxWord : IOpCode
{
	public byte Code => VMInstance.STATIC_Instance.Data.Constants.OP_SX_WORD;

	public void Run(VMContext ctx, out ExecutionState state)
	{
		uint u = ctx.Registers[ctx.Data.Constants.REG_SP].U4;
		VMSlot value = ctx.Stack[u];
		if ((value.U2 & 0x8000u) != 0)
		{
			value.U4 = value.U2 | 0xFFFF0000u;
		}
		ctx.Stack[u] = value;
		state = ExecutionState.Next;
	}
}
