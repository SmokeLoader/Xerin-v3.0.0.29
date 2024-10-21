using System;
using System.Diagnostics;

namespace KoiVM.Core.Helpers.System.Diagnostics.Contracts;

[Conditional("CONTRACTS_FULL")]
[AttributeUsage(AttributeTargets.Field)]
public sealed class ContractPublicPropertyNameAttribute : Attribute
{
	private string _publicName;

	public string Name => _publicName;

	public ContractPublicPropertyNameAttribute(string name)
	{
		_publicName = name;
	}
}
