using System;
using System.Diagnostics;

namespace KoiVM.Core.Helpers.System.Diagnostics.Contracts;

[Conditional("CONTRACTS_FULL")]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
public sealed class ContractVerificationAttribute : Attribute
{
	private bool _value;

	public bool Value => _value;

	public ContractVerificationAttribute(bool value)
	{
		_value = value;
	}
}
