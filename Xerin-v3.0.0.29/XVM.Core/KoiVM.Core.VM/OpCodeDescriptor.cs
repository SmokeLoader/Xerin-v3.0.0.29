using System.Linq;
using KoiVM.Core.Services;
using KoiVM.Core.VMIL;

namespace KoiVM.Core.VM;

public class OpCodeDescriptor
{
	private readonly byte[] opCodeOrder = (from x in Enumerable.Range(0, 256)
		select (byte)x).ToArray();

	public byte this[ILOpCode opCode] => opCodeOrder[(int)opCode];

	internal OpCodeDescriptor(RandomGenerator randomGenerator)
	{
		randomGenerator.Shuffle(opCodeOrder);
	}
}
