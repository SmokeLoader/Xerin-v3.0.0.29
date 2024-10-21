using System;
using System.Collections.Generic;
using dnlib.DotNet;
using KoiVM.Core.AST.IL;
using KoiVM.Core.CFG;
using KoiVM.Core.RT;
using KoiVM.Core.VM;
using KoiVM.Core.VMIL.Transforms;

namespace KoiVM.Core.VMIL;

public class ILTransformer
{
	private ITransform[] pipeline;

	public VMRuntime Runtime { get; }

	public MethodDef Method { get; }

	public ScopeBlock RootScope { get; }

	public VMDescriptor VM => Runtime.Descriptor;

	internal Dictionary<object, object> Annotations { get; }

	internal ILBlock Block { get; private set; }

	internal ILInstrList Instructions => Block.Content;

	public ILTransformer(MethodDef method, ScopeBlock rootScope, VMRuntime runtime)
	{
		method.Body.SimplifyMacros(method.Parameters);
		method.Body.SimplifyBranches();
		RootScope = rootScope;
		Method = method;
		Runtime = runtime;
		Annotations = new Dictionary<object, object>();
		pipeline = InitPipeline();
	}

	private ITransform[] InitPipeline()
	{
		return new ITransform[3]
		{
			new ReferenceOffsetTransform(),
			new EntryExitTransform(),
			new SaveInfoTransform()
		};
	}

	public void Transform()
	{
		if (pipeline == null)
		{
			throw new InvalidOperationException("Transformer already used.");
		}
		ITransform[] array = pipeline;
		foreach (ITransform handler in array)
		{
			handler.Initialize(this);
			RootScope.ProcessBasicBlocks(delegate(BasicBlock<ILInstrList> block)
			{
				Block = (ILBlock)block;
				handler.Transform(this);
			});
		}
		pipeline = null;
	}
}
