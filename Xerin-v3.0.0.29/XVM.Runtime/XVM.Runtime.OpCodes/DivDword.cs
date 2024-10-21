using XVM.Runtime.Execution;

namespace XVM.Runtime.OpCodes;

internal class DivDword : IOpCode
{
	public byte Code => VMInstance.STATIC_Instance.Data.Constants.OP_DIV_DWORD;

	public void Run(VMContext ctx, out ExecutionState state)
	{
		uint u = ctx.Registers[ctx.Data.Constants.REG_SP].U4;
		VMSlot vMSlot = ctx.Stack[u - 1];
		VMSlot vMSlot2 = ctx.Stack[u];
		u--;
		ctx.Stack.SetTopPosition(u);
		ctx.Registers[ctx.Data.Constants.REG_SP].U4 = u;
		byte fl = ctx.Registers[ctx.Data.Constants.REG_FL].U1;
		VMSlot value = default(VMSlot);
		if ((fl & ctx.Data.Constants.FL_UNSIGNED) != 0)
		{
			value.U4 = vMSlot.U4 / vMSlot2.U4;
		}
		else
		{
			value.U4 = (uint)((int)vMSlot.U4 / (int)vMSlot2.U4);
		}
		ctx.Stack[u] = value;
		byte mask = (byte)(ctx.Data.Constants.FL_ZERO | ctx.Data.Constants.FL_SIGN | ctx.Data.Constants.FL_UNSIGNED);
		Utils.UpdateFL(ctx, vMSlot.U4, vMSlot2.U4, value.U4, value.U4, ref fl, mask);
		ctx.Registers[ctx.Data.Constants.REG_FL].U1 = fl;
		state = ExecutionState.Next;
	}
}
