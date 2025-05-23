using System;
using System.Diagnostics;

namespace KoiVM.Core.Helpers.System.Diagnostics.Contracts;

[Conditional("CONTRACTS_FULL")]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class ContractClassForAttribute : Attribute
{
	private Type _typeIAmAContractFor;

	public Type TypeContractsAreFor => _typeIAmAContractFor;

	public ContractClassForAttribute(Type typeContractsAreFor)
	{
		_typeIAmAContractFor = typeContractsAreFor;
	}
}
