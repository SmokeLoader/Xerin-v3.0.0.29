using System;
using XVM.Runtime.Execution;

namespace XVM.Runtime.OpCodes;

internal class LindPtr : IOpCode
{
	public byte Code => VMInstance.STATIC_Instance.Data.Constants.OP_LIND_PTR;

	public unsafe void Run(VMContext ctx, out ExecutionState state)
	{
		uint u = ctx.Registers[ctx.Data.Constants.REG_SP].U4;
		VMSlot vMSlot = ctx.Stack[u];
		VMSlot value;
		if (vMSlot.O is IReference)
		{
			value = ((IReference)vMSlot.O).GetValue(ctx, (IntPtr.Size == 8) ? PointerType.QWORD : PointerType.DWORD);
		}
		else if (IntPtr.Size == 8)
		{
			ulong* ptr = (ulong*)vMSlot.U8;
			VMSlot vMSlot2 = default(VMSlot);
			vMSlot2.U8 = *ptr;
			value = vMSlot2;
		}
		else
		{
			uint* ptr2 = (uint*)vMSlot.U8;
			VMSlot vMSlot2 = default(VMSlot);
			vMSlot2.U4 = *ptr2;
			value = vMSlot2;
		}
		ctx.Stack[u] = value;
		state = ExecutionState.Next;
	}
}
