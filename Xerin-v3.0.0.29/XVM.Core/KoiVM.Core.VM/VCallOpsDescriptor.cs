using KoiVM.Core.Services;

namespace KoiVM.Core.VM;

public class VCallOpsDescriptor
{
	private readonly uint[] ecallOrder = new uint[4] { 0u, 1u, 2u, 3u };

	public uint ECALL_CALL => ecallOrder[0];

	public uint ECALL_CALLVIRT => ecallOrder[1];

	public uint ECALL_NEWOBJ => ecallOrder[2];

	public uint ECALL_CALLVIRT_CONSTRAINED => ecallOrder[3];

	internal VCallOpsDescriptor(RandomGenerator randomGenerator)
	{
		randomGenerator.Shuffle(ecallOrder);
	}
}
