#define DEBUG
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;

internal sealed class SR
{
	private static SR loader;

	private ResourceManager resources;

	internal const string Activity = "Activity";

	internal const string Handlers = "Handlers";

	internal const string Conditions = "Conditions";

	internal const string ConditionedActivityConditions = "ConditionedActivityConditions";

	internal const string Correlations = "Correlations";

	internal const string CorrelationSet = "CorrelationSet";

	internal const string NameDescr = "NameDescr";

	internal const string EnabledDescr = "EnabledDescr";

	internal const string DescriptionDescr = "DescriptionDescr";

	internal const string UnlessConditionDescr = "UnlessConditionDescr";

	internal const string InitializeDescr = "InitializeDescr";

	internal const string CatchTypeDescr = "CatchTypeDescr";

	internal const string ExceptionTypeDescr = "ExceptionTypeDescr";

	internal const string FaultDescription = "FaultDescription";

	internal const string FaultTypeDescription = "FaultTypeDescription";

	internal const string ContainingAssemblyDescr = "ContainingAssemblyDescr";

	internal const string ExecutionModeDescr = "ExecutionModeDescr";

	internal const string Error_ReadOnlyTemplateActivity = "Error_ReadOnlyTemplateActivity";

	internal const string Error_TypeNotString = "Error_TypeNotString";

	internal const string Error_InvalidErrorType = "Error_InvalidErrorType";

	internal const string Error_LiteralConversionFailed = "Error_LiteralConversionFailed";

	internal const string Error_TypeNotPrimitive = "Error_TypeNotPrimitive";

	internal const string CompletedCaleeDescr = "CompletedCaleeDescr";

	internal const string ProxyClassDescr = "ProxyClassDescr";

	internal const string ActivitySetDescr = "ActivitySetDescr";

	internal const string VersionDescr = "VersionDescr";

	internal const string ActivationDescr = "ActivationDescr";

	internal const string CorrelationSetsDescr = "CorrelationSetsDescr";

	internal const string CompanionClassDescr = "CompanionClassDescr";

	internal const string TransactionTypeDescr = "TransactionTypeDescr";

	internal const string SynchronizedDescr = "SynchronizedDescr";

	internal const string IsolationLevelDescr = "IsolationLevelDescr";

	internal const string TimeoutDescr = "TimeoutDescr";

	internal const string BatchableDescr = "BatchableDescr";

	internal const string LRTTimeoutDescr = "LRTTimeoutDescr";

	internal const string OnGetCalleeCountDescr = "OnGetCalleeCountDescr";

	internal const string CompensatableActivityDescr = "CompensatableActivityDescr";

	internal const string OnAfterEventDescr = "OnAfterEventDescr";

	internal const string OnBeforeMethodInvokeDescr = "OnBeforeMethodInvokeDescr";

	internal const string AssignedToDescr = "AssignedToDescr";

	internal const string TypeDescr = "TypeDescr";

	internal const string TemplateActivityDescr = "TemplateActivityDescr";

	internal const string ErrorMessageDescr = "ErrorMessageDescr";

	internal const string WebServiceSynchronizedDescr = "WebServiceSynchronizedDescr";

	internal const string CorrelationSetDescr = "CorrelationSetDescr";

	internal const string ExecutionTypeDescr = "ExecutionTypeDescr";

	internal const string RoleDescr = "RoleDescr";

	internal const string OnInitializeClonesDescr = "OnInitializeClonesDescr";

	internal const string CorrelationSetDisplayName = "CorrelationSetDisplayName";

	internal const string PastingActivities = "PastingActivities";

	internal const string DeletingActivities = "DeletingActivities";

	internal const string DragDropActivities = "DragDropActivities";

	internal const string ChangingEnabled = "ChangingEnabled";

	internal const string ChangingHandler = "ChangingHandler";

	internal const string ChangingParameter = "ChangingParameter";

	internal const string CollectionItem = "CollectionItem";

	internal const string AddingConditionalBranch = "AddingConditionalBranch";

	internal const string AddingEventActivity = "AddingEventActivity";

	internal const string AddingListenBranch = "AddingListenBranch";

	internal const string AddingParallelBranch = "AddingParallelBranch";

	internal const string CurrentProject = "CurrentProject";

	internal const string ReferencedAssemblies = "ReferencedAssemblies";

	internal const string CollectionText = "CollectionText";

	internal const string ParameterDescription = "ParameterDescription";

	internal const string InvokeParameterDescription = "InvokeParameterDescription";

	internal const string ParametersDescription = "ParametersDescription";

	internal const string ChangingParameters = "ChangingParameters";

	internal const string Condition = "ConditionRule";

	internal const string MovingActivities = "MovingActivities";

	internal const string MemberNameDescr = "MemberNameDescr";

	internal const string OnScopeInitializedDescr = "OnScopeInitializedDescr";

	internal const string OnGeneratorInitializedDescr = "OnGeneratorInitializedDescr";

	internal const string OnScopeCompletedDescr = "OnScopeCompletedDescr";

	internal const string OnGeneratorCompletedDescr = "OnGeneratorCompletedDescr";

	internal const string DataElementRuntimeTypeDescr = "DataElementRuntimeTypeDescr";

	internal const string RuleConditionReferencesDescr = "RuleConditionReferencesDescr";

	internal const string CreateActivityFromToolbox = "CreateActivityFromToolbox";

	internal const string MoveMultipleActivities = "MoveMultipleActivities";

	internal const string MoveSingleActivity = "MoveSingleActivity";

	internal const string CutMultipleActivities = "CutMultipleActivities";

	internal const string CutSingleActivity = "CutSingleActivity";

	internal const string CutActivity = "CutActivity";

	internal const string FaultActivityDescription = "FaultActivityDescription";

	internal const string NullConditionExpression = "NullConditionExpression";

	internal const string ParameterTypeDescription = "ParameterTypeDescription";

	internal const string ParameterCategory = "ParameterCategory";

	internal const string ParameterDirectionDescription = "ParameterDirectionDescription";

	internal const string ParameterElementDescription = "ParameterElementDescription";

	internal const string ParameterDlgDescription = "ParameterDlgDescription";

	internal const string ParameterDlgHeader = "ParameterDlgHeader";

	internal const string SuspendActivityDescription = "SuspendActivityDescription";

	internal const string SuspendErrorMessageDescr = "SuspendErrorMessageDescr";

	internal const string TerminateActivityDescription = "TerminateActivityDescription";

	internal const string TerminateErrorMessageDescr = "TerminateErrorMessageDescr";

	internal const string DeclarationCategory = "DeclarationCategory";

	internal const string NoValidActivityPropertiesAvailable = "NoValidActivityPropertiesAvailable";

	internal const string ChooseActivityDatasource = "ChooseActivityDatasource";

	internal const string Promote = "Promote";

	internal const string Type = "Type";

	internal const string NoMatchingActivityProperties = "NoMatchingActivityProperties";

	internal const string ActivityBindIDDescription = "ActivityBindIDDescription";

	internal const string ActivityBindPathDescription = "ActivityBindPathDescription";

	internal const string XPathDescription = "XPathDescription";

	internal const string TransformerDescription = "TransformerDescription";

	internal const string CustomPropertiesCollectionFormHeader = "CustomPropertiesCollectionFormHeader";

	internal const string CustomPropertiesCollectionFormDescription = "CustomPropertiesCollectionFormDescription";

	internal const string BaseTypePropertyName = "BaseTypePropertyName";

	internal const string CustomActivityBaseClassTypeFilterProviderDesc = "CustomActivityBaseClassTypeFilterProviderDesc";

	internal const string CustomActivityDesignerTypeFilterProviderDesc = "CustomActivityDesignerTypeFilterProviderDesc";

	internal const string CustomActivityValidatorTypeFilterProviderDesc = "CustomActivityValidatorTypeFilterProviderDesc";

	internal const string CustomActivityExecutorTypeFilterProviderDesc = "CustomActivityExecutorTypeFilterProviderDesc";

	internal const string GenericParameters = "GenericParameters";

	internal const string ToolboxItem = "ToolboxItem";

	internal const string ToolboxItemCompanionClassDesc = "ToolboxItemCompanionClassDesc";

	internal const string Error_SerializationInsufficientState = "Error_SerializationInsufficientState";

	internal const string Error_ActivityHasParent = "Error_ActivityHasParent";

	internal const string Error_CompensantionParentNotScope = "Error_CompensantionParentNotScope";

	internal const string Error_ConditionedActivityParentNotCAG = "Error_ConditionedActivityParentNotCAG";

	internal const string Error_CorrelationTypeNotComparable = "Error_CorrelationTypeNotComparable";

	internal const string Error_ArgumentTypeNotMatchParameter = "Error_ArgumentTypeNotMatchParameter";

	internal const string Error_TypeTypeMismatch = "Error_TypeTypeMismatch";

	internal const string Error_ParameterTypeMismatch = "Error_ParameterTypeMismatch";

	internal const string Error_InvokeParameterTypeMismatch = "Error_InvokeParameterTypeMismatch";

	internal const string Error_ParameterPropertyNotSet = "Error_ParameterPropertyNotSet";

	internal const string Error_DataSourceNameNotSet = "Error_DataSourceNameNotSet";

	internal const string Error_DataSourceInvalidIdentifier = "Error_DataSourceInvalidIdentifier";

	internal const string Error_ParameterTypeNotExist = "Error_ParameterTypeNotExist";

	internal const string Error_InvalidParameterName = "Error_InvalidParameterName";

	internal const string Error_InvalidParameterType = "Error_InvalidParameterType";

	internal const string Error_InvalidParameterElement = "Error_InvalidParameterElement";

	internal const string Error_InvalidPropertyType = "Error_InvalidPropertyType";

	internal const string Error_TypeNotResolvedInMethodName = "Error_TypeNotResolvedInMethodName";

	internal const string Error_DelegateNoInvoke = "Error_DelegateNoInvoke";

	internal const string Error_TypeNotDelegate = "Error_TypeNotDelegate";

	internal const string Error_MethodSignatureMismatch = "Error_MethodSignatureMismatch";

	internal const string Error_MethodReturnTypeMismatch = "Error_MethodReturnTypeMismatch";

	internal const string Error_PropertyNotSet = "Error_PropertyNotSet";

	internal const string Error_ScopeCouldNotBeResolved = "Error_ScopeCouldNotBeResolved";

	internal const string Error_IfElseNotAllIfElseBranchDecl = "Error_ConditionalNotAllConditionalBranchDecl";

	internal const string Error_TypeTypeMismatchAmbiguity = "Error_TypeTypeMismatchAmbiguity";

	internal const string Error_InvalidCorrelationSetDatasource = "Error_InvalidCorrelationSetDatasource";

	internal const string Error_InvalidCorrelationSetType = "Error_InvalidCorrelationSetType";

	internal const string Error_MissingCorrelationParameterAttribute = "Error_MissingCorrelationParameterAttribute";

	internal const string Error_CorrelationTypeNotConsistent = "Error_CorrelationTypeNotConsistent";

	internal const string Error_CorrelationInvalid = "Error_CorrelationInvalid";

	internal const string Error_MissingDelegateMethod = "Error_MissingDelegateMethod";

	internal const string Error_MissingHostInterface = "Error_MissingHostInterface";

	internal const string Error_MissingMethodName = "Error_MissingMethodName";

	internal const string Error_NoBoundType = "Error_NoBoundType";

	internal const string Error_PortTypeNotAnInterface = "Error_PortTypeNotAnInterface";

	internal const string Error_MethodNotExists = "Error_MethodNotExists";

	internal const string Error_InvalidRequestResponseMethod = "Error_InvalidRequestResponseMethod";

	internal const string General_MissingService = "General_MissingService";

	internal const string Error_ScopeDuplicatedNameActivity = "Error_ScopeDuplicatedNameActivity";

	internal const string Error_DuplicatedActivityID = "Error_DuplicatedActivityID";

	internal const string Error_DuplicatedParameterName = "Error_DuplicatedParameterName";

	internal const string Error_ScopeMissingSerializableAttribute = "Error_ScopeMissingSerializableAttribute";

	internal const string Error_FieldNotExists = "Error_FieldNotExists";

	internal const string Error_PropertyNotExists = "Error_PropertyNotExists";

	internal const string Error_FieldTypeMismatch = "Error_FieldTypeMismatch";

	internal const string Error_PropertyTypeMismatch = "Error_PropertyTypeMismatch";

	internal const string Error_TypeNotResolvedInFieldName = "Error_TypeNotResolvedInFieldName";

	internal const string Error_TypeNotResolvedInPropertyName = "Error_TypeNotResolvedInPropertyName";

	internal const string Error_FieldGenericParamTypeMismatch = "Error_FieldGenericParamTypeMismatch";

	internal const string Error_TypeNotResolved = "Error_TypeNotResolved";

	internal const string Error_TypeIsUnboundedGeneric = "Error_TypeIsUnboundedGeneric";

	internal const string Error_MissingRootActivity = "Error_MissingRootActivity";

	internal const string Error_PropertyNotReadable = "Error_PropertyNotReadable";

	internal const string Error_PropertyNotWritable = "Error_PropertyNotWritable";

	internal const string Error_NotCompositeActivity = "Error_NotCompositeActivity";

	internal const string Error_TypeNotExist = "Error_TypeNotExist";

	internal const string Error_ActivityRefNotResolved = "Error_ActivityRefNotResolved";

	internal const string Error_ActivityRefNotMatchType = "Error_ActivityRefNotMatchType";

	internal const string Error_ActivityValidation = "Error_ActivityValidation";

	internal const string Error_ActiveChildExist = "Error_ActiveChildExist";

	internal const string Error_ActiveChildContextExist = "Error_ActiveChildContextExist";

	internal const string Error_CannotCompleteContext = "Error_CannotCompleteContext";

	internal const string Error_NoPasteSupport = "Error_NoPasteSupport";

	internal const string Error_UnknownSerializationStore = "Error_UnknownSerializationStore";

	internal const string Error_MissingCorrelationSet = "Error_MissingCorrelationSet";

	internal const string Error_CreateVariable = "Error_CreateVariable";

	internal const string Error_DuplicateCorrelationSetName = "Error_DuplicateCorrelationSetName";

	internal const string Error_DragDropInvalid = "Error_DragDropInvalid";

	internal const string AddingImplicitActivity = "AddingImplicitActivity";

	internal const string Failure_DoDefaultAction = "Failure_DoDefaultAction";

	internal const string Failure_DoDefaultActionCaption = "Failure_DoDefaultActionCaption";

	internal const string Error_FaultInsideAtomicScope = "Error_FaultInsideAtomicScope";

	internal const string Error_ListenNotMoreThanOneDelay = "Error_ListenNotMoreThanOneDelay";

	internal const string Error_AtomicScopeWithFaultHandlersActivityDecl = "Error_AtomicScopeWithFaultHandlersActivityDecl";

	internal const string Error_AtomicScopeWithCancellationHandlerActivity = "Error_AtomicScopeWithCancellationHandlerActivity";

	internal const string Error_ScopeDuplicateFaultHandlerActivityForAll = "Error_ScopeDuplicateFaultHandlerActivityForAll";

	internal const string Error_ScopeDuplicateFaultHandlerActivityFor = "Error_ScopeDuplicateFaultHandlerActivityFor";

	internal const string Error_AtomicScopeNestedInNonLRT = "Error_AtomicScopeNestedInNonLRT";

	internal const string Error_LRTScopeNestedInNonLRT = "Error_LRTScopeNestedInNonLRT";

	internal const string Error_CAGNotAllChildrenConditioned = "Error_CAGNotAllChildrenConditioned";

	internal const string Error_ConditionedActivityChildCount = "Error_ConditionedActivityChildCount";

	internal const string Error_NegativeValue = "Error_NegativeValue";

	internal const string Error_MethodWithReturnType = "Error_MethodWithReturnType";

	internal const string Error_SendReceiveOrderIncorrect = "Error_SendReceiveOrderIncorrect";

	internal const string Error_ReceiveSendOrderIncorrect = "Error_ReceiveSendOrderIncorrect";

	internal const string Error_CompensateBadNesting = "Error_CompensateBadNesting";

	internal const string Error_ReferencedAssemblyIsInvalid = "Error_ReferencedAssemblyIsInvalid";

	internal const string Error_TypeToXsdConversion = "Error_TypeToXsdConversion";

	internal const string Error_FieldTypeNotResolved = "Error_FieldTypeNotResolved";

	internal const string Error_PropertyTypeNotResolved = "Error_PropertyTypeNotResolved";

	internal const string Error_CouldNotDeserializeXomlFile = "Error_CouldNotDeserializeXomlFile";

	internal const string Error_InternalCompilerError = "Error_InternalCompilerError";

	internal const string Error_TypeNotAsseblyQualified = "Error_TypeNotAsseblyQualified";

	internal const string CompilerWarning_StandardAssemlbyInReferences = "CompilerWarning_StandardAssemlbyInReferences";

	internal const string Error_SuspendInAtomicScope = "Error_SuspendInAtomicScope";

	internal const string Error_InvalidActivityExecutionContext = "Error_InvalidActivityExecutionContext";

	internal const string Error_NoRuntimeAvailable = "Error_NoRuntimeAvailable";

	internal const string Error_CanNotChangeAtRuntime = "Error_CanNotChangeAtRuntime";

	internal const string Error_DataContextNotInitialized = "Error_DataContextNotInitialized";

	internal const string Error_DataContextAlreadyInitialized = "Error_DataContextAlreadyInitialized";

	internal const string Error_ParseActivityNameDoesNotExist = "Error_ParseActivityNameDoesNotExist";

	internal const string Error_NoParameterPropertyDeclared = "Error_NoParameterPropertyDeclared";

	internal const string Error_PropertyInvalidIdentifier = "Error_PropertyInvalidIdentifier";

	internal const string Error_WorkflowDefinitionModified = "Error_WorkflowDefinitionModified";

	internal const string Error_FieldAlreadyExist = "Error_FieldAlreadyExist";

	internal const string Failure_FieldAlreadyExist = "Failure_FieldAlreadyExist";

	internal const string Error_DifferentTypeFieldExists = "Error_DifferentTypeFieldExists";

	internal const string Error_RootActivityTypeInvalid = "Error_RootActivityTypeInvalid";

	internal const string Error_RootActivityTypeInvalid2 = "Error_RootActivityTypeInvalid2";

	internal const string Error_CannotCompile_No_XClass = "Error_CannotCompile_No_XClass";

	internal const string Error_TemplateActivityIsNotActivity = "Error_TemplateActivityIsNotActivity";

	internal const string Error_TypeIsNotRootActivity = "Error_TypeIsNotRootActivity";

	internal const string Error_NoTypeProvider = "Error_NoTypeProvider";

	internal const string Error_NotCodeGeneratorType = "Error_NotCodeGeneratorType";

	internal const string Error_NotDataContext = "Error_NotDataContext";

	internal const string Error_MissingDefaultConstructor = "Error_MissingDefaultConstructor";

	internal const string Error_ContextStackItemMissing = "Error_ContextStackItemMissing";

	internal const string Error_UnexpectedArgumentType = "Error_UnexpectedArgumentType";

	internal const string Error_EmptyArgument = "Error_EmptyArgument";

	internal const string Error_DPAlreadyExist = "Error_DPAlreadyExist";

	internal const string Error_DuplicateDynamicProperty = "Error_DuplicateDynamicProperty";

	internal const string Error_DynamicPropertyTypeValueMismatch = "Error_DynamicPropertyTypeValueMismatch";

	internal const string Error_DynamicPropertyNoSupport = "Error_DynamicPropertyNoSupport";

	internal const string Error_NoContextForDatasource = "Error_NoContextForDatasource";

	internal const string Error_NoContextForDatasourceCaption = "Error_NoContextForDatasourceCaption";

	internal const string Error_DataSourceHasParent = "Error_DataSourceHasParent";

	internal const string OnTaskCompletedDescr = "OnTaskCompletedDescr";

	internal const string OnTaskInitializedDescr = "OnTaskInitializedDescr";

	internal const string Error_InvalidXmlData = "Error_InvalidXmlData";

	internal const string Error_HandlerNotOnRoot = "Error_HandlerNotOnRoot";

	internal const string Error_InvalidArgumentIndex = "Error_InvalidArgumentIndex";

	internal const string Error_UITypeEditorTypeNotUITypeEditor = "Error_UITypeEditorTypeNotUITypeEditor";

	internal const string FilterDescription_UITypeEditor = "FilterDescription_UITypeEditor";

	internal const string Error_UserCodeFilesNotAllowed = "Error_UserCodeFilesNotAllowed";

	internal const string Error_CodeWithinNotAllowed = "Error_CodeWithinNotAllowed";

	internal const string Error_TypeNotAuthorized = "Error_TypeNotAuthorized";

	internal const string Error_CantDetermineBaseType = "Error_CantDetermineBaseType";

	internal const string Error_MultipleSelectNotSupportedForBindAndPromote = "Error_MultipleSelectNotSupportedForBindAndPromote";

	internal const string Error_CantDetermineBaseTypeCaption = "Error_CantDetermineBaseTypeCaption";

	internal const string Error_CantDeterminePropertyBaseType = "Error_CantDeterminePropertyBaseType";

	internal const string Error_NullCustomActivityTypeName = "Error_NullCustomActivityTypeName";

	internal const string Error_InvalidAttribute = "Error_InvalidAttribute";

	internal const string Error_InvalidAttributes = "Error_InvalidAttributes";

	internal const string Error_ConfigFileMissingOrInvalid = "Error_ConfigFileMissingOrInvalid";

	internal const string Error_CantHaveContextActivity = "Error_CantHaveContextActivity";

	internal const string Error_SynchronizedNeedsDataContext = "Error_SynchronizedNeedsDataContext";

	internal const string Error_MoreThanOneFaultHandlersActivityDecl = "Error_MoreThanOneFaultHandlersActivityDecl";

	internal const string Error_MoreThanOneEventHandlersDecl = "Error_MoreThanOneEventHandlersDecl";

	internal const string Error_MoreThanOneCancelHandler = "Error_MoreThanOneCancelHandler";

	internal const string Error_MetaDataInterfaceMissing = "Error_MetaDataInterfaceMissing";

	internal const string Error_NonActivityExecutor = "Error_NonActivityExecutor";

	internal const string Error_DynamicUpdateEvaluation = "Error_DynamicUpdateEvaluation";

	internal const string Error_CollectionHasNullEntry = "Error_CollectionHasNullEntry";

	internal const string Error_MissingContextProperty = "Error_MissingContextProperty";

	internal const string Error_AssociatedDesignerMissing = "Error_AssociatedDesignerMissing";

	internal const string Error_MissingContextActivityProperty = "Error_MissingContextActivityProperty";

	internal const string Error_MissingActivityProperty = "Error_MissingActivityProperty";

	internal const string Error_MissingOwnerTypeProperty = "Error_MissingOwnerTypeProperty";

	internal const string Error_DOIsNotAnActivity = "Error_DOIsNotAnActivity";

	internal const string Error_PropertyCanBeOnlyCleared = "Error_PropertyCanBeOnlyCleared";

	internal const string Error_PropertyDefaultTypeMismatch = "Error_PropertyDefaultTypeMismatch";

	internal const string Error_PropertyDefaultIsReference = "Error_PropertyDefaultIsReference";

	internal const string Error_WorkflowLoadFailed = "Error_WorkflowLoadFailed";

	internal const string Error_WorkflowLoadValidationFailed = "Error_WorkflowLoadValidationFailed";

	internal const string Error_WorkflowLoadDeserializationFailed = "Error_WorkflowLoadDeserializationFailed";

	internal const string Error_WorkflowLoadTypeMismatch = "Error_WorkflowLoadTypeMismatch";

	internal const string Error_WorkflowLoadInvalidXoml = "Error_WorkflowLoadInvalidXoml";

	internal const string Error_WorkflowLoadNotValidRootType = "Error_WorkflowLoadNotValidRootType";

	internal const string Error_CantCreateInstanceOfComponent = "Error_CantCreateInstanceOfComponent";

	internal const string Error_NotComponentFactoryType = "Error_NotComponentFactoryType";

	internal const string Error_WorkflowTerminated = "Error_WorkflowTerminated";

	internal const string Error_SerializerAttributesFoundInComplexProperty = "Error_SerializerAttributesFoundInComplexProperty";

	internal const string Error_InvalidDataFound = "Error_InvalidDataFound";

	internal const string Error_InvalidDataFoundForType = "Error_InvalidDataFoundForType";

	internal const string Error_InvalidDataFoundForType1 = "Error_InvalidDataFoundForType1";

	internal const string Error_SerializerTypeNotResolved = "Error_SerializerTypeNotResolved";

	internal const string Error_MarkupSerializerTypeNotResolved = "Error_MarkupSerializerTypeNotResolved";

	internal const string Error_SerializerTypeNotResolvedWithInnerError = "Error_SerializerTypeNotResolvedWithInnerError";

	internal const string Error_SerializerNotAvailable = "Error_SerializerNotAvailable";

	internal const string Error_SerializerNotAvailableForSerialize = "Error_SerializerNotAvailableForSerialize";

	internal const string Error_SerializerCreateInstanceFailed = "Error_SerializerCreateInstanceFailed";

	internal const string Error_SerializerAddChildFailed = "Error_SerializerAddChildFailed";

	internal const string Error_SerializerNoPropertyAvailable = "Error_SerializerNoPropertyAvailable";

	internal const string Error_SerializerPrimitivePropertyReadOnly = "Error_SerializerPrimitivePropertyReadOnly";

	internal const string Error_SerializerCantChangeIsLocked = "Error_SerializerCantChangeIsLocked";

	internal const string Error_SerializerPrimitivePropertySetFailed = "Error_SerializerPrimitivePropertySetFailed";

	internal const string Error_SerializerPropertyGetFailed = "Error_SerializerPropertyGetFailed";

	internal const string Error_SerializerPrimitivePropertyNoLogic = "Error_SerializerPrimitivePropertyNoLogic";

	internal const string Error_SerializerPrimitivePropertyParentIsNull = "Error_SerializerPrimitivePropertyParentIsNull";

	internal const string Error_SerializerComplexPropertySetFailed = "Error_SerializerComplexPropertySetFailed";

	internal const string Error_SerializerNoChildNotion = "Error_SerializerNoChildNotion";

	internal const string Error_SerializerNoDynamicPropertySupport = "Error_SerializerNoDynamicPropertySupport";

	internal const string Error_SerializerNoSerializeLogic = "Error_SerializerNoSerializeLogic";

	internal const string Error_SerializerReadOnlyPropertyAndValueIsNull = "Error_SerializerReadOnlyPropertyAndValueIsNull";

	internal const string Error_SerializerReadOnlyParametersNoChild = "Error_SerializerReadOnlyParametersNoChild";

	internal const string Error_SerializerNotParameterBindingObject = "Error_SerializerNotParameterBindingObject";

	internal const string Error_SerializerThrewException = "Error_SerializerThrewException";

	internal const string Error_ActivityCollectionSerializer = "Error_ActivityCollectionSerializer";

	internal const string Error_MissingClassAttribute = "Error_MissingClassAttribute";

	internal const string Error_MissingClassAttributeValue = "Error_MissingClassAttributeValue";

	internal const string ExecutorCreationFailedErrorMessage = "ExecutorCreationFailedErrorMessage";

	internal const string VariableGetterCode_VB = "VariableGetterCode_VB";

	internal const string VariableGetterCode_CS = "VariableGetterCode_CS";

	internal const string VariableSetterCode_VB = "VariableSetterCode_VB";

	internal const string VariableSetterCode_CS = "VariableSetterCode_CS";

	internal const string StaticVariableGetterCode_VB = "StaticVariableGetterCode_VB";

	internal const string StaticVariableGetterCode_CS = "StaticVariableGetterCode_CS";

	internal const string StaticVariableSetterCode_VB = "StaticVariableSetterCode_VB";

	internal const string StaticVariableSetterCode_CS = "StaticVariableSetterCode_CS";

	internal const string EnterCodeBesidesCode_VB = "EnterCodeBesidesCode_VB";

	internal const string EnterCodeBesidesCode_CS = "EnterCodeBesidesCode_CS";

	internal const string LeaveCodeBesides1Code_VB = "LeaveCodeBesides1Code_VB";

	internal const string LeaveCodeBesides2Code_VB = "LeaveCodeBesides2Code_VB";

	internal const string LeaveCodeBesides1Code_CS = "LeaveCodeBesides1Code_CS";

	internal const string LeaveCodeBesides2Code_CS = "LeaveCodeBesides2Code_CS";

	internal const string VariableSetterName = "VariableSetterName";

	internal const string VariableGetterName = "VariableGetterName";

	internal const string HandlerGetterName = "HandlerGetterName";

	internal const string WorkflowCreatorName = "WorkflowCreatorName";

	internal const string ActivityMethod = "ActivityMethod";

	internal const string CustomActivityPrivateField = "CustomActivityPrivateField";

	internal const string InitializedVariableDeclaration_VB = "InitializedVariableDeclaration_VB";

	internal const string InitializedVariableDeclaration_CS = "InitializedVariableDeclaration_CS";

	internal const string In = "In";

	internal const string Out = "Out";

	internal const string Ref = "Ref";

	internal const string Required = "Required";

	internal const string Optional = "Optional";

	internal const string Parameters = "Parameters";

	internal const string Properties = "Properties";

	internal const string Error_RecursionDetected = "Error_RecursionDetected";

	internal const string Warning_UnverifiedRecursion = "Warning_UnverifiedRecursion";

	internal const string AddConstructorCode = "AddConstructorCode";

	internal const string Error_UninitializedCorrelation = "Error_UninitializedCorrelation";

	internal const string Error_CorrelationAlreadyInitialized = "Error_CorrelationAlreadyInitialized";

	internal const string Error_CorrelatedSendReceiveAtomicScope = "Error_CorrelatedSendReceiveAtomicScope";

	internal const string Warning_ActivityValidation = "Warning_ActivityValidation";

	internal const string Warning_EmptyBehaviourActivity = "Warning_EmptyBehaviourActivity";

	internal const string Error_ParallelActivationNoCorrelation = "Error_ParallelActivationNoCorrelation";

	internal const string Error_MethodNotAccessible = "Error_MethodNotAccessible";

	internal const string Error_FieldNotAccessible = "Error_FieldNotAccessible";

	internal const string Error_PropertyNotAccessible = "Error_PropertyNotAccessible";

	internal const string Error_GenericArgumentsNotAllowed = "Error_GenericArgumentsNotAllowed";

	internal const string Error_InvalidIdentifier = "Error_InvalidIdentifier";

	internal const string Error_InvalidLanguageIdentifier = "Error_InvalidLanguageIdentifier";

	internal const string DuplicateActivityIdentifier = "DuplicateActivityIdentifier";

	internal const string Error_MissingAttribute = "Error_MissingAttribute";

	internal const string Error_LoadUIPropertiesFile = "Error_LoadUIPropertiesFile";

	internal const string Error_SerializerEventGetFailed = "Error_SerializerEventGetFailed";

	internal const string Error_SerializerEventFailed = "Error_SerializerEventFailed";

	internal const string Error_SerializerNoMemberFound = "Error_SerializerNoMemberFound";

	internal const string Error_DynamicEventConflict = "Error_DynamicEventConflict";

	internal const string Error_SerializerMemberSetFailed = "Error_SerializerMemberSetFailed";

	internal const string Error_ContentPropertyCouldNotBeFound = "Error_ContentPropertyCouldNotBeFound";

	internal const string Error_ContentPropertyValueInvalid = "Error_ContentPropertyValueInvalid";

	internal const string Error_ContentPropertyNoSetter = "Error_ContentPropertyNoSetter";

	internal const string Error_ContentCanNotBeConverted = "Error_ContentCanNotBeConverted";

	internal const string Error_ContentPropertyCanNotBeNull = "Error_ContentPropertyCanNotBeNull";

	internal const string Error_SerializerTypeMismatch = "Error_SerializerTypeMismatch";

	internal const string Error_CouldNotAddValueInContentProperty = "Error_CouldNotAddValueInContentProperty";

	internal const string Error_SerializerTypeRequirement = "Error_SerializerTypeRequirement";

	internal const string Error_CanNotAddActivityInBlackBoxActivity = "Error_CanNotAddActivityInBlackBoxActivity";

	internal const string Error_ContentPropertyCanNotSupportCompactFormat = "Error_ContentPropertyCanNotSupportCompactFormat";

	internal const string Error_ContentPropertyNoMultipleContents = "Error_ContentPropertyNoMultipleContents";

	internal const string Error_InternalSerializerError = "Error_InternalSerializerError";

	internal const string Error_DictionarySerializerNonDictionaryObject = "Error_DictionarySerializerNonDictionaryObject";

	internal const string Error_DictionarySerializerKeyNotFound = "Error_DictionarySerializerKeyNotFound";

	internal const string Error_InvalidCancelActivityState = "Error_InvalidCancelActivityState";

	internal const string Error_InvalidCompensateActivityState = "Error_InvalidCompensateActivityState";

	internal const string Error_InvalidCloseActivityState = "Error_InvalidCloseActivityState";

	internal const string Error_SealedPropertyMetadata = "Error_SealedPropertyMetadata";

	internal const string Error_MemberNotFound = "Error_MemberNotFound";

	internal const string Error_EmptyPathValue = "Error_EmptyPathValue";

	internal const string Error_InvalidCompensatingState = "Error_InvalidCompensatingState";

	internal const string Error_InvalidCancelingState = "Error_InvalidCancelingState";

	internal const string Error_InvalidClosingState = "Error_InvalidClosingState";

	internal const string Error_InvalidStateToExecuteChild = "Error_InvalidStateToExecuteChild";

	internal const string Error_InvalidExecutionState = "Error_InvalidExecutionState";

	internal const string Error_InvalidInitializingState = "Error_InvalidInitializingState";

	internal const string Error_InvalidInvokingState = "Error_InvalidInvokingState";

	internal const string Error_NotRegisteredAs = "Error_NotRegisteredAs";

	internal const string Error_AlreadyRegisteredAs = "Error_AlreadyRegisteredAs";

	internal const string Error_InsertingChildControls = "Error_InsertingChildControls";

	internal const string Error_EmptyToolTipRectangle = "Error_EmptyToolTipRectangle";

	internal const string Error_EmptyRectangleValue = "Error_EmptyRectangleValue";

	internal const string Error_InvalidShadowRectangle = "Error_InvalidShadowRectangle";

	internal const string Error_InvalidShadowDepth = "Error_InvalidShadowDepth";

	internal const string Error_InvalidLightSource = "Error_InvalidLightSource";

	internal const string Error_ChangingDock = "Error_ChangingDock";

	internal const string Error_NullOrEmptyValue = "Error_NullOrEmptyValue";

	internal const string Error_InvalidStateImages = "Error_InvalidStateImages";

	internal const string Error_InvalidConnectorSegment = "Error_InvalidConnectorSegment";

	internal const string Error_InvalidConnectorSource = "Error_InvalidConnectorSource";

	internal const string Error_CreatingToolTip = "Error_CreatingToolTip";

	internal const string Error_InvalidDockStyle = "Error_InvalidDockStyle";

	internal const string Error_InvalidConnectorValue = "Error_InvalidConnectorValue";

	internal const string Error_InvalidDesignerVerbValue = "Error_InvalidDesignerVerbValue";

	internal const string Error_InvalidRuntimeType = "Error_InvalidRuntimeType";

	internal const string Error_InvalidArgumentValue = "Error_InvalidArgumentValue";

	internal const string Error_InvalidRadiusValue = "Error_InvalidRadiusValue";

	internal const string ToolTipString = "ToolTipString";

	internal const string CollectionEditorCaption = "CollectionEditorCaption";

	internal const string CollectionEditorProperties = "CollectionEditorProperties";

	internal const string CollectionEditorPropertiesMultiSelect = "CollectionEditorPropertiesMultiSelect";

	internal const string CollectionEditorPropertiesNone = "CollectionEditorPropertiesNone";

	internal const string CollectionEditorCantRemoveItem = "CollectionEditorCantRemoveItem";

	internal const string CollectionEditorUndoBatchDesc = "CollectionEditorUndoBatchDesc";

	internal const string CollectionEditorInheritedReadOnlySelection = "CollectionEditorInheritedReadOnlySelection";

	internal const string Error_ParameterAlreadyExists = "Error_ParameterAlreadyExists";

	internal const string Error_PropertyAlreadyExists = "Error_PropertyAlreadyExists";

	internal const string Error_HiddenPropertyAlreadyExists = "Error_HiddenPropertyAlreadyExists";

	internal const string Error_CorrelationInUse = "Error_CorrelationInUse";

	internal const string Error_ItemNotExists = "Error_ItemNotExists";

	internal const string Error_NoHelpAvailable = "Error_NoHelpAvailable";

	internal const string Error_DuplicateWorkflow = "Error_DuplicateWorkflow";

	internal const string Error_Recursion = "Error_Recursion";

	internal const string Error_RootActivity = "Error_RootActivity";

	internal const string Error_ConditionDefinitionDeserializationFailed = "Error_ConditionDefinitionDeserializationFailed";

	internal const string Error_InvalidConditionDefinition = "Error_InvalidConditionDefinition";

	internal const string SR_InvokeTransactionalFromAtomic = "SR_InvokeTransactionalFromAtomic";

	internal const string Error_SuspendInAtomicCallChain = "Error_SuspendInAtomicCallChain";

	internal const string Error_LiteralPassedToOutRef = "Error_LiteralPassedToOutRef";

	internal const string Error_GeneratorShouldContainSingleActivity = "Error_GeneratorShouldContainSingleActivity";

	internal const string Error_DeclaringPropertyNotSupported = "Error_DeclaringPropertyNotSupported";

	internal const string Error_DeclaringEventNotSupported = "Error_DeclaringEventNotSupported";

	internal const string Error_DynamicEventNotSupported = "Error_DynamicEventNotSupported";

	internal const string Error_DynamicPropertyNotSupported = "Error_DynamicPropertyNotSupported";

	internal const string Error_ParameterTypeResolution = "Error_ParameterTypeResolution";

	internal const string Error_DynamicActivity = "Error_DynamicActivity";

	internal const string Error_DynamicActivity2 = "Error_DynamicActivity2";

	internal const string Error_CompilerValidationFailed = "Error_CompilerValidationFailed";

	internal const string Error_RuntimeValidationFailed = "Error_RuntimeValidationFailed";

	internal const string Error_TransactionAlreadyCanceled = "Error_TransactionAlreadyCanceled";

	internal const string Error_RemoveExecutingActivity = "Error_RemoveExecutingActivity";

	internal const string Error_InsideAtomicScope = "Error_InsideAtomicScope";

	internal const string SuspendReason_WorkflowChange = "SuspendReason_WorkflowChange";

	internal const string FilterDescription_ParameterDeclaration = "FilterDescription_ParameterDeclaration";

	internal const string FilterDescription_GenericArgument = "FilterDescription_GenericArgument";

	internal const string LibraryPathIsInvalid = "LibraryPathIsInvalid";

	internal const string Error_CreateValidator = "Error_CreateValidator";

	internal const string Error_InvalidPackageFile = "Error_InvalidPackageFile";

	internal const string Error_AddAssemblyRef = "Error_AddAssemblyRef";

	internal const string Error_AssemblyBadImage = "Error_AssemblyBadImage";

	internal const string BindPropertySetterName = "BindPropertySetterName";

	internal const string Error_CannotResolveActivity = "Error_CannotResolveActivity";

	internal const string Error_CannotResolveRelativeActivity = "Error_CannotResolveRelativeActivity";

	internal const string Error_PathNotSetForActivitySource = "Error_PathNotSetForActivitySource";

	internal const string Error_InvalidMemberPath = "Error_InvalidMemberPath";

	internal const string Error_TargetTypeMismatch = "Error_TargetTypeMismatch";

	internal const string Warning_ParameterBinding = "Warning_ParameterBinding";

	internal const string Error_ReferencedActivityPropertyNotBind = "Error_ReferencedActivityPropertyNotBind";

	internal const string Error_TargetTypeDataSourcePathMismatch = "Error_TargetTypeDataSourcePathMismatch";

	internal const string Bind_ActivityDataSourceRecursionDetected = "Bind_ActivityDataSourceRecursionDetected";

	internal const string Bind_DuplicateDataSourceNames = "Bind_DuplicateDataSourceNames";

	internal const string Error_PathNotSetForXmlDataSource = "Error_PathNotSetForXmlDataSource";

	internal const string Error_XmlDocumentLoadFailed = "Error_XmlDocumentLoadFailed";

	internal const string Error_XmlDataSourceInvalidPath = "Error_XmlDataSourceInvalidPath";

	internal const string Error_XmlDataSourceMultipleNodes = "Error_XmlDataSourceMultipleNodes";

	internal const string Error_XmlDataSourceInvalidXPath = "Error_XmlDataSourceInvalidXPath";

	internal const string Error_InvalidObjectRefFormat = "Error_InvalidObjectRefFormat";

	internal const string Error_ReadOnlyDataSource = "Error_ReadOnlyDataSource";

	internal const string Error_HandlerReadOnly = "Error_HandlerReadOnly";

	internal const string Error_XmlDataSourceReadOnly = "Error_XmlDataSourceReadOnly";

	internal const string Error_DataSourceNotExist = "Error_DataSourceNotExist";

	internal const string Error_PropertyNoGetter = "Error_PropertyNoGetter";

	internal const string Error_PropertyNoSetter = "Error_PropertyNoSetter";

	internal const string Error_PropertyHasNoGetterDefined = "Error_PropertyHasNoGetterDefined";

	internal const string Error_PropertyHasNoSetterDefined = "Error_PropertyHasNoSetterDefined";

	internal const string Error_PropertyReferenceNoGetter = "Error_PropertyReferenceNoGetter";

	internal const string Error_PropertyReferenceGetterNoAccess = "Error_PropertyReferenceGetterNoAccess";

	internal const string Error_PropertyHasIndexParameters = "Error_PropertyHasIndexParameters";

	internal const string Error_ReadOnlyField = "Error_ReadOnlyField";

	internal const string Error_NoEnclosingContext = "Error_NoEnclosingContext";

	internal const string Error_NestedPersistOnClose = "Error_NestedPersistOnClose";

	internal const string Error_NestedCompensatableActivity = "Error_NestedCompensatableActivity";

	internal const string Error_InvalidActivityForObjectDatasource = "Error_InvalidActivityForObjectDatasource";

	internal const string Error_DataSourceTypeConversionFailed = "Error_DataSourceTypeConversionFailed";

	internal const string Error_BindDialogWrongPropertyType = "Error_BindDialogWrongPropertyType";

	internal const string Error_BindDialogNoValidPropertySelected = "Error_BindDialogNoValidPropertySelected";

	internal const string Error_BindDialogBindNotValid = "Error_BindDialogBindNotValid";

	internal const string Error_BindDialogCanNotBindToItself = "Error_BindDialogCanNotBindToItself";

	internal const string Error_BindActivityReference = "Error_BindActivityReference";

	internal const string Error_NoTargetTypeForMethod = "Error_NoTargetTypeForMethod";

	internal const string Error_MethodDataSourceIsReadOnly = "Error_MethodDataSourceIsReadOnly";

	internal const string Error_NotMethodDataSource = "Error_NotMethodDataSource";

	internal const string Error_MethodDataSourceWithPath = "Error_MethodDataSourceWithPath";

	internal const string Error_PathSyntax = "Error_PathSyntax";

	internal const string Error_UnmatchedParen = "Error_UnmatchedParen";

	internal const string Error_UnmatchedBracket = "Error_UnmatchedBracket";

	internal const string Error_MemberWithSameNameExists = "Error_MemberWithSameNameExists";

	internal const string Error_ActivityIdentifierCanNotBeEmpty = "Error_ActivityIdentifierCanNotBeEmpty";

	internal const string Error_InvalidActivityIdentifier = "Error_InvalidActivityIdentifier";

	internal const string Error_ActivityBindTypeConversionError = "Error_ActivityBindTypeConversionError";

	internal const string EmptyValue = "EmptyValue";

	internal const string Error_PropertyTypeNotDefined = "Error_PropertyTypeNotDefined";

	internal const string Error_CompilationFailed = "Error_CompilationFailed";

	internal const string Error_MissingCompilationContext = "Error_MissingCompilationContext";

	internal const string InvokeWorkflowReference_VB = "InvokeWorkflowReference_VB";

	internal const string InvokeWorkflowReference_CS = "InvokeWorkflowReference_CS";

	internal const string Error_InvalidListItem = "Error_InvalidListItem";

	internal const string ParserMapPINoWhitespace = "ParserMapPINoWhitespace";

	internal const string ParserMapPIBadCharEqual = "ParserMapPIBadCharEqual";

	internal const string ParserMapPIBadCharQuote = "ParserMapPIBadCharQuote";

	internal const string ParserMapPIBadKey = "ParserMapPIBadKey";

	internal const string ParserMapPIMissingKey = "ParserMapPIMissingKey";

	internal const string ParserMapPIKeyNotSet = "ParserMapPIKeyNotSet";

	internal const string ParserMismatchDelimiter = "ParserMismatchDelimiter";

	internal const string ParserDanglingClause = "ParserDanglingClause";

	internal const string UnknownDefinitionTag = "UnknownDefinitionTag";

	internal const string CDATASection = "CDATASection";

	internal const string TextSection = "TextSection";

	internal const string IncorrectSyntax = "IncorrectSyntax";

	internal const string IncorrectTypeSyntax = "IncorrectTypeSyntax";

	internal const string Error_MultipleRootActivityCreator = "Error_MultipleRootActivityCreator";

	internal const string Error_MustHaveParent = "Error_MustHaveParent";

	internal const string Error_ReferenceObjNotInitialized = "Error_ReferenceObjNotInitialized";

	internal const string Error_ReferenceInitResourceManager = "Error_ReferenceInitResourceManager";

	internal const string Error_ResourceReferenceGetObject = "Error_ResourceReferenceGetObject";

	internal const string Error_RefBindCantFindRef = "Error_RefBindCantFindRef";

	internal const string Error_RefBindMissingReferenceName = "Error_RefBindMissingReferenceName";

	internal const string Error_RefBindMissingAttribute = "Error_RefBindMissingAttribute";

	internal const string Error_ReferenceLoad = "Error_ReferenceLoad";

	internal const string Error_ReferenceMissingAttribute = "Error_ReferenceMissingAttribute";

	internal const string Error_ReferenceInvalidResourceFile = "Error_ReferenceInvalidResourceFile";

	internal const string Error_ReferenceEmptyName = "Error_ReferenceEmptyName";

	internal const string HandlerInvokerName = "HandlerInvokerName";

	internal const string HandlerInvokerSwitchPrefix_CS = "HandlerInvokerSwitchPrefix_CS";

	internal const string HandlerInvokerSwitchPrefix_VB = "HandlerInvokerSwitchPrefix_VB";

	internal const string HandlerInvokerSwitchSuffix_CS = "HandlerInvokerSwitchSuffix_CS";

	internal const string HandlerInvokerSwitchSuffix_VB = "HandlerInvokerSwitchSuffix_VB";

	internal const string HandlerInvokerCaseBegin_CS = "HandlerInvokerCaseBegin_CS";

	internal const string HandlerInvokerCaseBegin_VB = "HandlerInvokerCaseBegin_VB";

	internal const string Standard = "Standard";

	internal const string Base = "Base";

	internal const string ValidatorCompanionClassDesc = "ValidatorCompanionClassDesc";

	internal const string ExecutorCompanionClassDesc = "ExecutorCompanionClassDesc";

	internal const string DesignerCompanionClassDesc = "DesignerCompanionClassDesc";

	internal const string CustomActivityBaseTypeDesc = "CustomActivityBaseTypeDesc";

	internal const string ActivityProperties = "ActivityProperties";

	internal const string ActivityPropertiesDesc = "ActivityPropertiesDesc";

	internal const string CompanionClasses = "CompanionClasses";

	internal const string ActivityDesc = "Activity";

	internal const string Error_TypeConversionFailed = "Error_TypeConversionFailed";

	internal const string SupportDataContext = "SupportDataContext";

	internal const string AdvancedCategory = "AdvancedCategory";

	internal const string SupportDataContextDesc = "SupportDataContextDesc";

	internal const string BaseCompanionClassName = "BaseCompanionClassName";

	internal const string BaseCompanionClassDesc = "BaseCompanionClassDesc";

	internal const string Designer = "Designer";

	internal const string Validator = "Validator";

	internal const string Executor = "Executor";

	internal const string BaseActivityType = "BaseActivityType";

	internal const string Error_NotBuiltInActivity = "Error_NotBuiltInActivity";

	internal const string NoChildActivities_Message = "NoChildActivities_Message";

	internal const string NoChildActivities_Caption = "NoChildActivities_Caption";

	internal const string Error_CustomActivityCantCreate = "Error_CustomActivityCantCreate";

	internal const string Error_CantChangeBuiltInActivity = "Error_CantChangeBuiltInActivity";

	internal const string Error_CantAddBeforeBuiltInActivity = "Error_CantAddBeforeBuiltInActivity";

	internal const string Error_CantAddAfterNonBuiltInActivity = "Error_CantAddAfterNonBuiltInActivity";

	internal const string Error_CannotAddRemoveChildActivities = "Error_CannotAddRemoveChildActivities";

	internal const string Error_CantFindBuiltInActivity = "Error_CantFindBuiltInActivity";

	internal const string Error_MissingBaseCompanionClassAttribute = "Error_MissingBaseCompanionClassAttribute";

	internal const string Error_CantFindBuiltInParent = "Error_CantFindBuiltInParent";

	internal const string Error_CantCreateInstanceOfBaseType = "Error_CantCreateInstanceOfBaseType";

	internal const string Error_CustomActivityTypeCouldNotBeFound = "Error_CustomActivityTypeCouldNotBeFound";

	internal const string None = "None";

	internal const string AtomicTransaction = "AtomicTransaction";

	internal const string LocalDataContext = "LocalDataContext";

	internal const string LocalDataContextDesc = "LocalDataContextDesc";

	internal const string CompanionClass = "CompanionClass";

	internal const string Error_AlreadyRootActivity = "Error_AlreadyRootActivity";

	internal const string RootActivityName = "RootActivityName";

	internal const string RootActivityNameDesc = "RootActivityNameDesc";

	internal const string CustomProperties = "CustomProperties";

	internal const string VisibleDescr = "VisibleDescr";

	internal const string EditableDescr = "EditableDescr";

	internal const string Error_CantCreateMethod = "Error_CantCreateMethod";

	internal const string Error_CantEditNullValue = "Error_CantEditNullValue";

	internal const string Error_CompanionTypeNotSet = "Error_CompanionTypeNotSet";

	internal const string Error_CompanionClassNameCanNotBeEmpty = "Error_CompanionClassNameCanNotBeEmpty";

	internal const string Error_CouldNotEmitFieldInLocalDataContext = "Error_CouldNotEmitFieldInLocalDataContext";

	internal const string Error_CouldNotEmitMethodInLocalDataContext = "Error_CouldNotEmitMethodInLocalDataContext";

	internal const string Error_DerivationFromTypeWithLocalDataContext = "Error_DerivationFromTypeWithLocalDataContext";

	internal const string Error_CompanionTypeDerivationError = "Error_CompanionTypeDerivationError";

	internal const string Error_CantCreateDataContextClass = "Error_CantCreateDataContextClass";

	internal const string ArrayExistingBind = "ArrayExistingBind";

	internal const string Error_NoMatchingFieldsOrProperties = "Error_NoMatchingFieldsOrProperties";

	internal const string ChooseFieldPropertyDatasource = "ChooseFieldPropertyDatasource";

	internal const string SupportsTransaction = "SupportsTransaction";

	internal const string SupportsExceptions = "SupportsExceptions";

	internal const string SupportsCancellationHandlerActivity = "SupportsCancellationHandlerActivity";

	internal const string SupportsEvents = "SupportsEvents";

	internal const string SupportsDataSources = "SupportsDataSources";

	internal const string SupportsCompensationHandler = "SupportsCompensationHandler";

	internal const string SupportsCompensationHandlerDesc = "SupportsCompensationHandlerDesc";

	internal const string SupportsTransactionDesc = "SupportsTransactionDesc";

	internal const string SupportsExceptionsDesc = "SupportsExceptionsDesc";

	internal const string SupportsCancelHandlerDesc = "SupportsCancelHandlerDesc";

	internal const string SupportsEventsDesc = "SupportsEventsDesc";

	internal const string TransactionDesc = "TransactionDesc";

	internal const string Error_BaseTypeMustBeActivity = "Error_BaseTypeMustBeActivity";

	internal const string ExistingActivityBindTitle = "ExistingActivityBindTitle";

	internal const string ExistingActivityBindLabel = "ExistingActivityBindLabel";

	internal const string ExistingFieldPropBindTitle = "ExistingFieldPropBindTitle";

	internal const string ExistingFieldPropBindLabel = "ExistingFieldPropBindLabel";

	internal const string ProvidesSynchronization = "ProvidesSynchronization";

	internal const string ProvidesSynchronizationDesc = "ProvidesSynchronizationDesc";

	internal const string SynchronizationHandles = "SynchronizationHandles";

	internal const string SynchronizationHandlesDesc = "SynchronizationHandlesDesc";

	internal const string Error_TransactionAlreadyApplied = "Error_TransactionAlreadyApplied";

	internal const string Error_BindBaseTypeNotSpecified = "Error_BindBaseTypeNotSpecified";

	internal const string NonDelegateTargetType = "NonDelegateTargetType";

	internal const string Error_ClassnameNotInRootNamespace = "Error_ClassnameNotInRootNamespace";

	internal const string Error_CantUseCurrentProjectTypeAsBase = "Error_CantUseCurrentProjectTypeAsBase";

	internal const string Error_UnboundGenericType = "Error_UnboundGenericType";

	internal const string Error_UnboundGenericTypeDataSource = "Error_UnboundGenericTypeDataSource";

	internal const string Error_BaseTypeUnknown = "Error_BaseTypeUnknown";

	internal const string Error_UnconfiguredBind = "Error_UnconfiguredBind";

	internal const string Error_CanNotEmitMemberInLocalDataContext = "Error_CanNotEmitMemberInLocalDataContext";

	internal const string Error_DesignedTypeNotFound = "Error_DesignedTypeNotFound";

	internal const string Error_PathCouldNotBeResolvedToMember = "Error_PathCouldNotBeResolvedToMember";

	internal const string Error_EdittingNullCollection = "Error_EdittingNullCollection";

	internal const string Error_MoreThanOneCompensationDecl = "Error_MoreThanOneCompensationDecl";

	internal const string Error_ParentDoesNotSupportCompensation = "Error_ParentDoesNotSupportCompensation";

	internal const string Error_CantResolveEventHandler = "Error_CantResolveEventHandler";

	internal const string Error_XSDObjectTypeNotSerializable = "Error_XSDObjectTypeNotSerializable";

	internal const string AEC_InvalidActivity = "AEC_InvalidActivity";

	internal const string GetDynamicActivities_InvalidActivity = "GetDynamicActivities_InvalidActivity";

	internal const string AEC_InvalidNestedActivity = "AEC_InvalidNestedActivity";

	internal const string Error_IDNotSetForActivitySource = "Error_IDNotSetForActivitySource";

	internal const string Error_InvalidCustomPropertyName = "Error_InvalidCustomPropertyName";

	internal const string Error_InvalidCustomPropertyType = "Error_InvalidCustomPropertyType";

	internal const string Error_DPReadOnly = "Error_DPReadOnly";

	internal const string Error_DPMetaPropertyBinding = "Error_DPMetaPropertyBinding";

	internal const string Error_DPSetValueBind = "Error_DPSetValueBind";

	internal const string Error_DPSetValueHandler = "Error_DPSetValueHandler";

	internal const string Error_DPGetValueHandler = "Error_DPGetValueHandler";

	internal const string Error_DPAddHandlerNonEvent = "Error_DPAddHandlerNonEvent";

	internal const string Error_DPAddHandlerMetaProperty = "Error_DPAddHandlerMetaProperty";

	internal const string Error_DPRemoveHandlerBind = "Error_DPRemoveHandlerBind";

	internal const string Error_LanguageNeedsToBeVBCSharp = "Error_LanguageNeedsToBeVBCSharp";

	internal const string Error_TargetFxNotSupported = "Error_TargetFxNotSupported";

	internal const string Error_CantConvertValueValue = "Error_CantConvertValueValue";

	internal const string Error_TypeIsNotValid = "Error_TypeIsNotValid";

	internal const string Error_TypePropertyInvalid = "Error_TypePropertyInvalid";

	internal const string Error_EventCantBeMetaProperty = "Error_EventCantBeMetaProperty";

	internal const string Error_EventMustBeDelegate = "Error_EventMustBeDelegate";

	internal const string Error_DPPropertyTypeMissing = "Error_DPPropertyTypeMissing";

	internal const string TransactionalContextActivityDescription = "TransactionalContextActivityDescription";

	internal const string CompensatableTransactionalContextActivityDescription = "CompensatableTransactionalContextActivityDescription";

	internal const string SynchronizationScopeActivityDescription = "SynchronizationScopeActivityDescription";

	internal const string SequenceActivityDescription = "SequenceActivityDescription";

	internal const string CompensateActivityDescription = "CompensateActivityDescription";

	internal const string Error_CompensateBadTargetTX = "Error_CompensateBadTargetTX";

	internal const string Error_CancelHandlerParentNotScope = "Error_CancelHandlerParentNotScope";

	internal const string FaultHandlerActivityDescription = "FaultHandlerActivityDescription";

	internal const string Error_ExceptionTypeNotException = "Error_ExceptionTypeNotException";

	internal const string Error_FaultIsNotOfFaultType = "Error_FaultIsNotOfFaultType";

	internal const string Error_FaultTypeNoDefaultConstructor = "Error_FaultTypeNoDefaultConstructor";

	internal const string FilterDescription_FaultHandlerActivity = "FilterDescription_FaultHandlerActivity";

	internal const string Error_FaultHandlerActivityParentNotFaultHandlersActivity = "Error_FaultHandlerActivityParentNotFaultHandlersActivity";

	internal const string Error_FaultHandlerActivityAllMustBeLast = "Error_FaultHandlerActivityAllMustBeLast";

	internal const string Error_FaultHandlersActivityDeclNotAllFaultHandlerActivityDecl = "Error_FaultHandlersActivityDeclNotAllFaultHandlerActivityDecl";

	internal const string Error_FaultHandlerActivityWrongOrder = "Error_FaultHandlerActivityWrongOrder";

	internal const string Error_SenderMustBeActivityExecutionContext = "Error_SenderMustBeActivityExecutionContext";

	internal const string Error_XomlWorkflowHasCode = "Error_XomlWorkflowHasCode";

	internal const string Error_WrongParamForActivityResolveEventArgs = "Error_WrongParamForActivityResolveEventArgs";

	internal const string Error_ValidatorThrewException = "Error_ValidatorThrewException";

	internal const string Error_Missing_CanModifyProperties_True = "Error_Missing_CanModifyProperties_True";

	internal const string Error_Missing_CanModifyProperties_False = "Error_Missing_CanModifyProperties_False";

	internal const string Error_ModelingConstructsCanNotContainModelingConstructs = "Error_ModelingConstructsCanNotContainModelingConstructs";

	internal const string Error_RootIsNotEnabled = "Error_RootIsNotEnabled";

	internal const string Error_MissingSetAccessor = "Error_MissingSetAccessor";

	internal const string Error_MissingAddHandler = "Error_MissingAddHandler";

	internal const string Error_MissingCLRProperty = "Error_MissingCLRProperty";

	internal const string Error_NotReadOnlyProperty = "Error_NotReadOnlyProperty";

	internal const string Error_InvalidDependencyProperty = "Error_InvalidDependencyProperty";

	internal const string Error_ActivityNameExist = "Error_ActivityNameExist";

	internal const string CannotCreateAttribute = "CannotCreateAttribute";

	internal const string NamespaceAndDeclaringTypeCannotBeNull = "NamespaceAndDeclaringTypeCannotBeNull";

	internal const string NotElementType = "NotElementType";

	internal const string Error_LayoutSerializationActivityNotFound = "Error_LayoutSerializationActivityNotFound";

	internal const string Error_LayoutSerializationAssociatedActivityNotFound = "Error_LayoutSerializationAssociatedActivityNotFound";

	internal const string Error_LayoutSerializationPersistenceSupport = "Error_LayoutSerializationPersistenceSupport";

	internal const string Error_LayoutSerializationRootDesignerNotFound = "Error_LayoutSerializationRootDesignerNotFound";

	internal const string Error_ParameterCannotBeEmpty = "Error_ParameterCannotBeEmpty";

	internal const string InvalidExecutionStatus = "InvalidExecutionStatus";

	internal const string Error_LayoutDeserialization = "Error_LayoutDeserialization";

	internal const string Error_LayoutSerialization = "Error_LayoutSerialization";

	internal const string Error_SerializerStackOverflow = "Error_SerializerStackOverflow";

	internal const string Error_InvalidActivityForWorkflowChanges = "Error_InvalidActivityForWorkflowChanges";

	internal const string Error_InvalidMemberType = "Error_InvalidMemberType";

	internal const string Error_BindPathNullValue = "Error_BindPathNullValue";

	internal const string Error_MarkupExtensionMissingTerminatingCharacter = "Error_MarkupExtensionMissingTerminatingCharacter";

	internal const string Error_MarkupExtensionDeserializeFailed = "Error_MarkupExtensionDeserializeFailed";

	internal const string Error_ApplyDynamicChangeFailed = "Error_ApplyDynamicChangeFailed";

	internal const string Error_ActivityCircularReference = "Error_ActivityCircularReference";

	internal const string Error_ValidatorTypeIsInvalid = "Error_ValidatorTypeIsInvalid";

	internal const string Error_InvalidServiceProvider = "Error_InvalidServiceProvider";

	internal const string Error_InvalidRootForWorkflowChanges = "Error_InvalidRootForWorkflowChanges";

	internal const string Error_ExtraCharacterFoundAtEnd = "Error_ExtraCharacterFoundAtEnd";

	internal const string Error_WorkflowChangesNotSupported = "Error_WorkflowChangesNotSupported";

	internal const string Error_TypeSystemAttributeArgument = "Error_TypeSystemAttributeArgument";

	internal const string Error_InvalidElementFoundForType = "Error_InvalidElementFoundForType";

	internal const string Error_ActivitySaveLoadNotCalled = "Error_ActivitySaveLoadNotCalled";

	internal const string Error_CanNotBindProperty = "Error_CanNotBindProperty";

	internal const string RTL = "RTL";

	internal const string DebugLaunchFailed = "DebugLaunchFailed";

	internal const string DebugLaunchFailedTitle = "DebugLaunchFailedTitle";

	internal const string DebugAssertTitle = "DebugAssertTitle";

	internal const string DebugAssertBanner = "DebugAssertBanner";

	internal const string DebugAssertShortMessage = "DebugAssertShortMessage";

	internal const string DebugAssertLongMessage = "DebugAssertLongMessage";

	internal const string DebugMessageTruncated = "DebugMessageTruncated";

	internal const string ObjectDisposed = "ObjectDisposed";

	internal const string NotSupported = "NotSupported";

	internal const string ExceptionOccurred = "ExceptionOccurred";

	internal const string MustAddListener = "MustAddListener";

	internal const string ToStringNull = "ToStringNull";

	internal const string EnumConverterInvalidValue = "EnumConverterInvalidValue";

	internal const string ConvertFromException = "ConvertFromException";

	internal const string ConvertToException = "ConvertToException";

	internal const string ConvertInvalidPrimitive = "ConvertInvalidPrimitive";

	internal const string ErrorMissingPropertyAccessors = "ErrorMissingPropertyAccessors";

	internal const string ErrorInvalidPropertyType = "ErrorInvalidPropertyType";

	internal const string ErrorMissingEventAccessors = "ErrorMissingEventAccessors";

	internal const string ErrorInvalidEventHandler = "ErrorInvalidEventHandler";

	internal const string ErrorInvalidEventType = "ErrorInvalidEventType";

	internal const string InvalidMemberName = "InvalidMemberName";

	internal const string ErrorBadExtenderType = "ErrorBadExtenderType";

	internal const string NullableConverterBadCtorArg = "NullableConverterBadCtorArg";

	internal const string TypeDescriptorExpectedElementType = "TypeDescriptorExpectedElementType";

	internal const string TypeDescriptorSameAssociation = "TypeDescriptorSameAssociation";

	internal const string TypeDescriptorAlreadyAssociated = "TypeDescriptorAlreadyAssociated";

	internal const string TypeDescriptorProviderError = "TypeDescriptorProviderError";

	internal const string TypeDescriptorUnsupportedRemoteObject = "TypeDescriptorUnsupportedRemoteObject";

	internal const string TypeDescriptorArgsCountMismatch = "TypeDescriptorArgsCountMismatch";

	internal const string ErrorCreateSystemEvents = "ErrorCreateSystemEvents";

	internal const string ErrorCreateTimer = "ErrorCreateTimer";

	internal const string ErrorKillTimer = "ErrorKillTimer";

	internal const string ErrorSystemEventsNotSupported = "ErrorSystemEventsNotSupported";

	internal const string ErrorGetTempPath = "ErrorGetTempPath";

	internal const string CHECKOUTCanceled = "CHECKOUTCanceled";

	internal const string ErrorInvalidServiceInstance = "ErrorInvalidServiceInstance";

	internal const string ErrorServiceExists = "ErrorServiceExists";

	internal const string ArgumentNull_Key = "ArgumentNull_Key";

	internal const string Argument_AddingDuplicate = "Argument_AddingDuplicate";

	internal const string Argument_InvalidValue = "Argument_InvalidValue";

	internal const string ArgumentOutOfRange_NeedNonNegNum = "ArgumentOutOfRange_NeedNonNegNum";

	internal const string ArgumentOutOfRange_InvalidThreshold = "ArgumentOutOfRange_InvalidThreshold";

	internal const string InvalidOperation_EnumFailedVersion = "InvalidOperation_EnumFailedVersion";

	internal const string InvalidOperation_EnumOpCantHappen = "InvalidOperation_EnumOpCantHappen";

	internal const string Arg_MultiRank = "Arg_MultiRank";

	internal const string Arg_NonZeroLowerBound = "Arg_NonZeroLowerBound";

	internal const string Arg_InsufficientSpace = "Arg_InsufficientSpace";

	internal const string NotSupported_EnumeratorReset = "NotSupported_EnumeratorReset";

	internal const string Invalid_Array_Type = "Invalid_Array_Type";

	internal const string Serialization_InvalidOnDeser = "Serialization_InvalidOnDeser";

	internal const string Serialization_MissingValues = "Serialization_MissingValues";

	internal const string Serialization_MismatchedCount = "Serialization_MismatchedCount";

	internal const string ExternalLinkedListNode = "ExternalLinkedListNode";

	internal const string LinkedListNodeIsAttached = "LinkedListNodeIsAttached";

	internal const string LinkedListEmpty = "LinkedListEmpty";

	internal const string Arg_WrongType = "Arg_WrongType";

	internal const string Argument_ItemNotExist = "Argument_ItemNotExist";

	internal const string Argument_ImplementIComparable = "Argument_ImplementIComparable";

	internal const string InvalidOperation_EmptyCollection = "InvalidOperation_EmptyCollection";

	internal const string InvalidOperation_EmptyQueue = "InvalidOperation_EmptyQueue";

	internal const string InvalidOperation_EmptyStack = "InvalidOperation_EmptyStack";

	internal const string InvalidOperation_CannotRemoveFromStackOrQueue = "InvalidOperation_CannotRemoveFromStackOrQueue";

	internal const string ArgumentOutOfRange_Index = "ArgumentOutOfRange_Index";

	internal const string ArgumentOutOfRange_SmallCapacity = "ArgumentOutOfRange_SmallCapacity";

	internal const string Argument_AdjustmentRulesNoNulls = "Argument_AdjustmentRulesNoNulls";

	internal const string Argument_AdjustmentRulesOutOfOrder = "Argument_AdjustmentRulesOutOfOrder";

	internal const string Argument_AdjustmentRulesAmbiguousOverlap = "Argument_AdjustmentRulesAmbiguousOverlap";

	internal const string Argument_AdjustmentRulesrDaylightSavingTimeOverlap = "Argument_AdjustmentRulesrDaylightSavingTimeOverlap";

	internal const string Argument_AdjustmentRulesrDaylightSavingTimeOverlapNonRuleRange = "Argument_AdjustmentRulesrDaylightSavingTimeOverlapNonRuleRange";

	internal const string Argument_AdjustmentRulesInvalidOverlap = "Argument_AdjustmentRulesInvalidOverlap";

	internal const string Argument_ConvertMismatch = "Argument_ConvertMismatch";

	internal const string Argument_DateTimeHasTimeOfDay = "Argument_DateTimeHasTimeOfDay";

	internal const string Argument_DateTimeIsInvalid = "Argument_DateTimeIsInvalid";

	internal const string Argument_DateTimeIsNotAmbiguous = "Argument_DateTimeIsNotAmbiguous";

	internal const string Argument_DateTimeOffsetIsNotAmbiguous = "Argument_DateTimeOffsetIsNotAmbiguous";

	internal const string Argument_DateTimeKindMustBeUnspecified = "Argument_DateTimeKindMustBeUnspecified";

	internal const string Argument_DateTimeHasTicks = "Argument_DateTimeHasTicks";

	internal const string Argument_InvalidId = "Argument_InvalidId";

	internal const string Argument_InvalidSerializedString = "Argument_InvalidSerializedString";

	internal const string Argument_InvalidREG_TZI_FORMAT = "Argument_InvalidREG_TZI_FORMAT";

	internal const string Argument_OutOfOrderDateTimes = "Argument_OutOfOrderDateTimes";

	internal const string Argument_TimeSpanHasSeconds = "Argument_TimeSpanHasSeconds";

	internal const string Argument_TransitionTimesAreIdentical = "Argument_TransitionTimesAreIdentical";

	internal const string ArgumentOutOfRange_Day = "ArgumentOutOfRange_Day";

	internal const string ArgumentOutOfRange_DayOfWeek = "ArgumentOutOfRange_DayOfWeek";

	internal const string ArgumentOutOfRange_Month = "ArgumentOutOfRange_Month";

	internal const string ArgumentOutOfRange_UtcOffset = "ArgumentOutOfRange_UtcOffset";

	internal const string ArgumentOutOfRange_UtcOffsetAndDaylightDelta = "ArgumentOutOfRange_UtcOffsetAndDaylightDelta";

	internal const string ArgumentOutOfRange_Week = "ArgumentOutOfRange_Week";

	internal const string InvalidTimeZone_InvalidRegistryData = "InvalidTimeZone_InvalidRegistryData";

	internal const string InvalidTimeZone_InvalidWin32APIData = "InvalidTimeZone_InvalidWin32APIData";

	internal const string Security_CannotReadRegistryData = "Security_CannotReadRegistryData";

	internal const string Serialization_CorruptField = "Serialization_CorruptField";

	internal const string Serialization_InvalidData = "Serialization_InvalidData";

	internal const string Serialization_InvalidEscapeSequence = "Serialization_InvalidEscapeSequence";

	internal const string TimeZoneNotFound_MissingRegistryData = "TimeZoneNotFound_MissingRegistryData";

	internal const string Argument_WrongAsyncResult = "Argument_WrongAsyncResult";

	internal const string Argument_NeedNonemptyPipeName = "Argument_NeedNonemptyPipeName";

	internal const string Argument_EmptyServerName = "Argument_EmptyServerName";

	internal const string Argument_NonContainerInvalidAnyFlag = "Argument_NonContainerInvalidAnyFlag";

	internal const string ArgumentNull_ServerName = "ArgumentNull_ServerName";

	internal const string ArgumentOutOfRange_AdditionalAccessLimited = "ArgumentOutOfRange_AdditionalAccessLimited";

	internal const string ArgumentOutOfRange_AnonymousReserved = "ArgumentOutOfRange_AnonymousReserved";

	internal const string ArgumentOutOfRange_TransmissionModeByteOrMsg = "ArgumentOutOfRange_TransmissionModeByteOrMsg";

	internal const string ArgumentOutOfRange_DirectionModeInOrOut = "ArgumentOutOfRange_DirectionModeInOrOut";

	internal const string ArgumentOutOfRange_DirectionModeInOutOrInOut = "ArgumentOutOfRange_DirectionModeInOutOrInOut";

	internal const string ArgumentOutOfRange_ImpersonationInvalid = "ArgumentOutOfRange_ImpersonationInvalid";

	internal const string ArgumentOutOfRange_ImpersonationOptionsInvalid = "ArgumentOutOfRange_ImpersonationOptionsInvalid";

	internal const string ArgumentOutOfRange_OptionsInvalid = "ArgumentOutOfRange_OptionsInvalid";

	internal const string ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable = "ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable";

	internal const string ArgumentOutOfRange_InvalidPipeAccessRights = "ArgumentOutOfRange_InvalidPipeAccessRights";

	internal const string ArgumentOutOfRange_InvalidTimeout = "ArgumentOutOfRange_InvalidTimeout";

	internal const string ArgumentOutOfRange_MaxNumServerInstances = "ArgumentOutOfRange_MaxNumServerInstances";

	internal const string ArgumentOutOfRange_NeedValidPipeAccessRights = "ArgumentOutOfRange_NeedValidPipeAccessRights";

	internal const string InvalidOperation_EndWaitForConnectionCalledMultiple = "InvalidOperation_EndWaitForConnectionCalledMultiple";

	internal const string InvalidOperation_PipeNotYetConnected = "InvalidOperation_PipeNotYetConnected";

	internal const string InvalidOperation_PipeDisconnected = "InvalidOperation_PipeDisconnected";

	internal const string InvalidOperation_PipeHandleNotSet = "InvalidOperation_PipeHandleNotSet";

	internal const string InvalidOperation_PipeNotAsync = "InvalidOperation_PipeNotAsync";

	internal const string InvalidOperation_PipeReadModeNotMessage = "InvalidOperation_PipeReadModeNotMessage";

	internal const string InvalidOperation_PipeMessageTypeNotSupported = "InvalidOperation_PipeMessageTypeNotSupported";

	internal const string InvalidOperation_PipeAlreadyConnected = "InvalidOperation_PipeAlreadyConnected";

	internal const string InvalidOperation_PipeAlreadyDisconnected = "InvalidOperation_PipeAlreadyDisconnected";

	internal const string InvalidOperation_PipeClosed = "InvalidOperation_PipeClosed";

	internal const string IO_FileTooLongOrHandleNotSync = "IO_FileTooLongOrHandleNotSync";

	internal const string IO_FileNotFound = "IO_FileNotFound";

	internal const string IO_FileNotFound_FileName = "IO_FileNotFound_FileName";

	internal const string IO_IO_AlreadyExists_Name = "IO_IO_AlreadyExists_Name";

	internal const string IO_IO_BindHandleFailed = "IO_IO_BindHandleFailed";

	internal const string IO_IO_FileExists_Name = "IO_IO_FileExists_Name";

	internal const string IO_IO_NoPermissionToDirectoryName = "IO_IO_NoPermissionToDirectoryName";

	internal const string IO_IO_SharingViolation_File = "IO_IO_SharingViolation_File";

	internal const string IO_IO_SharingViolation_NoFileName = "IO_IO_SharingViolation_NoFileName";

	internal const string IO_IO_PipeBroken = "IO_IO_PipeBroken";

	internal const string IO_IO_InvalidPipeHandle = "IO_IO_InvalidPipeHandle";

	internal const string IO_DriveNotFound_Drive = "IO_DriveNotFound_Drive";

	internal const string IO_PathNotFound_Path = "IO_PathNotFound_Path";

	internal const string IO_PathNotFound_NoPathName = "IO_PathNotFound_NoPathName";

	internal const string NotSupported_IONonFileDevices = "NotSupported_IONonFileDevices";

	internal const string NotSupported_MemStreamNotExpandable = "NotSupported_MemStreamNotExpandable";

	internal const string NotSupported_AnonymousPipeUnidirectional = "NotSupported_AnonymousPipeUnidirectional";

	internal const string NotSupported_AnonymousPipeMessagesNotSupported = "NotSupported_AnonymousPipeMessagesNotSupported";

	internal const string ObjectDisposed_FileClosed = "ObjectDisposed_FileClosed";

	internal const string ObjectDisposed_PipeClosed = "ObjectDisposed_PipeClosed";

	internal const string ObjectDisposed_ReaderClosed = "ObjectDisposed_ReaderClosed";

	internal const string PlatformNotSupported_NamedPipeServers = "PlatformNotSupported_NamedPipeServers";

	internal const string ArgumentOutOfRange_NeedValidLogRetention = "ArgumentOutOfRange_NeedValidLogRetention";

	internal const string ArgumentOutOfRange_NeedMaxFileSizeGEBufferSize = "ArgumentOutOfRange_NeedMaxFileSizeGEBufferSize";

	internal const string ArgumentOutOfRange_NeedValidMaxNumFiles = "ArgumentOutOfRange_NeedValidMaxNumFiles";

	internal const string ArgumentOutOfRange_NeedValidId = "ArgumentOutOfRange_NeedValidId";

	internal const string ArgumentOutOfRange_MaxArgExceeded = "ArgumentOutOfRange_MaxArgExceeded";

	internal const string ArgumentOutOfRange_MaxStringsExceeded = "ArgumentOutOfRange_MaxStringsExceeded";

	internal const string NotSupported_DownLevelVista = "NotSupported_DownLevelVista";

	internal const string Argument_NeedNonemptyDelimiter = "Argument_NeedNonemptyDelimiter";

	internal const string NotSupported_SetTextWriter = "NotSupported_SetTextWriter";

	internal const string Perflib_PlatformNotSupported = "Perflib_PlatformNotSupported";

	internal const string Perflib_Argument_CounterSetAlreadyRegister = "Perflib_Argument_CounterSetAlreadyRegister";

	internal const string Perflib_Argument_InvalidCounterType = "Perflib_Argument_InvalidCounterType";

	internal const string Perflib_Argument_InvalidCounterSetInstanceType = "Perflib_Argument_InvalidCounterSetInstanceType";

	internal const string Perflib_Argument_InstanceAlreadyExists = "Perflib_Argument_InstanceAlreadyExists";

	internal const string Perflib_Argument_CounterAlreadyExists = "Perflib_Argument_CounterAlreadyExists";

	internal const string Perflib_Argument_CounterNameAlreadyExists = "Perflib_Argument_CounterNameAlreadyExists";

	internal const string Perflib_Argument_ProviderNotFound = "Perflib_Argument_ProviderNotFound";

	internal const string Perflib_Argument_InvalidInstance = "Perflib_Argument_InvalidInstance";

	internal const string Perflib_Argument_EmptyInstanceName = "Perflib_Argument_EmptyInstanceName";

	internal const string Perflib_Argument_EmptyCounterName = "Perflib_Argument_EmptyCounterName";

	internal const string Perflib_InsufficientMemory_InstanceCounterBlock = "Perflib_InsufficientMemory_InstanceCounterBlock";

	internal const string Perflib_InsufficientMemory_CounterSetTemplate = "Perflib_InsufficientMemory_CounterSetTemplate";

	internal const string Perflib_InvalidOperation_CounterRefValue = "Perflib_InvalidOperation_CounterRefValue";

	internal const string Perflib_InvalidOperation_CounterSetNotInstalled = "Perflib_InvalidOperation_CounterSetNotInstalled";

	internal const string Perflib_InvalidOperation_InstanceNotFound = "Perflib_InvalidOperation_InstanceNotFound";

	internal const string Perflib_InvalidOperation_AddCounterAfterInstance = "Perflib_InvalidOperation_AddCounterAfterInstance";

	internal const string Perflib_InvalidOperation_NoActiveProvider = "Perflib_InvalidOperation_NoActiveProvider";

	internal const string Perflib_InvalidOperation_CounterSetContainsNoCounter = "Perflib_InvalidOperation_CounterSetContainsNoCounter";

	internal const string Arg_HSCapacityOverflow = "Arg_HSCapacityOverflow";

	internal const string Serialization_MissingKeys = "Serialization_MissingKeys";

	internal const string LockRecursionException_RecursiveReadNotAllowed = "LockRecursionException_RecursiveReadNotAllowed";

	internal const string LockRecursionException_RecursiveWriteNotAllowed = "LockRecursionException_RecursiveWriteNotAllowed";

	internal const string LockRecursionException_RecursiveUpgradeNotAllowed = "LockRecursionException_RecursiveUpgradeNotAllowed";

	internal const string LockRecursionException_ReadAfterWriteNotAllowed = "LockRecursionException_ReadAfterWriteNotAllowed";

	internal const string LockRecursionException_WriteAfterReadNotAllowed = "LockRecursionException_WriteAfterReadNotAllowed";

	internal const string LockRecursionException_UpgradeAfterReadNotAllowed = "LockRecursionException_UpgradeAfterReadNotAllowed";

	internal const string LockRecursionException_UpgradeAfterWriteNotAllowed = "LockRecursionException_UpgradeAfterWriteNotAllowed";

	internal const string SynchronizationLockException_MisMatchedRead = "SynchronizationLockException_MisMatchedRead";

	internal const string SynchronizationLockException_MisMatchedWrite = "SynchronizationLockException_MisMatchedWrite";

	internal const string SynchronizationLockException_MisMatchedUpgrade = "SynchronizationLockException_MisMatchedUpgrade";

	internal const string SynchronizationLockException_IncorrectDispose = "SynchronizationLockException_IncorrectDispose";

	internal const string Arg_ArrayPlusOffTooSmall = "Arg_ArrayPlusOffTooSmall";

	internal const string NotSupported_KeyCollectionSet = "NotSupported_KeyCollectionSet";

	internal const string NotSupported_ValueCollectionSet = "NotSupported_ValueCollectionSet";

	internal const string NotSupported_ReadOnlyCollection = "NotSupported_ReadOnlyCollection";

	internal const string NotSupported_SortedListNestedWrite = "NotSupported_SortedListNestedWrite";

	internal const string CantModifyListSortDescriptionCollection = "CantModifyListSortDescriptionCollection";

	internal const string InvalidPrimitiveType = "InvalidPrimitiveType";

	internal const string CodeGenOutputWriter = "CodeGenOutputWriter";

	internal const string CodeGenReentrance = "CodeGenReentrance";

	internal const string InvalidLanguageIdentifier = "InvalidLanguageIdentifier";

	internal const string InvalidTypeName = "InvalidTypeName";

	internal const string Empty_attribute = "Empty_attribute";

	internal const string Invalid_nonnegative_integer_attribute = "Invalid_nonnegative_integer_attribute";

	internal const string CodeDomProvider_NotDefined = "CodeDomProvider_NotDefined";

	internal const string Language_Names_Cannot_Be_Empty = "Language_Names_Cannot_Be_Empty";

	internal const string Extension_Names_Cannot_Be_Empty_Or_Non_Period_Based = "Extension_Names_Cannot_Be_Empty_Or_Non_Period_Based";

	internal const string Unable_To_Locate_Type = "Unable_To_Locate_Type";

	internal const string NotSupported_CodeDomAPI = "NotSupported_CodeDomAPI";

	internal const string ArityDoesntMatch = "ArityDoesntMatch";

	internal const string PartialTrustErrorTextReplacement = "PartialTrustErrorTextReplacement";

	internal const string PartialTrustIllegalProvider = "PartialTrustIllegalProvider";

	internal const string IllegalAssemblyReference = "IllegalAssemblyReference";

	internal const string AutoGen_Comment_Line1 = "AutoGen_Comment_Line1";

	internal const string AutoGen_Comment_Line2 = "AutoGen_Comment_Line2";

	internal const string AutoGen_Comment_Line3 = "AutoGen_Comment_Line3";

	internal const string AutoGen_Comment_Line4 = "AutoGen_Comment_Line4";

	internal const string AutoGen_Comment_Line5 = "AutoGen_Comment_Line5";

	internal const string CantContainNullEntries = "CantContainNullEntries";

	internal const string InvalidPathCharsInChecksum = "InvalidPathCharsInChecksum";

	internal const string InvalidRegion = "InvalidRegion";

	internal const string MetaExtenderName = "MetaExtenderName";

	internal const string InvalidEnumArgument = "InvalidEnumArgument";

	internal const string InvalidArgument = "InvalidArgument";

	internal const string InvalidNullArgument = "InvalidNullArgument";

	internal const string InvalidNullEmptyArgument = "InvalidNullEmptyArgument";

	internal const string LicExceptionTypeOnly = "LicExceptionTypeOnly";

	internal const string LicExceptionTypeAndInstance = "LicExceptionTypeAndInstance";

	internal const string LicMgrContextCannotBeChanged = "LicMgrContextCannotBeChanged";

	internal const string LicMgrAlreadyLocked = "LicMgrAlreadyLocked";

	internal const string LicMgrDifferentUser = "LicMgrDifferentUser";

	internal const string InvalidElementType = "InvalidElementType";

	internal const string InvalidIdentifier = "InvalidIdentifier";

	internal const string ExecFailedToCreate = "ExecFailedToCreate";

	internal const string ExecTimeout = "ExecTimeout";

	internal const string ExecBadreturn = "ExecBadreturn";

	internal const string ExecCantGetRetCode = "ExecCantGetRetCode";

	internal const string ExecCantExec = "ExecCantExec";

	internal const string ExecCantRevert = "ExecCantRevert";

	internal const string CompilerNotFound = "CompilerNotFound";

	internal const string DuplicateFileName = "DuplicateFileName";

	internal const string CollectionReadOnly = "CollectionReadOnly";

	internal const string BitVectorFull = "BitVectorFull";

	internal const string ISupportInitializeDescr = "ISupportInitializeDescr";

	internal const string ArrayConverterText = "ArrayConverterText";

	internal const string CollectionConverterText = "CollectionConverterText";

	internal const string MultilineStringConverterText = "MultilineStringConverterText";

	internal const string CultureInfoConverterDefaultCultureString = "CultureInfoConverterDefaultCultureString";

	internal const string CultureInfoConverterInvalidCulture = "CultureInfoConverterInvalidCulture";

	internal const string InvalidPrimitive = "InvalidPrimitive";

	internal const string TimerInvalidInterval = "TimerInvalidInterval";

	internal const string TraceSwitchLevelTooHigh = "TraceSwitchLevelTooHigh";

	internal const string TraceSwitchLevelTooLow = "TraceSwitchLevelTooLow";

	internal const string TraceSwitchInvalidLevel = "TraceSwitchInvalidLevel";

	internal const string TraceListenerIndentSize = "TraceListenerIndentSize";

	internal const string TraceListenerFail = "TraceListenerFail";

	internal const string TraceAsTraceSource = "TraceAsTraceSource";

	internal const string InvalidLowBoundArgument = "InvalidLowBoundArgument";

	internal const string DuplicateComponentName = "DuplicateComponentName";

	internal const string NotImplemented = "NotImplemented";

	internal const string OutOfMemory = "OutOfMemory";

	internal const string EOF = "EOF";

	internal const string IOError = "IOError";

	internal const string BadChar = "BadChar";

	internal const string toStringNone = "toStringNone";

	internal const string toStringUnknown = "toStringUnknown";

	internal const string InvalidEnum = "InvalidEnum";

	internal const string IndexOutOfRange = "IndexOutOfRange";

	internal const string ErrorPropertyAccessorException = "ErrorPropertyAccessorException";

	internal const string InvalidOperation = "InvalidOperation";

	internal const string EmptyStack = "EmptyStack";

	internal const string PerformanceCounterDesc = "PerformanceCounterDesc";

	internal const string PCCategoryName = "PCCategoryName";

	internal const string PCCounterName = "PCCounterName";

	internal const string PCInstanceName = "PCInstanceName";

	internal const string PCMachineName = "PCMachineName";

	internal const string PCInstanceLifetime = "PCInstanceLifetime";

	internal const string PropertyCategoryAction = "PropertyCategoryAction";

	internal const string PropertyCategoryAppearance = "PropertyCategoryAppearance";

	internal const string PropertyCategoryAsynchronous = "PropertyCategoryAsynchronous";

	internal const string PropertyCategoryBehavior = "PropertyCategoryBehavior";

	internal const string PropertyCategoryData = "PropertyCategoryData";

	internal const string PropertyCategoryDDE = "PropertyCategoryDDE";

	internal const string PropertyCategoryDesign = "PropertyCategoryDesign";

	internal const string PropertyCategoryDragDrop = "PropertyCategoryDragDrop";

	internal const string PropertyCategoryFocus = "PropertyCategoryFocus";

	internal const string PropertyCategoryFont = "PropertyCategoryFont";

	internal const string PropertyCategoryFormat = "PropertyCategoryFormat";

	internal const string PropertyCategoryKey = "PropertyCategoryKey";

	internal const string PropertyCategoryList = "PropertyCategoryList";

	internal const string PropertyCategoryLayout = "PropertyCategoryLayout";

	internal const string PropertyCategoryDefault = "PropertyCategoryDefault";

	internal const string PropertyCategoryMouse = "PropertyCategoryMouse";

	internal const string PropertyCategoryPosition = "PropertyCategoryPosition";

	internal const string PropertyCategoryText = "PropertyCategoryText";

	internal const string PropertyCategoryScale = "PropertyCategoryScale";

	internal const string PropertyCategoryWindowStyle = "PropertyCategoryWindowStyle";

	internal const string PropertyCategoryConfig = "PropertyCategoryConfig";

	internal const string OnlyAllowedOnce = "OnlyAllowedOnce";

	internal const string BeginIndexNotNegative = "BeginIndexNotNegative";

	internal const string LengthNotNegative = "LengthNotNegative";

	internal const string UnimplementedState = "UnimplementedState";

	internal const string UnexpectedOpcode = "UnexpectedOpcode";

	internal const string NoResultOnFailed = "NoResultOnFailed";

	internal const string UnterminatedBracket = "UnterminatedBracket";

	internal const string TooManyParens = "TooManyParens";

	internal const string NestedQuantify = "NestedQuantify";

	internal const string QuantifyAfterNothing = "QuantifyAfterNothing";

	internal const string InternalError = "InternalError";

	internal const string IllegalRange = "IllegalRange";

	internal const string NotEnoughParens = "NotEnoughParens";

	internal const string BadClassInCharRange = "BadClassInCharRange";

	internal const string ReversedCharRange = "ReversedCharRange";

	internal const string UndefinedReference = "UndefinedReference";

	internal const string MalformedReference = "MalformedReference";

	internal const string UnrecognizedGrouping = "UnrecognizedGrouping";

	internal const string UnterminatedComment = "UnterminatedComment";

	internal const string IllegalEndEscape = "IllegalEndEscape";

	internal const string MalformedNameRef = "MalformedNameRef";

	internal const string UndefinedBackref = "UndefinedBackref";

	internal const string UndefinedNameRef = "UndefinedNameRef";

	internal const string TooFewHex = "TooFewHex";

	internal const string MissingControl = "MissingControl";

	internal const string UnrecognizedControl = "UnrecognizedControl";

	internal const string UnrecognizedEscape = "UnrecognizedEscape";

	internal const string IllegalCondition = "IllegalCondition";

	internal const string TooManyAlternates = "TooManyAlternates";

	internal const string MakeException = "MakeException";

	internal const string IncompleteSlashP = "IncompleteSlashP";

	internal const string MalformedSlashP = "MalformedSlashP";

	internal const string InvalidGroupName = "InvalidGroupName";

	internal const string CapnumNotZero = "CapnumNotZero";

	internal const string AlternationCantCapture = "AlternationCantCapture";

	internal const string AlternationCantHaveComment = "AlternationCantHaveComment";

	internal const string CaptureGroupOutOfRange = "CaptureGroupOutOfRange";

	internal const string SubtractionMustBeLast = "SubtractionMustBeLast";

	internal const string UnknownProperty = "UnknownProperty";

	internal const string ReplacementError = "ReplacementError";

	internal const string CountTooSmall = "CountTooSmall";

	internal const string EnumNotStarted = "EnumNotStarted";

	internal const string FileObject_AlreadyOpen = "FileObject_AlreadyOpen";

	internal const string FileObject_Closed = "FileObject_Closed";

	internal const string FileObject_NotWhileWriting = "FileObject_NotWhileWriting";

	internal const string FileObject_FileDoesNotExist = "FileObject_FileDoesNotExist";

	internal const string FileObject_MustBeClosed = "FileObject_MustBeClosed";

	internal const string FileObject_MustBeFileName = "FileObject_MustBeFileName";

	internal const string FileObject_InvalidInternalState = "FileObject_InvalidInternalState";

	internal const string FileObject_PathNotSet = "FileObject_PathNotSet";

	internal const string FileObject_Reading = "FileObject_Reading";

	internal const string FileObject_Writing = "FileObject_Writing";

	internal const string FileObject_InvalidEnumeration = "FileObject_InvalidEnumeration";

	internal const string FileObject_NoReset = "FileObject_NoReset";

	internal const string DirectoryObject_MustBeDirName = "DirectoryObject_MustBeDirName";

	internal const string DirectoryObjectPathDescr = "DirectoryObjectPathDescr";

	internal const string FileObjectDetectEncodingDescr = "FileObjectDetectEncodingDescr";

	internal const string FileObjectEncodingDescr = "FileObjectEncodingDescr";

	internal const string FileObjectPathDescr = "FileObjectPathDescr";

	internal const string Arg_RankMultiDimNotSupported = "Arg_RankMultiDimNotSupported";

	internal const string Arg_EnumIllegalVal = "Arg_EnumIllegalVal";

	internal const string Arg_OutOfRange_NeedNonNegNum = "Arg_OutOfRange_NeedNonNegNum";

	internal const string Argument_InvalidPermissionState = "Argument_InvalidPermissionState";

	internal const string Argument_InvalidOidValue = "Argument_InvalidOidValue";

	internal const string Argument_WrongType = "Argument_WrongType";

	internal const string Arg_EmptyOrNullString = "Arg_EmptyOrNullString";

	internal const string Arg_EmptyOrNullArray = "Arg_EmptyOrNullArray";

	internal const string Argument_InvalidClassAttribute = "Argument_InvalidClassAttribute";

	internal const string Argument_InvalidNameType = "Argument_InvalidNameType";

	internal const string InvalidOperation_EnumNotStarted = "InvalidOperation_EnumNotStarted";

	internal const string InvalidOperation_DuplicateItemNotAllowed = "InvalidOperation_DuplicateItemNotAllowed";

	internal const string Cryptography_ArgECDHKeySizeMismatch = "Cryptography_ArgECDHKeySizeMismatch";

	internal const string Cryptography_ArgECDHRequiresECDHKey = "Cryptography_ArgECDHRequiresECDHKey";

	internal const string Cryptography_ArgECDsaRequiresECDsaKey = "Cryptography_ArgECDsaRequiresECDsaKey";

	internal const string Cryptography_ArgExpectedECDiffieHellmanCngPublicKey = "Cryptography_ArgExpectedECDiffieHellmanCngPublicKey";

	internal const string Cryptography_ArgMustBeCngAlgorithm = "Cryptography_ArgMustBeCngAlgorithm";

	internal const string Cryptography_ArgMustBeCngAlgorithmGroup = "Cryptography_ArgMustBeCngAlgorithmGroup";

	internal const string Cryptography_ArgMustBeCngKeyBlobFormat = "Cryptography_ArgMustBeCngKeyBlobFormat";

	internal const string Cryptography_ArgMustBeCngProvider = "Cryptography_ArgMustBeCngProvider";

	internal const string Cryptography_DecryptWithNoKey = "Cryptography_DecryptWithNoKey";

	internal const string Cryptography_ECXmlSerializationFormatRequired = "Cryptography_ECXmlSerializationFormatRequired";

	internal const string Cryptography_InvalidAlgorithmGroup = "Cryptography_InvalidAlgorithmGroup";

	internal const string Cryptography_InvalidAlgorithmName = "Cryptography_InvalidAlgorithmName";

	internal const string Cryptography_InvalidCipherMode = "Cryptography_InvalidCipherMode";

	internal const string Cryptography_InvalidIVSize = "Cryptography_InvalidIVSize";

	internal const string Cryptography_InvalidKeyBlobFormat = "Cryptography_InvalidKeyBlobFormat";

	internal const string Cryptography_InvalidKeySize = "Cryptography_InvalidKeySize";

	internal const string Cryptography_InvalidPadding = "Cryptography_InvalidPadding";

	internal const string Cryptography_InvalidProviderName = "Cryptography_InvalidProviderName";

	internal const string Cryptography_MissingDomainParameters = "Cryptography_MissingDomainParameters";

	internal const string Cryptography_MissingPublicKey = "Cryptography_MissingPublicKey";

	internal const string Cryptography_MissingIV = "Cryptography_MissingIV";

	internal const string Cryptography_MustTransformWholeBlock = "Cryptography_MustTransformWholeBlock";

	internal const string Cryptography_NonCompliantFIPSAlgorithm = "Cryptography_NonCompliantFIPSAlgorithm";

	internal const string Cryptography_OpenInvalidHandle = "Cryptography_OpenInvalidHandle";

	internal const string Cryptography_OpenEphemeralKeyHandleWithoutEphemeralFlag = "Cryptography_OpenEphemeralKeyHandleWithoutEphemeralFlag";

	internal const string Cryptography_PartialBlock = "Cryptography_PartialBlock";

	internal const string Cryptography_PlatformNotSupported = "Cryptography_PlatformNotSupported";

	internal const string Cryptography_TlsRequiresLabelAndSeed = "Cryptography_TlsRequiresLabelAndSeed";

	internal const string Cryptography_TransformBeyondEndOfBuffer = "Cryptography_TransformBeyondEndOfBuffer";

	internal const string Cryptography_UnknownEllipticCurve = "Cryptography_UnknownEllipticCurve";

	internal const string Cryptography_UnknownEllipticCurveAlgorithm = "Cryptography_UnknownEllipticCurveAlgorithm";

	internal const string Cryptography_UnknownPaddingMode = "Cryptography_UnknownPaddingMode";

	internal const string Cryptography_UnexpectedXmlNamespace = "Cryptography_UnexpectedXmlNamespace";

	internal const string Cryptography_Asn_MismatchedOidInCollection = "Cryptography_Asn_MismatchedOidInCollection";

	internal const string Cryptography_Cms_Envelope_Empty_Content = "Cryptography_Cms_Envelope_Empty_Content";

	internal const string Cryptography_Cms_Invalid_Recipient_Info_Type = "Cryptography_Cms_Invalid_Recipient_Info_Type";

	internal const string Cryptography_Cms_Invalid_Subject_Identifier_Type = "Cryptography_Cms_Invalid_Subject_Identifier_Type";

	internal const string Cryptography_Cms_Invalid_Subject_Identifier_Type_Value_Mismatch = "Cryptography_Cms_Invalid_Subject_Identifier_Type_Value_Mismatch";

	internal const string Cryptography_Cms_Key_Agree_Date_Not_Available = "Cryptography_Cms_Key_Agree_Date_Not_Available";

	internal const string Cryptography_Cms_Key_Agree_Other_Key_Attribute_Not_Available = "Cryptography_Cms_Key_Agree_Other_Key_Attribute_Not_Available";

	internal const string Cryptography_Cms_MessageNotSigned = "Cryptography_Cms_MessageNotSigned";

	internal const string Cryptography_Cms_MessageNotSignedByNoSignature = "Cryptography_Cms_MessageNotSignedByNoSignature";

	internal const string Cryptography_Cms_MessageNotEncrypted = "Cryptography_Cms_MessageNotEncrypted";

	internal const string Cryptography_Cms_Not_Supported = "Cryptography_Cms_Not_Supported";

	internal const string Cryptography_Cms_RecipientCertificateNotFound = "Cryptography_Cms_RecipientCertificateNotFound";

	internal const string Cryptography_Cms_Sign_Empty_Content = "Cryptography_Cms_Sign_Empty_Content";

	internal const string Cryptography_Cms_Sign_No_Signature_First_Signer = "Cryptography_Cms_Sign_No_Signature_First_Signer";

	internal const string Cryptography_DpApi_InvalidMemoryLength = "Cryptography_DpApi_InvalidMemoryLength";

	internal const string Cryptography_InvalidHandle = "Cryptography_InvalidHandle";

	internal const string Cryptography_InvalidContextHandle = "Cryptography_InvalidContextHandle";

	internal const string Cryptography_InvalidStoreHandle = "Cryptography_InvalidStoreHandle";

	internal const string Cryptography_Oid_InvalidValue = "Cryptography_Oid_InvalidValue";

	internal const string Cryptography_Pkcs9_ExplicitAddNotAllowed = "Cryptography_Pkcs9_ExplicitAddNotAllowed";

	internal const string Cryptography_Pkcs9_InvalidOid = "Cryptography_Pkcs9_InvalidOid";

	internal const string Cryptography_Pkcs9_MultipleSigningTimeNotAllowed = "Cryptography_Pkcs9_MultipleSigningTimeNotAllowed";

	internal const string Cryptography_Pkcs9_AttributeMismatch = "Cryptography_Pkcs9_AttributeMismatch";

	internal const string Cryptography_X509_AddFailed = "Cryptography_X509_AddFailed";

	internal const string Cryptography_X509_BadEncoding = "Cryptography_X509_BadEncoding";

	internal const string Cryptography_X509_ExportFailed = "Cryptography_X509_ExportFailed";

	internal const string Cryptography_X509_ExtensionMismatch = "Cryptography_X509_ExtensionMismatch";

	internal const string Cryptography_X509_InvalidFindType = "Cryptography_X509_InvalidFindType";

	internal const string Cryptography_X509_InvalidFindValue = "Cryptography_X509_InvalidFindValue";

	internal const string Cryptography_X509_InvalidEncodingFormat = "Cryptography_X509_InvalidEncodingFormat";

	internal const string Cryptography_X509_InvalidContentType = "Cryptography_X509_InvalidContentType";

	internal const string Cryptography_X509_KeyMismatch = "Cryptography_X509_KeyMismatch";

	internal const string Cryptography_X509_RemoveFailed = "Cryptography_X509_RemoveFailed";

	internal const string Environment_NotInteractive = "Environment_NotInteractive";

	internal const string NotSupported_InvalidKeyImpl = "NotSupported_InvalidKeyImpl";

	internal const string NotSupported_KeyAlgorithm = "NotSupported_KeyAlgorithm";

	internal const string NotSupported_PlatformRequiresNT = "NotSupported_PlatformRequiresNT";

	internal const string NotSupported_UnreadableStream = "NotSupported_UnreadableStream";

	internal const string Security_InvalidValue = "Security_InvalidValue";

	internal const string Unknown_Error = "Unknown_Error";

	internal const string security_ServiceNameCollection_EmptyServiceName = "security_ServiceNameCollection_EmptyServiceName";

	internal const string security_ExtendedProtectionPolicy_UseDifferentConstructorForNever = "security_ExtendedProtectionPolicy_UseDifferentConstructorForNever";

	internal const string security_ExtendedProtectionPolicy_NoEmptyServiceNameCollection = "security_ExtendedProtectionPolicy_NoEmptyServiceNameCollection";

	internal const string security_ExtendedProtection_NoOSSupport = "security_ExtendedProtection_NoOSSupport";

	internal const string net_nonClsCompliantException = "net_nonClsCompliantException";

	internal const string net_illegalConfigWith = "net_illegalConfigWith";

	internal const string net_illegalConfigWithout = "net_illegalConfigWithout";

	internal const string net_baddate = "net_baddate";

	internal const string net_writestarted = "net_writestarted";

	internal const string net_clsmall = "net_clsmall";

	internal const string net_reqsubmitted = "net_reqsubmitted";

	internal const string net_rspsubmitted = "net_rspsubmitted";

	internal const string net_ftp_no_http_cmd = "net_ftp_no_http_cmd";

	internal const string net_ftp_invalid_method_name = "net_ftp_invalid_method_name";

	internal const string net_ftp_invalid_renameto = "net_ftp_invalid_renameto";

	internal const string net_ftp_no_defaultcreds = "net_ftp_no_defaultcreds";

	internal const string net_ftpnoresponse = "net_ftpnoresponse";

	internal const string net_ftp_response_invalid_format = "net_ftp_response_invalid_format";

	internal const string net_ftp_no_offsetforhttp = "net_ftp_no_offsetforhttp";

	internal const string net_ftp_invalid_uri = "net_ftp_invalid_uri";

	internal const string net_ftp_invalid_status_response = "net_ftp_invalid_status_response";

	internal const string net_ftp_server_failed_passive = "net_ftp_server_failed_passive";

	internal const string net_ftp_passive_address_different = "net_ftp_passive_address_different";

	internal const string net_ftp_active_address_different = "net_ftp_active_address_different";

	internal const string net_ftp_proxy_does_not_support_ssl = "net_ftp_proxy_does_not_support_ssl";

	internal const string net_ftp_invalid_response_filename = "net_ftp_invalid_response_filename";

	internal const string net_ftp_unsupported_method = "net_ftp_unsupported_method";

	internal const string net_resubmitcanceled = "net_resubmitcanceled";

	internal const string net_redirect_perm = "net_redirect_perm";

	internal const string net_resubmitprotofailed = "net_resubmitprotofailed";

	internal const string net_needchunked = "net_needchunked";

	internal const string net_nochunked = "net_nochunked";

	internal const string net_nochunkuploadonhttp10 = "net_nochunkuploadonhttp10";

	internal const string net_connarg = "net_connarg";

	internal const string net_no100 = "net_no100";

	internal const string net_fromto = "net_fromto";

	internal const string net_rangetoosmall = "net_rangetoosmall";

	internal const string net_entitytoobig = "net_entitytoobig";

	internal const string net_invalidversion = "net_invalidversion";

	internal const string net_invalidstatus = "net_invalidstatus";

	internal const string net_toosmall = "net_toosmall";

	internal const string net_toolong = "net_toolong";

	internal const string net_connclosed = "net_connclosed";

	internal const string net_headerrestrict = "net_headerrestrict";

	internal const string net_headerrestrict_resp = "net_headerrestrict_resp";

	internal const string net_noseek = "net_noseek";

	internal const string net_servererror = "net_servererror";

	internal const string net_nouploadonget = "net_nouploadonget";

	internal const string net_mutualauthfailed = "net_mutualauthfailed";

	internal const string net_invasync = "net_invasync";

	internal const string net_inasync = "net_inasync";

	internal const string net_mustbeuri = "net_mustbeuri";

	internal const string net_format_shexp = "net_format_shexp";

	internal const string net_cannot_load_proxy_helper = "net_cannot_load_proxy_helper";

	internal const string net_repcall = "net_repcall";

	internal const string net_wrongversion = "net_wrongversion";

	internal const string net_badmethod = "net_badmethod";

	internal const string net_io_notenoughbyteswritten = "net_io_notenoughbyteswritten";

	internal const string net_io_timeout_use_ge_zero = "net_io_timeout_use_ge_zero";

	internal const string net_io_timeout_use_gt_zero = "net_io_timeout_use_gt_zero";

	internal const string net_io_no_0timeouts = "net_io_no_0timeouts";

	internal const string net_requestaborted = "net_requestaborted";

	internal const string net_tooManyRedirections = "net_tooManyRedirections";

	internal const string net_authmodulenotregistered = "net_authmodulenotregistered";

	internal const string net_authschemenotregistered = "net_authschemenotregistered";

	internal const string net_proxyschemenotsupported = "net_proxyschemenotsupported";

	internal const string net_maxsrvpoints = "net_maxsrvpoints";

	internal const string net_maxbinddelegateretry = "net_maxbinddelegateretry";

	internal const string net_unknown_prefix = "net_unknown_prefix";

	internal const string net_notconnected = "net_notconnected";

	internal const string net_notstream = "net_notstream";

	internal const string net_timeout = "net_timeout";

	internal const string net_nocontentlengthonget = "net_nocontentlengthonget";

	internal const string net_contentlengthmissing = "net_contentlengthmissing";

	internal const string net_nonhttpproxynotallowed = "net_nonhttpproxynotallowed";

	internal const string net_nottoken = "net_nottoken";

	internal const string net_rangetype = "net_rangetype";

	internal const string net_need_writebuffering = "net_need_writebuffering";

	internal const string net_securitypackagesupport = "net_securitypackagesupport";

	internal const string net_securityprotocolnotsupported = "net_securityprotocolnotsupported";

	internal const string net_nodefaultcreds = "net_nodefaultcreds";

	internal const string net_stopped = "net_stopped";

	internal const string net_udpconnected = "net_udpconnected";

	internal const string net_readonlystream = "net_readonlystream";

	internal const string net_writeonlystream = "net_writeonlystream";

	internal const string net_no_concurrent_io_allowed = "net_no_concurrent_io_allowed";

	internal const string net_needmorethreads = "net_needmorethreads";

	internal const string net_MethodNotImplementedException = "net_MethodNotImplementedException";

	internal const string net_PropertyNotImplementedException = "net_PropertyNotImplementedException";

	internal const string net_MethodNotSupportedException = "net_MethodNotSupportedException";

	internal const string net_PropertyNotSupportedException = "net_PropertyNotSupportedException";

	internal const string net_ProtocolNotSupportedException = "net_ProtocolNotSupportedException";

	internal const string net_HashAlgorithmNotSupportedException = "net_HashAlgorithmNotSupportedException";

	internal const string net_QOPNotSupportedException = "net_QOPNotSupportedException";

	internal const string net_SelectModeNotSupportedException = "net_SelectModeNotSupportedException";

	internal const string net_InvalidSocketHandle = "net_InvalidSocketHandle";

	internal const string net_InvalidAddressFamily = "net_InvalidAddressFamily";

	internal const string net_InvalidSocketAddressSize = "net_InvalidSocketAddressSize";

	internal const string net_invalidAddressList = "net_invalidAddressList";

	internal const string net_invalidPingBufferSize = "net_invalidPingBufferSize";

	internal const string net_cant_perform_during_shutdown = "net_cant_perform_during_shutdown";

	internal const string net_cant_create_environment = "net_cant_create_environment";

	internal const string net_completed_result = "net_completed_result";

	internal const string net_protocol_invalid_family = "net_protocol_invalid_family";

	internal const string net_protocol_invalid_multicast_family = "net_protocol_invalid_multicast_family";

	internal const string net_ssp_dont_support_cbt = "net_ssp_dont_support_cbt";

	internal const string net_unknown_osinstalltype = "net_unknown_osinstalltype";

	internal const string net_sockets_zerolist = "net_sockets_zerolist";

	internal const string net_sockets_blocking = "net_sockets_blocking";

	internal const string net_sockets_useblocking = "net_sockets_useblocking";

	internal const string net_sockets_select = "net_sockets_select";

	internal const string net_sockets_toolarge_select = "net_sockets_toolarge_select";

	internal const string net_sockets_empty_select = "net_sockets_empty_select";

	internal const string net_sockets_mustbind = "net_sockets_mustbind";

	internal const string net_sockets_mustlisten = "net_sockets_mustlisten";

	internal const string net_sockets_mustnotlisten = "net_sockets_mustnotlisten";

	internal const string net_sockets_mustnotbebound = "net_sockets_mustnotbebound";

	internal const string net_sockets_namedmustnotbebound = "net_sockets_namedmustnotbebound";

	internal const string net_sockets_invalid_socketinformation = "net_sockets_invalid_socketinformation";

	internal const string net_sockets_invalid_ipaddress_length = "net_sockets_invalid_ipaddress_length";

	internal const string net_sockets_invalid_optionValue = "net_sockets_invalid_optionValue";

	internal const string net_sockets_invalid_optionValue_all = "net_sockets_invalid_optionValue_all";

	internal const string net_sockets_disconnectedConnect = "net_sockets_disconnectedConnect";

	internal const string net_sockets_disconnectedAccept = "net_sockets_disconnectedAccept";

	internal const string net_tcplistener_mustbestopped = "net_tcplistener_mustbestopped";

	internal const string net_sockets_no_duplicate_async = "net_sockets_no_duplicate_async";

	internal const string net_socketopinprogress = "net_socketopinprogress";

	internal const string net_buffercounttoosmall = "net_buffercounttoosmall";

	internal const string net_multibuffernotsupported = "net_multibuffernotsupported";

	internal const string net_ambiguousbuffers = "net_ambiguousbuffers";

	internal const string net_config_proxy = "net_config_proxy";

	internal const string net_config_proxy_module_not_public = "net_config_proxy_module_not_public";

	internal const string net_config_authenticationmodules = "net_config_authenticationmodules";

	internal const string net_config_webrequestmodules = "net_config_webrequestmodules";

	internal const string net_config_requestcaching = "net_config_requestcaching";

	internal const string net_config_section_permission = "net_config_section_permission";

	internal const string net_config_element_permission = "net_config_element_permission";

	internal const string net_config_property_permission = "net_config_property_permission";

	internal const string net_WebResponseParseError_InvalidHeaderName = "net_WebResponseParseError_InvalidHeaderName";

	internal const string net_WebResponseParseError_InvalidContentLength = "net_WebResponseParseError_InvalidContentLength";

	internal const string net_WebResponseParseError_IncompleteHeaderLine = "net_WebResponseParseError_IncompleteHeaderLine";

	internal const string net_WebResponseParseError_CrLfError = "net_WebResponseParseError_CrLfError";

	internal const string net_WebResponseParseError_InvalidChunkFormat = "net_WebResponseParseError_InvalidChunkFormat";

	internal const string net_WebResponseParseError_UnexpectedServerResponse = "net_WebResponseParseError_UnexpectedServerResponse";

	internal const string net_WebHeaderInvalidControlChars = "net_WebHeaderInvalidControlChars";

	internal const string net_WebHeaderInvalidCRLFChars = "net_WebHeaderInvalidCRLFChars";

	internal const string net_WebHeaderInvalidHeaderChars = "net_WebHeaderInvalidHeaderChars";

	internal const string net_WebHeaderInvalidNonAsciiChars = "net_WebHeaderInvalidNonAsciiChars";

	internal const string net_WebHeaderMissingColon = "net_WebHeaderMissingColon";

	internal const string net_webstatus_Success = "net_webstatus_Success";

	internal const string net_webstatus_NameResolutionFailure = "net_webstatus_NameResolutionFailure";

	internal const string net_webstatus_ConnectFailure = "net_webstatus_ConnectFailure";

	internal const string net_webstatus_ReceiveFailure = "net_webstatus_ReceiveFailure";

	internal const string net_webstatus_SendFailure = "net_webstatus_SendFailure";

	internal const string net_webstatus_PipelineFailure = "net_webstatus_PipelineFailure";

	internal const string net_webstatus_RequestCanceled = "net_webstatus_RequestCanceled";

	internal const string net_webstatus_ConnectionClosed = "net_webstatus_ConnectionClosed";

	internal const string net_webstatus_TrustFailure = "net_webstatus_TrustFailure";

	internal const string net_webstatus_SecureChannelFailure = "net_webstatus_SecureChannelFailure";

	internal const string net_webstatus_ServerProtocolViolation = "net_webstatus_ServerProtocolViolation";

	internal const string net_webstatus_KeepAliveFailure = "net_webstatus_KeepAliveFailure";

	internal const string net_webstatus_ProxyNameResolutionFailure = "net_webstatus_ProxyNameResolutionFailure";

	internal const string net_webstatus_MessageLengthLimitExceeded = "net_webstatus_MessageLengthLimitExceeded";

	internal const string net_webstatus_CacheEntryNotFound = "net_webstatus_CacheEntryNotFound";

	internal const string net_webstatus_RequestProhibitedByCachePolicy = "net_webstatus_RequestProhibitedByCachePolicy";

	internal const string net_webstatus_Timeout = "net_webstatus_Timeout";

	internal const string net_webstatus_RequestProhibitedByProxy = "net_webstatus_RequestProhibitedByProxy";

	internal const string net_InvalidStatusCode = "net_InvalidStatusCode";

	internal const string net_ftpstatuscode_ServiceNotAvailable = "net_ftpstatuscode_ServiceNotAvailable";

	internal const string net_ftpstatuscode_CantOpenData = "net_ftpstatuscode_CantOpenData";

	internal const string net_ftpstatuscode_ConnectionClosed = "net_ftpstatuscode_ConnectionClosed";

	internal const string net_ftpstatuscode_ActionNotTakenFileUnavailableOrBusy = "net_ftpstatuscode_ActionNotTakenFileUnavailableOrBusy";

	internal const string net_ftpstatuscode_ActionAbortedLocalProcessingError = "net_ftpstatuscode_ActionAbortedLocalProcessingError";

	internal const string net_ftpstatuscode_ActionNotTakenInsufficentSpace = "net_ftpstatuscode_ActionNotTakenInsufficentSpace";

	internal const string net_ftpstatuscode_CommandSyntaxError = "net_ftpstatuscode_CommandSyntaxError";

	internal const string net_ftpstatuscode_ArgumentSyntaxError = "net_ftpstatuscode_ArgumentSyntaxError";

	internal const string net_ftpstatuscode_CommandNotImplemented = "net_ftpstatuscode_CommandNotImplemented";

	internal const string net_ftpstatuscode_BadCommandSequence = "net_ftpstatuscode_BadCommandSequence";

	internal const string net_ftpstatuscode_NotLoggedIn = "net_ftpstatuscode_NotLoggedIn";

	internal const string net_ftpstatuscode_AccountNeeded = "net_ftpstatuscode_AccountNeeded";

	internal const string net_ftpstatuscode_ActionNotTakenFileUnavailable = "net_ftpstatuscode_ActionNotTakenFileUnavailable";

	internal const string net_ftpstatuscode_ActionAbortedUnknownPageType = "net_ftpstatuscode_ActionAbortedUnknownPageType";

	internal const string net_ftpstatuscode_FileActionAborted = "net_ftpstatuscode_FileActionAborted";

	internal const string net_ftpstatuscode_ActionNotTakenFilenameNotAllowed = "net_ftpstatuscode_ActionNotTakenFilenameNotAllowed";

	internal const string net_httpstatuscode_NoContent = "net_httpstatuscode_NoContent";

	internal const string net_httpstatuscode_NonAuthoritativeInformation = "net_httpstatuscode_NonAuthoritativeInformation";

	internal const string net_httpstatuscode_ResetContent = "net_httpstatuscode_ResetContent";

	internal const string net_httpstatuscode_PartialContent = "net_httpstatuscode_PartialContent";

	internal const string net_httpstatuscode_MultipleChoices = "net_httpstatuscode_MultipleChoices";

	internal const string net_httpstatuscode_Ambiguous = "net_httpstatuscode_Ambiguous";

	internal const string net_httpstatuscode_MovedPermanently = "net_httpstatuscode_MovedPermanently";

	internal const string net_httpstatuscode_Moved = "net_httpstatuscode_Moved";

	internal const string net_httpstatuscode_Found = "net_httpstatuscode_Found";

	internal const string net_httpstatuscode_Redirect = "net_httpstatuscode_Redirect";

	internal const string net_httpstatuscode_SeeOther = "net_httpstatuscode_SeeOther";

	internal const string net_httpstatuscode_RedirectMethod = "net_httpstatuscode_RedirectMethod";

	internal const string net_httpstatuscode_NotModified = "net_httpstatuscode_NotModified";

	internal const string net_httpstatuscode_UseProxy = "net_httpstatuscode_UseProxy";

	internal const string net_httpstatuscode_TemporaryRedirect = "net_httpstatuscode_TemporaryRedirect";

	internal const string net_httpstatuscode_RedirectKeepVerb = "net_httpstatuscode_RedirectKeepVerb";

	internal const string net_httpstatuscode_BadRequest = "net_httpstatuscode_BadRequest";

	internal const string net_httpstatuscode_Unauthorized = "net_httpstatuscode_Unauthorized";

	internal const string net_httpstatuscode_PaymentRequired = "net_httpstatuscode_PaymentRequired";

	internal const string net_httpstatuscode_Forbidden = "net_httpstatuscode_Forbidden";

	internal const string net_httpstatuscode_NotFound = "net_httpstatuscode_NotFound";

	internal const string net_httpstatuscode_MethodNotAllowed = "net_httpstatuscode_MethodNotAllowed";

	internal const string net_httpstatuscode_NotAcceptable = "net_httpstatuscode_NotAcceptable";

	internal const string net_httpstatuscode_ProxyAuthenticationRequired = "net_httpstatuscode_ProxyAuthenticationRequired";

	internal const string net_httpstatuscode_RequestTimeout = "net_httpstatuscode_RequestTimeout";

	internal const string net_httpstatuscode_Conflict = "net_httpstatuscode_Conflict";

	internal const string net_httpstatuscode_Gone = "net_httpstatuscode_Gone";

	internal const string net_httpstatuscode_LengthRequired = "net_httpstatuscode_LengthRequired";

	internal const string net_httpstatuscode_InternalServerError = "net_httpstatuscode_InternalServerError";

	internal const string net_httpstatuscode_NotImplemented = "net_httpstatuscode_NotImplemented";

	internal const string net_httpstatuscode_BadGateway = "net_httpstatuscode_BadGateway";

	internal const string net_httpstatuscode_ServiceUnavailable = "net_httpstatuscode_ServiceUnavailable";

	internal const string net_httpstatuscode_GatewayTimeout = "net_httpstatuscode_GatewayTimeout";

	internal const string net_httpstatuscode_HttpVersionNotSupported = "net_httpstatuscode_HttpVersionNotSupported";

	internal const string net_uri_BadScheme = "net_uri_BadScheme";

	internal const string net_uri_BadFormat = "net_uri_BadFormat";

	internal const string net_uri_BadUserPassword = "net_uri_BadUserPassword";

	internal const string net_uri_BadHostName = "net_uri_BadHostName";

	internal const string net_uri_BadAuthority = "net_uri_BadAuthority";

	internal const string net_uri_BadAuthorityTerminator = "net_uri_BadAuthorityTerminator";

	internal const string net_uri_BadFileName = "net_uri_BadFileName";

	internal const string net_uri_EmptyUri = "net_uri_EmptyUri";

	internal const string net_uri_BadString = "net_uri_BadString";

	internal const string net_uri_MustRootedPath = "net_uri_MustRootedPath";

	internal const string net_uri_BadPort = "net_uri_BadPort";

	internal const string net_uri_SizeLimit = "net_uri_SizeLimit";

	internal const string net_uri_SchemeLimit = "net_uri_SchemeLimit";

	internal const string net_uri_NotAbsolute = "net_uri_NotAbsolute";

	internal const string net_uri_SpecialUriComponent = "net_uri_SpecialUriComponent";

	internal const string net_uri_CustomValidationFailed = "net_uri_CustomValidationFailed";

	internal const string net_uri_PortOutOfRange = "net_uri_PortOutOfRange";

	internal const string net_uri_UserDrivenParsing = "net_uri_UserDrivenParsing";

	internal const string net_uri_AlreadyRegistered = "net_uri_AlreadyRegistered";

	internal const string net_uri_NeedFreshParser = "net_uri_NeedFreshParser";

	internal const string net_uri_CannotCreateRelative = "net_uri_CannotCreateRelative";

	internal const string net_uri_InvalidUriKind = "net_uri_InvalidUriKind";

	internal const string net_uri_BadUnicodeHostForIdn = "net_uri_BadUnicodeHostForIdn";

	internal const string net_io_completionportwasbound = "net_io_completionportwasbound";

	internal const string net_io_writefailure = "net_io_writefailure";

	internal const string net_io_readfailure = "net_io_readfailure";

	internal const string net_io_connectionclosed = "net_io_connectionclosed";

	internal const string net_io_transportfailure = "net_io_transportfailure";

	internal const string net_io_internal_bind = "net_io_internal_bind";

	internal const string net_io_invalidasyncresult = "net_io_invalidasyncresult";

	internal const string net_io_invalidnestedcall = "net_io_invalidnestedcall";

	internal const string net_io_invalidendcall = "net_io_invalidendcall";

	internal const string net_io_must_be_rw_stream = "net_io_must_be_rw_stream";

	internal const string net_io_header_id = "net_io_header_id";

	internal const string net_io_out_range = "net_io_out_range";

	internal const string net_io_encrypt = "net_io_encrypt";

	internal const string net_io_decrypt = "net_io_decrypt";

	internal const string net_io_read = "net_io_read";

	internal const string net_io_write = "net_io_write";

	internal const string net_io_eof = "net_io_eof";

	internal const string net_io_async_result = "net_io_async_result";

	internal const string net_headers_req = "net_headers_req";

	internal const string net_headers_rsp = "net_headers_rsp";

	internal const string net_headers_toolong = "net_headers_toolong";

	internal const string net_emptystringset = "net_emptystringset";

	internal const string net_emptystringcall = "net_emptystringcall";

	internal const string net_listener_mustcall = "net_listener_mustcall";

	internal const string net_listener_mustcompletecall = "net_listener_mustcompletecall";

	internal const string net_listener_callinprogress = "net_listener_callinprogress";

	internal const string net_listener_scheme = "net_listener_scheme";

	internal const string net_listener_host = "net_listener_host";

	internal const string net_listener_slash = "net_listener_slash";

	internal const string net_listener_repcall = "net_listener_repcall";

	internal const string net_listener_invalid_cbt_type = "net_listener_invalid_cbt_type";

	internal const string net_listener_no_spns = "net_listener_no_spns";

	internal const string net_listener_cannot_set_custom_cbt = "net_listener_cannot_set_custom_cbt";

	internal const string net_listener_cbt_not_supported = "net_listener_cbt_not_supported";

	internal const string net_tls_version = "net_tls_version";

	internal const string net_perm_target = "net_perm_target";

	internal const string net_perm_both_regex = "net_perm_both_regex";

	internal const string net_perm_none = "net_perm_none";

	internal const string net_perm_attrib_count = "net_perm_attrib_count";

	internal const string net_perm_invalid_val = "net_perm_invalid_val";

	internal const string net_perm_attrib_multi = "net_perm_attrib_multi";

	internal const string net_perm_epname = "net_perm_epname";

	internal const string net_perm_invalid_val_in_element = "net_perm_invalid_val_in_element";

	internal const string net_invalid_ip_addr = "net_invalid_ip_addr";

	internal const string dns_bad_ip_address = "dns_bad_ip_address";

	internal const string net_bad_mac_address = "net_bad_mac_address";

	internal const string net_ping = "net_ping";

	internal const string net_bad_ip_address_prefix = "net_bad_ip_address_prefix";

	internal const string net_max_ip_address_list_length_exceeded = "net_max_ip_address_list_length_exceeded";

	internal const string net_webclient = "net_webclient";

	internal const string net_webclient_ContentType = "net_webclient_ContentType";

	internal const string net_webclient_Multipart = "net_webclient_Multipart";

	internal const string net_webclient_no_concurrent_io_allowed = "net_webclient_no_concurrent_io_allowed";

	internal const string net_webclient_invalid_baseaddress = "net_webclient_invalid_baseaddress";

	internal const string net_container_add_cookie = "net_container_add_cookie";

	internal const string net_cookie_invalid = "net_cookie_invalid";

	internal const string net_cookie_size = "net_cookie_size";

	internal const string net_cookie_parse_header = "net_cookie_parse_header";

	internal const string net_cookie_attribute = "net_cookie_attribute";

	internal const string net_cookie_format = "net_cookie_format";

	internal const string net_cookie_exists = "net_cookie_exists";

	internal const string net_cookie_capacity_range = "net_cookie_capacity_range";

	internal const string net_set_token = "net_set_token";

	internal const string net_revert_token = "net_revert_token";

	internal const string net_ssl_io_async_context = "net_ssl_io_async_context";

	internal const string net_ssl_io_encrypt = "net_ssl_io_encrypt";

	internal const string net_ssl_io_decrypt = "net_ssl_io_decrypt";

	internal const string net_ssl_io_context_expired = "net_ssl_io_context_expired";

	internal const string net_ssl_io_handshake_start = "net_ssl_io_handshake_start";

	internal const string net_ssl_io_handshake = "net_ssl_io_handshake";

	internal const string net_ssl_io_frame = "net_ssl_io_frame";

	internal const string net_ssl_io_corrupted = "net_ssl_io_corrupted";

	internal const string net_ssl_io_cert_validation = "net_ssl_io_cert_validation";

	internal const string net_ssl_io_invalid_end_call = "net_ssl_io_invalid_end_call";

	internal const string net_ssl_io_invalid_begin_call = "net_ssl_io_invalid_begin_call";

	internal const string net_ssl_io_no_server_cert = "net_ssl_io_no_server_cert";

	internal const string net_auth_bad_client_creds = "net_auth_bad_client_creds";

	internal const string net_auth_bad_client_creds_or_target_mismatch = "net_auth_bad_client_creds_or_target_mismatch";

	internal const string net_auth_context_expectation = "net_auth_context_expectation";

	internal const string net_auth_context_expectation_remote = "net_auth_context_expectation_remote";

	internal const string net_auth_supported_impl_levels = "net_auth_supported_impl_levels";

	internal const string net_auth_no_protection_on_win9x = "net_auth_no_protection_on_win9x";

	internal const string net_auth_no_anonymous_support = "net_auth_no_anonymous_support";

	internal const string net_auth_reauth = "net_auth_reauth";

	internal const string net_auth_noauth = "net_auth_noauth";

	internal const string net_auth_client_server = "net_auth_client_server";

	internal const string net_auth_noencryption = "net_auth_noencryption";

	internal const string net_auth_SSPI = "net_auth_SSPI";

	internal const string net_auth_failure = "net_auth_failure";

	internal const string net_auth_eof = "net_auth_eof";

	internal const string net_auth_alert = "net_auth_alert";

	internal const string net_auth_ignored_reauth = "net_auth_ignored_reauth";

	internal const string net_auth_empty_read = "net_auth_empty_read";

	internal const string net_auth_message_not_encrypted = "net_auth_message_not_encrypted";

	internal const string net_auth_must_specify_extended_protection_scheme = "net_auth_must_specify_extended_protection_scheme";

	internal const string net_frame_size = "net_frame_size";

	internal const string net_frame_read_io = "net_frame_read_io";

	internal const string net_frame_read_size = "net_frame_read_size";

	internal const string net_frame_max_size = "net_frame_max_size";

	internal const string net_jscript_load = "net_jscript_load";

	internal const string net_proxy_not_gmt = "net_proxy_not_gmt";

	internal const string net_proxy_invalid_dayofweek = "net_proxy_invalid_dayofweek";

	internal const string net_param_not_string = "net_param_not_string";

	internal const string net_value_cannot_be_negative = "net_value_cannot_be_negative";

	internal const string net_invalid_offset = "net_invalid_offset";

	internal const string net_offset_plus_count = "net_offset_plus_count";

	internal const string net_cannot_be_false = "net_cannot_be_false";

	internal const string net_invalid_enum = "net_invalid_enum";

	internal const string net_listener_already = "net_listener_already";

	internal const string net_cache_shadowstream_not_writable = "net_cache_shadowstream_not_writable";

	internal const string net_cache_validator_fail = "net_cache_validator_fail";

	internal const string net_cache_access_denied = "net_cache_access_denied";

	internal const string net_cache_validator_result = "net_cache_validator_result";

	internal const string net_cache_retrieve_failure = "net_cache_retrieve_failure";

	internal const string net_cache_not_supported_body = "net_cache_not_supported_body";

	internal const string net_cache_not_supported_command = "net_cache_not_supported_command";

	internal const string net_cache_not_accept_response = "net_cache_not_accept_response";

	internal const string net_cache_method_failed = "net_cache_method_failed";

	internal const string net_cache_key_failed = "net_cache_key_failed";

	internal const string net_cache_no_stream = "net_cache_no_stream";

	internal const string net_cache_unsupported_partial_stream = "net_cache_unsupported_partial_stream";

	internal const string net_cache_not_configured = "net_cache_not_configured";

	internal const string net_cache_non_seekable_stream_not_supported = "net_cache_non_seekable_stream_not_supported";

	internal const string net_invalid_cast = "net_invalid_cast";

	internal const string net_collection_readonly = "net_collection_readonly";

	internal const string net_not_ipermission = "net_not_ipermission";

	internal const string net_no_classname = "net_no_classname";

	internal const string net_no_typename = "net_no_typename";

	internal const string net_array_too_small = "net_array_too_small";

	internal const string net_servicePointAddressNotSupportedInHostMode = "net_servicePointAddressNotSupportedInHostMode";

	internal const string net_log_listener_delegate_exception = "net_log_listener_delegate_exception";

	internal const string net_log_listener_unsupported_authentication_scheme = "net_log_listener_unsupported_authentication_scheme";

	internal const string net_log_listener_unmatched_authentication_scheme = "net_log_listener_unmatched_authentication_scheme";

	internal const string net_log_listener_create_valid_identity_failed = "net_log_listener_create_valid_identity_failed";

	internal const string net_log_listener_no_cbt_disabled = "net_log_listener_no_cbt_disabled";

	internal const string net_log_listener_no_cbt_http = "net_log_listener_no_cbt_http";

	internal const string net_log_listener_no_cbt_platform = "net_log_listener_no_cbt_platform";

	internal const string net_log_listener_no_cbt_trustedproxy = "net_log_listener_no_cbt_trustedproxy";

	internal const string net_log_listener_cbt = "net_log_listener_cbt";

	internal const string net_log_listener_no_spn_kerberos = "net_log_listener_no_spn_kerberos";

	internal const string net_log_listener_no_spn_disabled = "net_log_listener_no_spn_disabled";

	internal const string net_log_listener_no_spn_cbt = "net_log_listener_no_spn_cbt";

	internal const string net_log_listener_no_spn_platform = "net_log_listener_no_spn_platform";

	internal const string net_log_listener_no_spn_whensupported = "net_log_listener_no_spn_whensupported";

	internal const string net_log_listener_no_spn_loopback = "net_log_listener_no_spn_loopback";

	internal const string net_log_listener_spn = "net_log_listener_spn";

	internal const string net_log_listener_spn_passed = "net_log_listener_spn_passed";

	internal const string net_log_listener_spn_failed = "net_log_listener_spn_failed";

	internal const string net_log_listener_spn_failed_always = "net_log_listener_spn_failed_always";

	internal const string net_log_listener_spn_failed_empty = "net_log_listener_spn_failed_empty";

	internal const string net_log_listener_spn_failed_dump = "net_log_listener_spn_failed_dump";

	internal const string net_log_sspi_enumerating_security_packages = "net_log_sspi_enumerating_security_packages";

	internal const string net_log_sspi_security_package_not_found = "net_log_sspi_security_package_not_found";

	internal const string net_log_sspi_security_context_input_buffer = "net_log_sspi_security_context_input_buffer";

	internal const string net_log_sspi_security_context_input_buffers = "net_log_sspi_security_context_input_buffers";

	internal const string net_log_remote_certificate = "net_log_remote_certificate";

	internal const string net_log_locating_private_key_for_certificate = "net_log_locating_private_key_for_certificate";

	internal const string net_log_cert_is_of_type_2 = "net_log_cert_is_of_type_2";

	internal const string net_log_found_cert_in_store = "net_log_found_cert_in_store";

	internal const string net_log_did_not_find_cert_in_store = "net_log_did_not_find_cert_in_store";

	internal const string net_log_open_store_failed = "net_log_open_store_failed";

	internal const string net_log_got_certificate_from_delegate = "net_log_got_certificate_from_delegate";

	internal const string net_log_no_delegate_and_have_no_client_cert = "net_log_no_delegate_and_have_no_client_cert";

	internal const string net_log_no_delegate_but_have_client_cert = "net_log_no_delegate_but_have_client_cert";

	internal const string net_log_attempting_restart_using_cert = "net_log_attempting_restart_using_cert";

	internal const string net_log_no_issuers_try_all_certs = "net_log_no_issuers_try_all_certs";

	internal const string net_log_server_issuers_look_for_matching_certs = "net_log_server_issuers_look_for_matching_certs";

	internal const string net_log_selected_cert = "net_log_selected_cert";

	internal const string net_log_n_certs_after_filtering = "net_log_n_certs_after_filtering";

	internal const string net_log_finding_matching_certs = "net_log_finding_matching_certs";

	internal const string net_log_using_cached_credential = "net_log_using_cached_credential";

	internal const string net_log_remote_cert_user_declared_valid = "net_log_remote_cert_user_declared_valid";

	internal const string net_log_remote_cert_user_declared_invalid = "net_log_remote_cert_user_declared_invalid";

	internal const string net_log_remote_cert_has_no_errors = "net_log_remote_cert_has_no_errors";

	internal const string net_log_remote_cert_has_errors = "net_log_remote_cert_has_errors";

	internal const string net_log_remote_cert_not_available = "net_log_remote_cert_not_available";

	internal const string net_log_remote_cert_name_mismatch = "net_log_remote_cert_name_mismatch";

	internal const string net_log_proxy_autodetect_script_location_parse_error = "net_log_proxy_autodetect_script_location_parse_error";

	internal const string net_log_proxy_autodetect_failed = "net_log_proxy_autodetect_failed";

	internal const string net_log_proxy_script_execution_error = "net_log_proxy_script_execution_error";

	internal const string net_log_proxy_script_download_compile_error = "net_log_proxy_script_download_compile_error";

	internal const string net_log_proxy_system_setting_update = "net_log_proxy_system_setting_update";

	internal const string net_log_proxy_update_due_to_ip_config_change = "net_log_proxy_update_due_to_ip_config_change";

	internal const string net_log_proxy_called_with_null_parameter = "net_log_proxy_called_with_null_parameter";

	internal const string net_log_proxy_called_with_invalid_parameter = "net_log_proxy_called_with_invalid_parameter";

	internal const string net_log_proxy_ras_notsupported_exception = "net_log_proxy_ras_notsupported_exception";

	internal const string net_log_cache_validation_failed_resubmit = "net_log_cache_validation_failed_resubmit";

	internal const string net_log_cache_refused_server_response = "net_log_cache_refused_server_response";

	internal const string net_log_cache_ftp_proxy_doesnt_support_partial = "net_log_cache_ftp_proxy_doesnt_support_partial";

	internal const string net_log_cache_ftp_method = "net_log_cache_ftp_method";

	internal const string net_log_cache_ftp_supports_bin_only = "net_log_cache_ftp_supports_bin_only";

	internal const string net_log_cache_replacing_entry_with_HTTP_200 = "net_log_cache_replacing_entry_with_HTTP_200";

	internal const string net_log_cache_now_time = "net_log_cache_now_time";

	internal const string net_log_cache_max_age_absolute = "net_log_cache_max_age_absolute";

	internal const string net_log_cache_age1 = "net_log_cache_age1";

	internal const string net_log_cache_age1_date_header = "net_log_cache_age1_date_header";

	internal const string net_log_cache_age1_last_synchronized = "net_log_cache_age1_last_synchronized";

	internal const string net_log_cache_age1_last_synchronized_age_header = "net_log_cache_age1_last_synchronized_age_header";

	internal const string net_log_cache_age2 = "net_log_cache_age2";

	internal const string net_log_cache_max_age_cache_s_max_age = "net_log_cache_max_age_cache_s_max_age";

	internal const string net_log_cache_max_age_expires_date = "net_log_cache_max_age_expires_date";

	internal const string net_log_cache_max_age_cache_max_age = "net_log_cache_max_age_cache_max_age";

	internal const string net_log_cache_no_max_age_use_10_percent = "net_log_cache_no_max_age_use_10_percent";

	internal const string net_log_cache_no_max_age_use_default = "net_log_cache_no_max_age_use_default";

	internal const string net_log_cache_validator_invalid_for_policy = "net_log_cache_validator_invalid_for_policy";

	internal const string net_log_cache_response_last_modified = "net_log_cache_response_last_modified";

	internal const string net_log_cache_cache_last_modified = "net_log_cache_cache_last_modified";

	internal const string net_log_cache_partial_and_non_zero_content_offset = "net_log_cache_partial_and_non_zero_content_offset";

	internal const string net_log_cache_response_valid_based_on_policy = "net_log_cache_response_valid_based_on_policy";

	internal const string net_log_cache_null_response_failure = "net_log_cache_null_response_failure";

	internal const string net_log_cache_ftp_response_status = "net_log_cache_ftp_response_status";

	internal const string net_log_cache_resp_valid_based_on_retry = "net_log_cache_resp_valid_based_on_retry";

	internal const string net_log_cache_no_update_based_on_method = "net_log_cache_no_update_based_on_method";

	internal const string net_log_cache_removed_existing_invalid_entry = "net_log_cache_removed_existing_invalid_entry";

	internal const string net_log_cache_not_updated_based_on_policy = "net_log_cache_not_updated_based_on_policy";

	internal const string net_log_cache_not_updated_because_no_response = "net_log_cache_not_updated_because_no_response";

	internal const string net_log_cache_removed_existing_based_on_method = "net_log_cache_removed_existing_based_on_method";

	internal const string net_log_cache_existing_not_removed_because_unexpected_response_status = "net_log_cache_existing_not_removed_because_unexpected_response_status";

	internal const string net_log_cache_removed_existing_based_on_policy = "net_log_cache_removed_existing_based_on_policy";

	internal const string net_log_cache_not_updated_based_on_ftp_response_status = "net_log_cache_not_updated_based_on_ftp_response_status";

	internal const string net_log_cache_update_not_supported_for_ftp_restart = "net_log_cache_update_not_supported_for_ftp_restart";

	internal const string net_log_cache_removed_entry_because_ftp_restart_response_changed = "net_log_cache_removed_entry_because_ftp_restart_response_changed";

	internal const string net_log_cache_last_synchronized = "net_log_cache_last_synchronized";

	internal const string net_log_cache_suppress_update_because_synched_last_minute = "net_log_cache_suppress_update_because_synched_last_minute";

	internal const string net_log_cache_updating_last_synchronized = "net_log_cache_updating_last_synchronized";

	internal const string net_log_cache_cannot_remove = "net_log_cache_cannot_remove";

	internal const string net_log_cache_key_status = "net_log_cache_key_status";

	internal const string net_log_cache_key_remove_failed_status = "net_log_cache_key_remove_failed_status";

	internal const string net_log_cache_usecount_file = "net_log_cache_usecount_file";

	internal const string net_log_cache_stream = "net_log_cache_stream";

	internal const string net_log_cache_filename = "net_log_cache_filename";

	internal const string net_log_cache_lookup_failed = "net_log_cache_lookup_failed";

	internal const string net_log_cache_exception = "net_log_cache_exception";

	internal const string net_log_cache_expected_length = "net_log_cache_expected_length";

	internal const string net_log_cache_last_modified = "net_log_cache_last_modified";

	internal const string net_log_cache_expires = "net_log_cache_expires";

	internal const string net_log_cache_max_stale = "net_log_cache_max_stale";

	internal const string net_log_cache_dumping_metadata = "net_log_cache_dumping_metadata";

	internal const string net_log_cache_create_failed = "net_log_cache_create_failed";

	internal const string net_log_cache_set_expires = "net_log_cache_set_expires";

	internal const string net_log_cache_set_last_modified = "net_log_cache_set_last_modified";

	internal const string net_log_cache_set_last_synchronized = "net_log_cache_set_last_synchronized";

	internal const string net_log_cache_enable_max_stale = "net_log_cache_enable_max_stale";

	internal const string net_log_cache_disable_max_stale = "net_log_cache_disable_max_stale";

	internal const string net_log_cache_set_new_metadata = "net_log_cache_set_new_metadata";

	internal const string net_log_cache_dumping = "net_log_cache_dumping";

	internal const string net_log_cache_key = "net_log_cache_key";

	internal const string net_log_cache_no_commit = "net_log_cache_no_commit";

	internal const string net_log_cache_error_deleting_filename = "net_log_cache_error_deleting_filename";

	internal const string net_log_cache_update_failed = "net_log_cache_update_failed";

	internal const string net_log_cache_delete_failed = "net_log_cache_delete_failed";

	internal const string net_log_cache_commit_failed = "net_log_cache_commit_failed";

	internal const string net_log_cache_committed_as_partial = "net_log_cache_committed_as_partial";

	internal const string net_log_cache_max_stale_and_update_status = "net_log_cache_max_stale_and_update_status";

	internal const string net_log_cache_failing_request_with_exception = "net_log_cache_failing_request_with_exception";

	internal const string net_log_cache_request_method = "net_log_cache_request_method";

	internal const string net_log_cache_http_status_parse_failure = "net_log_cache_http_status_parse_failure";

	internal const string net_log_cache_http_status_line = "net_log_cache_http_status_line";

	internal const string net_log_cache_cache_control = "net_log_cache_cache_control";

	internal const string net_log_cache_invalid_http_version = "net_log_cache_invalid_http_version";

	internal const string net_log_cache_no_http_response_header = "net_log_cache_no_http_response_header";

	internal const string net_log_cache_http_header_parse_error = "net_log_cache_http_header_parse_error";

	internal const string net_log_cache_metadata_name_value_parse_error = "net_log_cache_metadata_name_value_parse_error";

	internal const string net_log_cache_content_range_error = "net_log_cache_content_range_error";

	internal const string net_log_cache_cache_control_error = "net_log_cache_cache_control_error";

	internal const string net_log_cache_unexpected_status = "net_log_cache_unexpected_status";

	internal const string net_log_cache_object_and_exception = "net_log_cache_object_and_exception";

	internal const string net_log_cache_revalidation_not_needed = "net_log_cache_revalidation_not_needed";

	internal const string net_log_cache_not_updated_based_on_cache_protocol_status = "net_log_cache_not_updated_based_on_cache_protocol_status";

	internal const string net_log_cache_closing_cache_stream = "net_log_cache_closing_cache_stream";

	internal const string net_log_cache_exception_ignored = "net_log_cache_exception_ignored";

	internal const string net_log_cache_no_cache_entry = "net_log_cache_no_cache_entry";

	internal const string net_log_cache_null_cached_stream = "net_log_cache_null_cached_stream";

	internal const string net_log_cache_requested_combined_but_null_cached_stream = "net_log_cache_requested_combined_but_null_cached_stream";

	internal const string net_log_cache_returned_range_cache = "net_log_cache_returned_range_cache";

	internal const string net_log_cache_entry_not_found_freshness_undefined = "net_log_cache_entry_not_found_freshness_undefined";

	internal const string net_log_cache_dumping_cache_context = "net_log_cache_dumping_cache_context";

	internal const string net_log_cache_result = "net_log_cache_result";

	internal const string net_log_cache_uri_with_query_has_no_expiration = "net_log_cache_uri_with_query_has_no_expiration";

	internal const string net_log_cache_uri_with_query_and_cached_resp_from_http_10 = "net_log_cache_uri_with_query_and_cached_resp_from_http_10";

	internal const string net_log_cache_valid_as_fresh_or_because_policy = "net_log_cache_valid_as_fresh_or_because_policy";

	internal const string net_log_cache_accept_based_on_retry_count = "net_log_cache_accept_based_on_retry_count";

	internal const string net_log_cache_date_header_older_than_cache_entry = "net_log_cache_date_header_older_than_cache_entry";

	internal const string net_log_cache_server_didnt_satisfy_range = "net_log_cache_server_didnt_satisfy_range";

	internal const string net_log_cache_304_received_on_unconditional_request = "net_log_cache_304_received_on_unconditional_request";

	internal const string net_log_cache_304_received_on_unconditional_request_expected_200_206 = "net_log_cache_304_received_on_unconditional_request_expected_200_206";

	internal const string net_log_cache_last_modified_header_older_than_cache_entry = "net_log_cache_last_modified_header_older_than_cache_entry";

	internal const string net_log_cache_freshness_outside_policy_limits = "net_log_cache_freshness_outside_policy_limits";

	internal const string net_log_cache_need_to_remove_invalid_cache_entry_304 = "net_log_cache_need_to_remove_invalid_cache_entry_304";

	internal const string net_log_cache_resp_status = "net_log_cache_resp_status";

	internal const string net_log_cache_resp_304_or_request_head = "net_log_cache_resp_304_or_request_head";

	internal const string net_log_cache_dont_update_cached_headers = "net_log_cache_dont_update_cached_headers";

	internal const string net_log_cache_update_cached_headers = "net_log_cache_update_cached_headers";

	internal const string net_log_cache_partial_resp_not_combined_with_existing_entry = "net_log_cache_partial_resp_not_combined_with_existing_entry";

	internal const string net_log_cache_request_contains_conditional_header = "net_log_cache_request_contains_conditional_header";

	internal const string net_log_cache_not_a_get_head_post = "net_log_cache_not_a_get_head_post";

	internal const string net_log_cache_cannot_update_cache_if_304 = "net_log_cache_cannot_update_cache_if_304";

	internal const string net_log_cache_cannot_update_cache_with_head_resp = "net_log_cache_cannot_update_cache_with_head_resp";

	internal const string net_log_cache_http_resp_is_null = "net_log_cache_http_resp_is_null";

	internal const string net_log_cache_resp_cache_control_is_no_store = "net_log_cache_resp_cache_control_is_no_store";

	internal const string net_log_cache_resp_cache_control_is_public = "net_log_cache_resp_cache_control_is_public";

	internal const string net_log_cache_resp_cache_control_is_private = "net_log_cache_resp_cache_control_is_private";

	internal const string net_log_cache_resp_cache_control_is_private_plus_headers = "net_log_cache_resp_cache_control_is_private_plus_headers";

	internal const string net_log_cache_resp_older_than_cache = "net_log_cache_resp_older_than_cache";

	internal const string net_log_cache_revalidation_required = "net_log_cache_revalidation_required";

	internal const string net_log_cache_needs_revalidation = "net_log_cache_needs_revalidation";

	internal const string net_log_cache_resp_allows_caching = "net_log_cache_resp_allows_caching";

	internal const string net_log_cache_auth_header_and_no_s_max_age = "net_log_cache_auth_header_and_no_s_max_age";

	internal const string net_log_cache_post_resp_without_cache_control_or_expires = "net_log_cache_post_resp_without_cache_control_or_expires";

	internal const string net_log_cache_valid_based_on_status_code = "net_log_cache_valid_based_on_status_code";

	internal const string net_log_cache_resp_no_cache_control = "net_log_cache_resp_no_cache_control";

	internal const string net_log_cache_age = "net_log_cache_age";

	internal const string net_log_cache_policy_min_fresh = "net_log_cache_policy_min_fresh";

	internal const string net_log_cache_policy_max_age = "net_log_cache_policy_max_age";

	internal const string net_log_cache_policy_cache_sync_date = "net_log_cache_policy_cache_sync_date";

	internal const string net_log_cache_policy_max_stale = "net_log_cache_policy_max_stale";

	internal const string net_log_cache_control_no_cache = "net_log_cache_control_no_cache";

	internal const string net_log_cache_control_no_cache_removing_some_headers = "net_log_cache_control_no_cache_removing_some_headers";

	internal const string net_log_cache_control_must_revalidate = "net_log_cache_control_must_revalidate";

	internal const string net_log_cache_cached_auth_header = "net_log_cache_cached_auth_header";

	internal const string net_log_cache_cached_auth_header_no_control_directive = "net_log_cache_cached_auth_header_no_control_directive";

	internal const string net_log_cache_after_validation = "net_log_cache_after_validation";

	internal const string net_log_cache_resp_status_304 = "net_log_cache_resp_status_304";

	internal const string net_log_cache_head_resp_has_different_content_length = "net_log_cache_head_resp_has_different_content_length";

	internal const string net_log_cache_head_resp_has_different_content_md5 = "net_log_cache_head_resp_has_different_content_md5";

	internal const string net_log_cache_head_resp_has_different_etag = "net_log_cache_head_resp_has_different_etag";

	internal const string net_log_cache_304_head_resp_has_different_last_modified = "net_log_cache_304_head_resp_has_different_last_modified";

	internal const string net_log_cache_existing_entry_has_to_be_discarded = "net_log_cache_existing_entry_has_to_be_discarded";

	internal const string net_log_cache_existing_entry_should_be_discarded = "net_log_cache_existing_entry_should_be_discarded";

	internal const string net_log_cache_206_resp_non_matching_entry = "net_log_cache_206_resp_non_matching_entry";

	internal const string net_log_cache_206_resp_starting_position_not_adjusted = "net_log_cache_206_resp_starting_position_not_adjusted";

	internal const string net_log_cache_combined_resp_requested = "net_log_cache_combined_resp_requested";

	internal const string net_log_cache_updating_headers_on_304 = "net_log_cache_updating_headers_on_304";

	internal const string net_log_cache_suppressing_headers_update_on_304 = "net_log_cache_suppressing_headers_update_on_304";

	internal const string net_log_cache_status_code_not_304_206 = "net_log_cache_status_code_not_304_206";

	internal const string net_log_cache_sxx_resp_cache_only = "net_log_cache_sxx_resp_cache_only";

	internal const string net_log_cache_sxx_resp_can_be_replaced = "net_log_cache_sxx_resp_can_be_replaced";

	internal const string net_log_cache_vary_header_empty = "net_log_cache_vary_header_empty";

	internal const string net_log_cache_vary_header_contains_asterisks = "net_log_cache_vary_header_contains_asterisks";

	internal const string net_log_cache_no_headers_in_metadata = "net_log_cache_no_headers_in_metadata";

	internal const string net_log_cache_vary_header_mismatched_count = "net_log_cache_vary_header_mismatched_count";

	internal const string net_log_cache_vary_header_mismatched_field = "net_log_cache_vary_header_mismatched_field";

	internal const string net_log_cache_vary_header_match = "net_log_cache_vary_header_match";

	internal const string net_log_cache_range = "net_log_cache_range";

	internal const string net_log_cache_range_invalid_format = "net_log_cache_range_invalid_format";

	internal const string net_log_cache_range_not_in_cache = "net_log_cache_range_not_in_cache";

	internal const string net_log_cache_range_in_cache = "net_log_cache_range_in_cache";

	internal const string net_log_cache_partial_resp = "net_log_cache_partial_resp";

	internal const string net_log_cache_range_request_range = "net_log_cache_range_request_range";

	internal const string net_log_cache_could_be_partial = "net_log_cache_could_be_partial";

	internal const string net_log_cache_condition_if_none_match = "net_log_cache_condition_if_none_match";

	internal const string net_log_cache_condition_if_modified_since = "net_log_cache_condition_if_modified_since";

	internal const string net_log_cache_cannot_construct_conditional_request = "net_log_cache_cannot_construct_conditional_request";

	internal const string net_log_cache_cannot_construct_conditional_range_request = "net_log_cache_cannot_construct_conditional_range_request";

	internal const string net_log_cache_entry_size_too_big = "net_log_cache_entry_size_too_big";

	internal const string net_log_cache_condition_if_range = "net_log_cache_condition_if_range";

	internal const string net_log_cache_conditional_range_not_implemented_on_http_10 = "net_log_cache_conditional_range_not_implemented_on_http_10";

	internal const string net_log_cache_saving_request_headers = "net_log_cache_saving_request_headers";

	internal const string net_log_cache_only_byte_range_implemented = "net_log_cache_only_byte_range_implemented";

	internal const string net_log_cache_multiple_complex_range_not_implemented = "net_log_cache_multiple_complex_range_not_implemented";

	internal const string net_log_unknown = "net_log_unknown";

	internal const string net_log_operation_returned_something = "net_log_operation_returned_something";

	internal const string net_log_operation_failed_with_error = "net_log_operation_failed_with_error";

	internal const string net_log_buffered_n_bytes = "net_log_buffered_n_bytes";

	internal const string net_log_method_equal = "net_log_method_equal";

	internal const string net_log_releasing_connection = "net_log_releasing_connection";

	internal const string net_log_unexpected_exception = "net_log_unexpected_exception";

	internal const string net_log_server_response_error_code = "net_log_server_response_error_code";

	internal const string net_log_resubmitting_request = "net_log_resubmitting_request";

	internal const string net_log_retrieving_localhost_exception = "net_log_retrieving_localhost_exception";

	internal const string net_log_resolved_servicepoint_may_not_be_remote_server = "net_log_resolved_servicepoint_may_not_be_remote_server";

	internal const string net_log_received_status_line = "net_log_received_status_line";

	internal const string net_log_sending_headers = "net_log_sending_headers";

	internal const string net_log_received_headers = "net_log_received_headers";

	internal const string net_log_shell_expression_pattern_format_warning = "net_log_shell_expression_pattern_format_warning";

	internal const string net_log_exception_in_callback = "net_log_exception_in_callback";

	internal const string net_log_sending_command = "net_log_sending_command";

	internal const string net_log_received_response = "net_log_received_response";

	internal const string Mail7BitStreamInvalidCharacter = "Mail7BitStreamInvalidCharacter";

	internal const string MailAddressInvalidFormat = "MailAddressInvalidFormat";

	internal const string MailAddressUnsupportedFormat = "MailAddressUnsupportedFormat";

	internal const string MailSubjectInvalidFormat = "MailSubjectInvalidFormat";

	internal const string MailBase64InvalidCharacter = "MailBase64InvalidCharacter";

	internal const string MailCollectionIsReadOnly = "MailCollectionIsReadOnly";

	internal const string MailDateInvalidFormat = "MailDateInvalidFormat";

	internal const string MailHeaderFieldAlreadyExists = "MailHeaderFieldAlreadyExists";

	internal const string MailHeaderFieldInvalidCharacter = "MailHeaderFieldInvalidCharacter";

	internal const string MailHeaderFieldMalformedHeader = "MailHeaderFieldMalformedHeader";

	internal const string MailHeaderFieldMismatchedName = "MailHeaderFieldMismatchedName";

	internal const string MailHeaderIndexOutOfBounds = "MailHeaderIndexOutOfBounds";

	internal const string MailHeaderItemAccessorOnlySingleton = "MailHeaderItemAccessorOnlySingleton";

	internal const string MailHeaderListHasChanged = "MailHeaderListHasChanged";

	internal const string MailHeaderResetCalledBeforeEOF = "MailHeaderResetCalledBeforeEOF";

	internal const string MailHeaderTargetArrayTooSmall = "MailHeaderTargetArrayTooSmall";

	internal const string MailHeaderInvalidCID = "MailHeaderInvalidCID";

	internal const string MailHostNotFound = "MailHostNotFound";

	internal const string MailReaderGetContentStreamAlreadyCalled = "MailReaderGetContentStreamAlreadyCalled";

	internal const string MailReaderTruncated = "MailReaderTruncated";

	internal const string MailWriterIsInContent = "MailWriterIsInContent";

	internal const string MailWriterLineLengthTooSmall = "MailWriterLineLengthTooSmall";

	internal const string MailServerDoesNotSupportStartTls = "MailServerDoesNotSupportStartTls";

	internal const string MailServerResponse = "MailServerResponse";

	internal const string SSPIAuthenticationOrSPNNull = "SSPIAuthenticationOrSPNNull";

	internal const string SSPIPInvokeError = "SSPIPInvokeError";

	internal const string SSPIInvalidHandleType = "SSPIInvalidHandleType";

	internal const string SmtpAlreadyConnected = "SmtpAlreadyConnected";

	internal const string SmtpAuthenticationFailed = "SmtpAuthenticationFailed";

	internal const string SmtpAuthenticationFailedNoCreds = "SmtpAuthenticationFailedNoCreds";

	internal const string SmtpDataStreamOpen = "SmtpDataStreamOpen";

	internal const string SmtpDefaultMimePreamble = "SmtpDefaultMimePreamble";

	internal const string SmtpDefaultSubject = "SmtpDefaultSubject";

	internal const string SmtpInvalidResponse = "SmtpInvalidResponse";

	internal const string SmtpNotConnected = "SmtpNotConnected";

	internal const string SmtpSystemStatus = "SmtpSystemStatus";

	internal const string SmtpHelpMessage = "SmtpHelpMessage";

	internal const string SmtpServiceReady = "SmtpServiceReady";

	internal const string SmtpServiceClosingTransmissionChannel = "SmtpServiceClosingTransmissionChannel";

	internal const string SmtpOK = "SmtpOK";

	internal const string SmtpUserNotLocalWillForward = "SmtpUserNotLocalWillForward";

	internal const string SmtpStartMailInput = "SmtpStartMailInput";

	internal const string SmtpServiceNotAvailable = "SmtpServiceNotAvailable";

	internal const string SmtpMailboxBusy = "SmtpMailboxBusy";

	internal const string SmtpLocalErrorInProcessing = "SmtpLocalErrorInProcessing";

	internal const string SmtpInsufficientStorage = "SmtpInsufficientStorage";

	internal const string SmtpPermissionDenied = "SmtpPermissionDenied";

	internal const string SmtpCommandUnrecognized = "SmtpCommandUnrecognized";

	internal const string SmtpSyntaxError = "SmtpSyntaxError";

	internal const string SmtpCommandNotImplemented = "SmtpCommandNotImplemented";

	internal const string SmtpBadCommandSequence = "SmtpBadCommandSequence";

	internal const string SmtpCommandParameterNotImplemented = "SmtpCommandParameterNotImplemented";

	internal const string SmtpMailboxUnavailable = "SmtpMailboxUnavailable";

	internal const string SmtpUserNotLocalTryAlternatePath = "SmtpUserNotLocalTryAlternatePath";

	internal const string SmtpExceededStorageAllocation = "SmtpExceededStorageAllocation";

	internal const string SmtpMailboxNameNotAllowed = "SmtpMailboxNameNotAllowed";

	internal const string SmtpTransactionFailed = "SmtpTransactionFailed";

	internal const string SmtpSendMailFailure = "SmtpSendMailFailure";

	internal const string SmtpRecipientFailed = "SmtpRecipientFailed";

	internal const string SmtpRecipientRequired = "SmtpRecipientRequired";

	internal const string SmtpFromRequired = "SmtpFromRequired";

	internal const string SmtpAllRecipientsFailed = "SmtpAllRecipientsFailed";

	internal const string SmtpClientNotPermitted = "SmtpClientNotPermitted";

	internal const string SmtpMustIssueStartTlsFirst = "SmtpMustIssueStartTlsFirst";

	internal const string SmtpNeedAbsolutePickupDirectory = "SmtpNeedAbsolutePickupDirectory";

	internal const string SmtpGetIisPickupDirectoryFailed = "SmtpGetIisPickupDirectoryFailed";

	internal const string SmtpPickupDirectoryDoesnotSupportSsl = "SmtpPickupDirectoryDoesnotSupportSsl";

	internal const string SmtpOperationInProgress = "SmtpOperationInProgress";

	internal const string SmtpAuthResponseInvalid = "SmtpAuthResponseInvalid";

	internal const string SmtpEhloResponseInvalid = "SmtpEhloResponseInvalid";

	internal const string MimeTransferEncodingNotSupported = "MimeTransferEncodingNotSupported";

	internal const string SeekNotSupported = "SeekNotSupported";

	internal const string WriteNotSupported = "WriteNotSupported";

	internal const string InvalidHexDigit = "InvalidHexDigit";

	internal const string InvalidSSPIContext = "InvalidSSPIContext";

	internal const string InvalidSSPIContextKey = "InvalidSSPIContextKey";

	internal const string InvalidSSPINegotiationElement = "InvalidSSPINegotiationElement";

	internal const string InvalidHeaderName = "InvalidHeaderName";

	internal const string InvalidHeaderValue = "InvalidHeaderValue";

	internal const string CannotGetEffectiveTimeOfSSPIContext = "CannotGetEffectiveTimeOfSSPIContext";

	internal const string CannotGetExpiryTimeOfSSPIContext = "CannotGetExpiryTimeOfSSPIContext";

	internal const string ReadNotSupported = "ReadNotSupported";

	internal const string InvalidAsyncResult = "InvalidAsyncResult";

	internal const string UnspecifiedHost = "UnspecifiedHost";

	internal const string InvalidPort = "InvalidPort";

	internal const string SmtpInvalidOperationDuringSend = "SmtpInvalidOperationDuringSend";

	internal const string MimePartCantResetStream = "MimePartCantResetStream";

	internal const string MediaTypeInvalid = "MediaTypeInvalid";

	internal const string ContentTypeInvalid = "ContentTypeInvalid";

	internal const string ContentDispositionInvalid = "ContentDispositionInvalid";

	internal const string AttributeNotSupported = "AttributeNotSupported";

	internal const string Cannot_remove_with_null = "Cannot_remove_with_null";

	internal const string Config_base_elements_only = "Config_base_elements_only";

	internal const string Config_base_no_child_nodes = "Config_base_no_child_nodes";

	internal const string Config_base_required_attribute_empty = "Config_base_required_attribute_empty";

	internal const string Config_base_required_attribute_missing = "Config_base_required_attribute_missing";

	internal const string Config_base_time_overflow = "Config_base_time_overflow";

	internal const string Config_base_type_must_be_configurationvalidation = "Config_base_type_must_be_configurationvalidation";

	internal const string Config_base_type_must_be_typeconverter = "Config_base_type_must_be_typeconverter";

	internal const string Config_base_unknown_format = "Config_base_unknown_format";

	internal const string Config_base_unrecognized_attribute = "Config_base_unrecognized_attribute";

	internal const string Config_base_unrecognized_element = "Config_base_unrecognized_element";

	internal const string Config_invalid_boolean_attribute = "Config_invalid_boolean_attribute";

	internal const string Config_invalid_integer_attribute = "Config_invalid_integer_attribute";

	internal const string Config_invalid_positive_integer_attribute = "Config_invalid_positive_integer_attribute";

	internal const string Config_invalid_type_attribute = "Config_invalid_type_attribute";

	internal const string Config_missing_required_attribute = "Config_missing_required_attribute";

	internal const string Config_name_value_file_section_file_invalid_root = "Config_name_value_file_section_file_invalid_root";

	internal const string Config_provider_must_implement_type = "Config_provider_must_implement_type";

	internal const string Config_provider_name_null_or_empty = "Config_provider_name_null_or_empty";

	internal const string Config_provider_not_found = "Config_provider_not_found";

	internal const string Config_property_name_cannot_be_empty = "Config_property_name_cannot_be_empty";

	internal const string Config_section_cannot_clear_locked_section = "Config_section_cannot_clear_locked_section";

	internal const string Config_section_record_not_found = "Config_section_record_not_found";

	internal const string Config_source_cannot_contain_file = "Config_source_cannot_contain_file";

	internal const string Config_system_already_set = "Config_system_already_set";

	internal const string Config_unable_to_read_security_policy = "Config_unable_to_read_security_policy";

	internal const string Config_write_xml_returned_null = "Config_write_xml_returned_null";

	internal const string Cannot_clear_sections_within_group = "Cannot_clear_sections_within_group";

	internal const string Cannot_exit_up_top_directory = "Cannot_exit_up_top_directory";

	internal const string Could_not_create_listener = "Could_not_create_listener";

	internal const string TextWriterTL_DefaultConstructor_NotSupported = "TextWriterTL_DefaultConstructor_NotSupported";

	internal const string Could_not_create_type_instance = "Could_not_create_type_instance";

	internal const string Could_not_find_type = "Could_not_find_type";

	internal const string Could_not_get_constructor = "Could_not_get_constructor";

	internal const string EmptyTypeName_NotAllowed = "EmptyTypeName_NotAllowed";

	internal const string Incorrect_base_type = "Incorrect_base_type";

	internal const string Only_specify_one = "Only_specify_one";

	internal const string Provider_Already_Initialized = "Provider_Already_Initialized";

	internal const string Reference_listener_cant_have_properties = "Reference_listener_cant_have_properties";

	internal const string Reference_to_nonexistent_listener = "Reference_to_nonexistent_listener";

	internal const string SettingsPropertyNotFound = "SettingsPropertyNotFound";

	internal const string SettingsPropertyReadOnly = "SettingsPropertyReadOnly";

	internal const string SettingsPropertyWrongType = "SettingsPropertyWrongType";

	internal const string Type_isnt_tracelistener = "Type_isnt_tracelistener";

	internal const string Unable_to_convert_type_from_string = "Unable_to_convert_type_from_string";

	internal const string Unable_to_convert_type_to_string = "Unable_to_convert_type_to_string";

	internal const string Value_must_be_numeric = "Value_must_be_numeric";

	internal const string Could_not_create_from_default_value = "Could_not_create_from_default_value";

	internal const string Could_not_create_from_default_value_2 = "Could_not_create_from_default_value_2";

	internal const string InvalidDirName = "InvalidDirName";

	internal const string FSW_IOError = "FSW_IOError";

	internal const string PatternInvalidChar = "PatternInvalidChar";

	internal const string BufferSizeTooLarge = "BufferSizeTooLarge";

	internal const string FSW_ChangedFilter = "FSW_ChangedFilter";

	internal const string FSW_Enabled = "FSW_Enabled";

	internal const string FSW_Filter = "FSW_Filter";

	internal const string FSW_IncludeSubdirectories = "FSW_IncludeSubdirectories";

	internal const string FSW_Path = "FSW_Path";

	internal const string FSW_SynchronizingObject = "FSW_SynchronizingObject";

	internal const string FSW_Changed = "FSW_Changed";

	internal const string FSW_Created = "FSW_Created";

	internal const string FSW_Deleted = "FSW_Deleted";

	internal const string FSW_Renamed = "FSW_Renamed";

	internal const string FSW_BufferOverflow = "FSW_BufferOverflow";

	internal const string FileSystemWatcherDesc = "FileSystemWatcherDesc";

	internal const string NotSet = "NotSet";

	internal const string TimerAutoReset = "TimerAutoReset";

	internal const string TimerEnabled = "TimerEnabled";

	internal const string TimerInterval = "TimerInterval";

	internal const string TimerIntervalElapsed = "TimerIntervalElapsed";

	internal const string TimerSynchronizingObject = "TimerSynchronizingObject";

	internal const string MismatchedCounterTypes = "MismatchedCounterTypes";

	internal const string NoPropertyForAttribute = "NoPropertyForAttribute";

	internal const string InvalidAttributeType = "InvalidAttributeType";

	internal const string Generic_ArgCantBeEmptyString = "Generic_ArgCantBeEmptyString";

	internal const string BadLogName = "BadLogName";

	internal const string InvalidProperty = "InvalidProperty";

	internal const string NotifyCreateFailed = "NotifyCreateFailed";

	internal const string CantMonitorEventLog = "CantMonitorEventLog";

	internal const string InitTwice = "InitTwice";

	internal const string InvalidParameter = "InvalidParameter";

	internal const string MissingParameter = "MissingParameter";

	internal const string ParameterTooLong = "ParameterTooLong";

	internal const string LocalSourceAlreadyExists = "LocalSourceAlreadyExists";

	internal const string SourceAlreadyExists = "SourceAlreadyExists";

	internal const string LocalLogAlreadyExistsAsSource = "LocalLogAlreadyExistsAsSource";

	internal const string LogAlreadyExistsAsSource = "LogAlreadyExistsAsSource";

	internal const string DuplicateLogName = "DuplicateLogName";

	internal const string RegKeyMissing = "RegKeyMissing";

	internal const string LocalRegKeyMissing = "LocalRegKeyMissing";

	internal const string RegKeyMissingShort = "RegKeyMissingShort";

	internal const string InvalidParameterFormat = "InvalidParameterFormat";

	internal const string NoLogName = "NoLogName";

	internal const string RegKeyNoAccess = "RegKeyNoAccess";

	internal const string MissingLog = "MissingLog";

	internal const string SourceNotRegistered = "SourceNotRegistered";

	internal const string LocalSourceNotRegistered = "LocalSourceNotRegistered";

	internal const string CantRetrieveEntries = "CantRetrieveEntries";

	internal const string IndexOutOfBounds = "IndexOutOfBounds";

	internal const string CantReadLogEntryAt = "CantReadLogEntryAt";

	internal const string MissingLogProperty = "MissingLogProperty";

	internal const string CantOpenLog = "CantOpenLog";

	internal const string NeedSourceToOpen = "NeedSourceToOpen";

	internal const string NeedSourceToWrite = "NeedSourceToWrite";

	internal const string CantOpenLogAccess = "CantOpenLogAccess";

	internal const string LogEntryTooLong = "LogEntryTooLong";

	internal const string TooManyReplacementStrings = "TooManyReplacementStrings";

	internal const string LogSourceMismatch = "LogSourceMismatch";

	internal const string NoAccountInfo = "NoAccountInfo";

	internal const string NoCurrentEntry = "NoCurrentEntry";

	internal const string MessageNotFormatted = "MessageNotFormatted";

	internal const string EventID = "EventID";

	internal const string LogDoesNotExists = "LogDoesNotExists";

	internal const string InvalidCustomerLogName = "InvalidCustomerLogName";

	internal const string CannotDeleteEqualSource = "CannotDeleteEqualSource";

	internal const string RentionDaysOutOfRange = "RentionDaysOutOfRange";

	internal const string MaximumKilobytesOutOfRange = "MaximumKilobytesOutOfRange";

	internal const string SomeLogsInaccessible = "SomeLogsInaccessible";

	internal const string BadConfigSwitchValue = "BadConfigSwitchValue";

	internal const string ConfigSectionsUnique = "ConfigSectionsUnique";

	internal const string ConfigSectionsUniquePerSection = "ConfigSectionsUniquePerSection";

	internal const string SourceListenerDoesntExist = "SourceListenerDoesntExist";

	internal const string SourceSwitchDoesntExist = "SourceSwitchDoesntExist";

	internal const string ReadOnlyCounter = "ReadOnlyCounter";

	internal const string ReadOnlyRemoveInstance = "ReadOnlyRemoveInstance";

	internal const string NotCustomCounter = "NotCustomCounter";

	internal const string CategoryNameMissing = "CategoryNameMissing";

	internal const string CounterNameMissing = "CounterNameMissing";

	internal const string InstanceNameProhibited = "InstanceNameProhibited";

	internal const string InstanceNameRequired = "InstanceNameRequired";

	internal const string MissingInstance = "MissingInstance";

	internal const string PerformanceCategoryExists = "PerformanceCategoryExists";

	internal const string InvalidCounterName = "InvalidCounterName";

	internal const string DuplicateCounterName = "DuplicateCounterName";

	internal const string CantDeleteCategory = "CantDeleteCategory";

	internal const string MissingCategory = "MissingCategory";

	internal const string MissingCategoryDetail = "MissingCategoryDetail";

	internal const string CantReadCategory = "CantReadCategory";

	internal const string MissingCounter = "MissingCounter";

	internal const string CategoryNameNotSet = "CategoryNameNotSet";

	internal const string CounterExists = "CounterExists";

	internal const string CantReadCategoryIndex = "CantReadCategoryIndex";

	internal const string CantReadCounter = "CantReadCounter";

	internal const string CantReadInstance = "CantReadInstance";

	internal const string RemoteWriting = "RemoteWriting";

	internal const string CounterLayout = "CounterLayout";

	internal const string PossibleDeadlock = "PossibleDeadlock";

	internal const string SharedMemoryGhosted = "SharedMemoryGhosted";

	internal const string HelpNotAvailable = "HelpNotAvailable";

	internal const string PerfInvalidHelp = "PerfInvalidHelp";

	internal const string PerfInvalidCounterName = "PerfInvalidCounterName";

	internal const string PerfInvalidCategoryName = "PerfInvalidCategoryName";

	internal const string MustAddCounterCreationData = "MustAddCounterCreationData";

	internal const string RemoteCounterAdmin = "RemoteCounterAdmin";

	internal const string NoInstanceInformation = "NoInstanceInformation";

	internal const string PerfCounterPdhError = "PerfCounterPdhError";

	internal const string MultiInstanceOnly = "MultiInstanceOnly";

	internal const string SingleInstanceOnly = "SingleInstanceOnly";

	internal const string InstanceNameTooLong = "InstanceNameTooLong";

	internal const string CategoryNameTooLong = "CategoryNameTooLong";

	internal const string InstanceLifetimeProcessonReadOnly = "InstanceLifetimeProcessonReadOnly";

	internal const string InstanceLifetimeProcessforSingleInstance = "InstanceLifetimeProcessforSingleInstance";

	internal const string InstanceAlreadyExists = "InstanceAlreadyExists";

	internal const string CantSetLifetimeAfterInitialized = "CantSetLifetimeAfterInitialized";

	internal const string ProcessLifetimeNotValidInGlobal = "ProcessLifetimeNotValidInGlobal";

	internal const string CantConvertProcessToGlobal = "CantConvertProcessToGlobal";

	internal const string CantConvertGlobalToProcess = "CantConvertGlobalToProcess";

	internal const string PriorityClassNotSupported = "PriorityClassNotSupported";

	internal const string WinNTRequired = "WinNTRequired";

	internal const string Win2kRequired = "Win2kRequired";

	internal const string NoAssociatedProcess = "NoAssociatedProcess";

	internal const string ProcessIdRequired = "ProcessIdRequired";

	internal const string NotSupportedRemote = "NotSupportedRemote";

	internal const string NoProcessInfo = "NoProcessInfo";

	internal const string WaitTillExit = "WaitTillExit";

	internal const string NoProcessHandle = "NoProcessHandle";

	internal const string MissingProccess = "MissingProccess";

	internal const string BadMinWorkset = "BadMinWorkset";

	internal const string BadMaxWorkset = "BadMaxWorkset";

	internal const string WinNTRequiredForRemote = "WinNTRequiredForRemote";

	internal const string ProcessHasExited = "ProcessHasExited";

	internal const string ProcessHasExitedNoId = "ProcessHasExitedNoId";

	internal const string ThreadExited = "ThreadExited";

	internal const string Win2000Required = "Win2000Required";

	internal const string WinXPRequired = "WinXPRequired";

	internal const string Win2k3Required = "Win2k3Required";

	internal const string ProcessNotFound = "ProcessNotFound";

	internal const string CantGetProcessId = "CantGetProcessId";

	internal const string ProcessDisabled = "ProcessDisabled";

	internal const string WaitReasonUnavailable = "WaitReasonUnavailable";

	internal const string NotSupportedRemoteThread = "NotSupportedRemoteThread";

	internal const string UseShellExecuteRequiresSTA = "UseShellExecuteRequiresSTA";

	internal const string CantRedirectStreams = "CantRedirectStreams";

	internal const string CantUseEnvVars = "CantUseEnvVars";

	internal const string CantStartAsUser = "CantStartAsUser";

	internal const string CouldntConnectToRemoteMachine = "CouldntConnectToRemoteMachine";

	internal const string CouldntGetProcessInfos = "CouldntGetProcessInfos";

	internal const string InputIdleUnkownError = "InputIdleUnkownError";

	internal const string FileNameMissing = "FileNameMissing";

	internal const string EnvironmentBlock = "EnvironmentBlock";

	internal const string EnumProcessModuleFailed = "EnumProcessModuleFailed";

	internal const string PendingAsyncOperation = "PendingAsyncOperation";

	internal const string NoAsyncOperation = "NoAsyncOperation";

	internal const string InvalidApplication = "InvalidApplication";

	internal const string StandardOutputEncodingNotAllowed = "StandardOutputEncodingNotAllowed";

	internal const string StandardErrorEncodingNotAllowed = "StandardErrorEncodingNotAllowed";

	internal const string CountersOOM = "CountersOOM";

	internal const string MappingCorrupted = "MappingCorrupted";

	internal const string SetSecurityDescriptorFailed = "SetSecurityDescriptorFailed";

	internal const string CantCreateFileMapping = "CantCreateFileMapping";

	internal const string CantMapFileView = "CantMapFileView";

	internal const string CantGetMappingSize = "CantGetMappingSize";

	internal const string CantGetStandardOut = "CantGetStandardOut";

	internal const string CantGetStandardIn = "CantGetStandardIn";

	internal const string CantGetStandardError = "CantGetStandardError";

	internal const string CantMixSyncAsyncOperation = "CantMixSyncAsyncOperation";

	internal const string NoFileMappingSize = "NoFileMappingSize";

	internal const string EnvironmentBlockTooLong = "EnvironmentBlockTooLong";

	internal const string Arg_InvalidSerialPort = "Arg_InvalidSerialPort";

	internal const string Arg_InvalidSerialPortExtended = "Arg_InvalidSerialPortExtended";

	internal const string Arg_SecurityException = "Arg_SecurityException";

	internal const string Argument_InvalidOffLen = "Argument_InvalidOffLen";

	internal const string ArgumentNull_Array = "ArgumentNull_Array";

	internal const string ArgumentNull_Buffer = "ArgumentNull_Buffer";

	internal const string ArgumentOutOfRange_Bounds_Lower_Upper = "ArgumentOutOfRange_Bounds_Lower_Upper";

	internal const string ArgumentOutOfRange_Enum = "ArgumentOutOfRange_Enum";

	internal const string ArgumentOutOfRange_NeedNonNegNumRequired = "ArgumentOutOfRange_NeedNonNegNumRequired";

	internal const string ArgumentOutOfRange_Timeout = "ArgumentOutOfRange_Timeout";

	internal const string ArgumentOutOfRange_WriteTimeout = "ArgumentOutOfRange_WriteTimeout";

	internal const string ArgumentOutOfRange_NeedPosNum = "ArgumentOutOfRange_NeedPosNum";

	internal const string ArgumentOutOfRange_OffsetOut = "ArgumentOutOfRange_OffsetOut";

	internal const string IndexOutOfRange_IORaceCondition = "IndexOutOfRange_IORaceCondition";

	internal const string IO_BindHandleFailed = "IO_BindHandleFailed";

	internal const string IO_OperationAborted = "IO_OperationAborted";

	internal const string NotSupported_UnseekableStream = "NotSupported_UnseekableStream";

	internal const string UnauthorizedAccess_IODenied_Path = "UnauthorizedAccess_IODenied_Path";

	internal const string IO_EOF_ReadBeyondEOF = "IO_EOF_ReadBeyondEOF";

	internal const string IO_UnknownError = "IO_UnknownError";

	internal const string ObjectDisposed_StreamClosed = "ObjectDisposed_StreamClosed";

	internal const string Arg_WrongAsyncResult = "Arg_WrongAsyncResult";

	internal const string InvalidOperation_EndReadCalledMultiple = "InvalidOperation_EndReadCalledMultiple";

	internal const string InvalidOperation_EndWriteCalledMultiple = "InvalidOperation_EndWriteCalledMultiple";

	internal const string IO_PortNotFound = "IO_PortNotFound";

	internal const string IO_PortNotFoundFileName = "IO_PortNotFoundFileName";

	internal const string UnauthorizedAccess_IODenied_NoPathName = "UnauthorizedAccess_IODenied_NoPathName";

	internal const string IO_PathTooLong = "IO_PathTooLong";

	internal const string IO_SharingViolation_NoFileName = "IO_SharingViolation_NoFileName";

	internal const string IO_SharingViolation_File = "IO_SharingViolation_File";

	internal const string NotSupported_UnwritableStream = "NotSupported_UnwritableStream";

	internal const string ObjectDisposed_WriterClosed = "ObjectDisposed_WriterClosed";

	internal const string BaseStream_Invalid_Not_Open = "BaseStream_Invalid_Not_Open";

	internal const string PortNameEmpty_String = "PortNameEmpty_String";

	internal const string Port_not_open = "Port_not_open";

	internal const string Port_already_open = "Port_already_open";

	internal const string Cant_be_set_when_open = "Cant_be_set_when_open";

	internal const string Max_Baud = "Max_Baud";

	internal const string In_Break_State = "In_Break_State";

	internal const string Write_timed_out = "Write_timed_out";

	internal const string CantSetRtsWithHandshaking = "CantSetRtsWithHandshaking";

	internal const string NotSupportedOS = "NotSupportedOS";

	internal const string NotSupportedEncoding = "NotSupportedEncoding";

	internal const string BaudRate = "BaudRate";

	internal const string DataBits = "DataBits";

	internal const string DiscardNull = "DiscardNull";

	internal const string DtrEnable = "DtrEnable";

	internal const string Encoding = "Encoding";

	internal const string Handshake = "Handshake";

	internal const string NewLine = "NewLine";

	internal const string Parity = "Parity";

	internal const string ParityReplace = "ParityReplace";

	internal const string PortName = "PortName";

	internal const string ReadBufferSize = "ReadBufferSize";

	internal const string ReadTimeout = "ReadTimeout";

	internal const string ReceivedBytesThreshold = "ReceivedBytesThreshold";

	internal const string RtsEnable = "RtsEnable";

	internal const string SerialPortDesc = "SerialPortDesc";

	internal const string StopBits = "StopBits";

	internal const string WriteBufferSize = "WriteBufferSize";

	internal const string WriteTimeout = "WriteTimeout";

	internal const string SerialErrorReceived = "SerialErrorReceived";

	internal const string SerialPinChanged = "SerialPinChanged";

	internal const string SerialDataReceived = "SerialDataReceived";

	internal const string CounterType = "CounterType";

	internal const string CounterName = "CounterName";

	internal const string CounterHelp = "CounterHelp";

	internal const string EventLogDesc = "EventLogDesc";

	internal const string ErrorDataReceived = "ErrorDataReceived";

	internal const string LogEntries = "LogEntries";

	internal const string LogLog = "LogLog";

	internal const string LogMachineName = "LogMachineName";

	internal const string LogMonitoring = "LogMonitoring";

	internal const string LogSynchronizingObject = "LogSynchronizingObject";

	internal const string LogSource = "LogSource";

	internal const string LogEntryWritten = "LogEntryWritten";

	internal const string LogEntryMachineName = "LogEntryMachineName";

	internal const string LogEntryData = "LogEntryData";

	internal const string LogEntryIndex = "LogEntryIndex";

	internal const string LogEntryCategory = "LogEntryCategory";

	internal const string LogEntryCategoryNumber = "LogEntryCategoryNumber";

	internal const string LogEntryEventID = "LogEntryEventID";

	internal const string LogEntryEntryType = "LogEntryEntryType";

	internal const string LogEntryMessage = "LogEntryMessage";

	internal const string LogEntrySource = "LogEntrySource";

	internal const string LogEntryReplacementStrings = "LogEntryReplacementStrings";

	internal const string LogEntryResourceId = "LogEntryResourceId";

	internal const string LogEntryTimeGenerated = "LogEntryTimeGenerated";

	internal const string LogEntryTimeWritten = "LogEntryTimeWritten";

	internal const string LogEntryUserName = "LogEntryUserName";

	internal const string OutputDataReceived = "OutputDataReceived";

	internal const string PC_CounterHelp = "PC_CounterHelp";

	internal const string PC_CounterType = "PC_CounterType";

	internal const string PC_ReadOnly = "PC_ReadOnly";

	internal const string PC_RawValue = "PC_RawValue";

	internal const string ProcessAssociated = "ProcessAssociated";

	internal const string ProcessDesc = "ProcessDesc";

	internal const string ProcessExitCode = "ProcessExitCode";

	internal const string ProcessTerminated = "ProcessTerminated";

	internal const string ProcessExitTime = "ProcessExitTime";

	internal const string ProcessHandle = "ProcessHandle";

	internal const string ProcessHandleCount = "ProcessHandleCount";

	internal const string ProcessId = "ProcessId";

	internal const string ProcessMachineName = "ProcessMachineName";

	internal const string ProcessMainModule = "ProcessMainModule";

	internal const string ProcessModules = "ProcessModules";

	internal const string ProcessSynchronizingObject = "ProcessSynchronizingObject";

	internal const string ProcessSessionId = "ProcessSessionId";

	internal const string ProcessThreads = "ProcessThreads";

	internal const string ProcessEnableRaisingEvents = "ProcessEnableRaisingEvents";

	internal const string ProcessExited = "ProcessExited";

	internal const string ProcessFileName = "ProcessFileName";

	internal const string ProcessWorkingDirectory = "ProcessWorkingDirectory";

	internal const string ProcessBasePriority = "ProcessBasePriority";

	internal const string ProcessMainWindowHandle = "ProcessMainWindowHandle";

	internal const string ProcessMainWindowTitle = "ProcessMainWindowTitle";

	internal const string ProcessMaxWorkingSet = "ProcessMaxWorkingSet";

	internal const string ProcessMinWorkingSet = "ProcessMinWorkingSet";

	internal const string ProcessNonpagedSystemMemorySize = "ProcessNonpagedSystemMemorySize";

	internal const string ProcessPagedMemorySize = "ProcessPagedMemorySize";

	internal const string ProcessPagedSystemMemorySize = "ProcessPagedSystemMemorySize";

	internal const string ProcessPeakPagedMemorySize = "ProcessPeakPagedMemorySize";

	internal const string ProcessPeakWorkingSet = "ProcessPeakWorkingSet";

	internal const string ProcessPeakVirtualMemorySize = "ProcessPeakVirtualMemorySize";

	internal const string ProcessPriorityBoostEnabled = "ProcessPriorityBoostEnabled";

	internal const string ProcessPriorityClass = "ProcessPriorityClass";

	internal const string ProcessPrivateMemorySize = "ProcessPrivateMemorySize";

	internal const string ProcessPrivilegedProcessorTime = "ProcessPrivilegedProcessorTime";

	internal const string ProcessProcessName = "ProcessProcessName";

	internal const string ProcessProcessorAffinity = "ProcessProcessorAffinity";

	internal const string ProcessResponding = "ProcessResponding";

	internal const string ProcessStandardError = "ProcessStandardError";

	internal const string ProcessStandardInput = "ProcessStandardInput";

	internal const string ProcessStandardOutput = "ProcessStandardOutput";

	internal const string ProcessStartInfo = "ProcessStartInfo";

	internal const string ProcessStartTime = "ProcessStartTime";

	internal const string ProcessTotalProcessorTime = "ProcessTotalProcessorTime";

	internal const string ProcessUserProcessorTime = "ProcessUserProcessorTime";

	internal const string ProcessVirtualMemorySize = "ProcessVirtualMemorySize";

	internal const string ProcessWorkingSet = "ProcessWorkingSet";

	internal const string ProcModModuleName = "ProcModModuleName";

	internal const string ProcModFileName = "ProcModFileName";

	internal const string ProcModBaseAddress = "ProcModBaseAddress";

	internal const string ProcModModuleMemorySize = "ProcModModuleMemorySize";

	internal const string ProcModEntryPointAddress = "ProcModEntryPointAddress";

	internal const string ProcessVerb = "ProcessVerb";

	internal const string ProcessArguments = "ProcessArguments";

	internal const string ProcessErrorDialog = "ProcessErrorDialog";

	internal const string ProcessWindowStyle = "ProcessWindowStyle";

	internal const string ProcessCreateNoWindow = "ProcessCreateNoWindow";

	internal const string ProcessEnvironmentVariables = "ProcessEnvironmentVariables";

	internal const string ProcessRedirectStandardInput = "ProcessRedirectStandardInput";

	internal const string ProcessRedirectStandardOutput = "ProcessRedirectStandardOutput";

	internal const string ProcessRedirectStandardError = "ProcessRedirectStandardError";

	internal const string ProcessUseShellExecute = "ProcessUseShellExecute";

	internal const string ThreadBasePriority = "ThreadBasePriority";

	internal const string ThreadCurrentPriority = "ThreadCurrentPriority";

	internal const string ThreadId = "ThreadId";

	internal const string ThreadPriorityBoostEnabled = "ThreadPriorityBoostEnabled";

	internal const string ThreadPriorityLevel = "ThreadPriorityLevel";

	internal const string ThreadPrivilegedProcessorTime = "ThreadPrivilegedProcessorTime";

	internal const string ThreadStartAddress = "ThreadStartAddress";

	internal const string ThreadStartTime = "ThreadStartTime";

	internal const string ThreadThreadState = "ThreadThreadState";

	internal const string ThreadTotalProcessorTime = "ThreadTotalProcessorTime";

	internal const string ThreadUserProcessorTime = "ThreadUserProcessorTime";

	internal const string ThreadWaitReason = "ThreadWaitReason";

	internal const string VerbEditorDefault = "VerbEditorDefault";

	internal const string AppSettingsReaderNoKey = "AppSettingsReaderNoKey";

	internal const string AppSettingsReaderNoParser = "AppSettingsReaderNoParser";

	internal const string AppSettingsReaderCantParse = "AppSettingsReaderCantParse";

	internal const string AppSettingsReaderEmptyString = "AppSettingsReaderEmptyString";

	internal const string InvalidPermissionState = "InvalidPermissionState";

	internal const string PermissionNumberOfElements = "PermissionNumberOfElements";

	internal const string PermissionItemExists = "PermissionItemExists";

	internal const string PermissionItemDoesntExist = "PermissionItemDoesntExist";

	internal const string PermissionBadParameterEnum = "PermissionBadParameterEnum";

	internal const string PermissionInvalidLength = "PermissionInvalidLength";

	internal const string PermissionTypeMismatch = "PermissionTypeMismatch";

	internal const string Argument_NotAPermissionElement = "Argument_NotAPermissionElement";

	internal const string Argument_InvalidXMLBadVersion = "Argument_InvalidXMLBadVersion";

	internal const string InvalidPermissionLevel = "InvalidPermissionLevel";

	internal const string TargetNotWebBrowserPermissionLevel = "TargetNotWebBrowserPermissionLevel";

	internal const string WebBrowserBadXml = "WebBrowserBadXml";

	internal const string KeyedCollNeedNonNegativeNum = "KeyedCollNeedNonNegativeNum";

	internal const string KeyedCollDuplicateKey = "KeyedCollDuplicateKey";

	internal const string KeyedCollReferenceKeyNotFound = "KeyedCollReferenceKeyNotFound";

	internal const string KeyedCollKeyNotFound = "KeyedCollKeyNotFound";

	internal const string KeyedCollInvalidKey = "KeyedCollInvalidKey";

	internal const string KeyedCollCapacityOverflow = "KeyedCollCapacityOverflow";

	internal const string InvalidOperation_EnumEnded = "InvalidOperation_EnumEnded";

	internal const string OrderedDictionary_ReadOnly = "OrderedDictionary_ReadOnly";

	internal const string OrderedDictionary_SerializationMismatch = "OrderedDictionary_SerializationMismatch";

	internal const string Async_ExceptionOccurred = "Async_ExceptionOccurred";

	internal const string Async_QueueingFailed = "Async_QueueingFailed";

	internal const string Async_OperationCancelled = "Async_OperationCancelled";

	internal const string Async_OperationAlreadyCompleted = "Async_OperationAlreadyCompleted";

	internal const string Async_NullDelegate = "Async_NullDelegate";

	internal const string BackgroundWorker_WorkerAlreadyRunning = "BackgroundWorker_WorkerAlreadyRunning";

	internal const string BackgroundWorker_WorkerDoesntReportProgress = "BackgroundWorker_WorkerDoesntReportProgress";

	internal const string BackgroundWorker_WorkerDoesntSupportCancellation = "BackgroundWorker_WorkerDoesntSupportCancellation";

	internal const string Async_ProgressChangedEventArgs_ProgressPercentage = "Async_ProgressChangedEventArgs_ProgressPercentage";

	internal const string Async_ProgressChangedEventArgs_UserState = "Async_ProgressChangedEventArgs_UserState";

	internal const string Async_AsyncEventArgs_Cancelled = "Async_AsyncEventArgs_Cancelled";

	internal const string Async_AsyncEventArgs_Error = "Async_AsyncEventArgs_Error";

	internal const string Async_AsyncEventArgs_UserState = "Async_AsyncEventArgs_UserState";

	internal const string BackgroundWorker_CancellationPending = "BackgroundWorker_CancellationPending";

	internal const string BackgroundWorker_DoWork = "BackgroundWorker_DoWork";

	internal const string BackgroundWorker_IsBusy = "BackgroundWorker_IsBusy";

	internal const string BackgroundWorker_ProgressChanged = "BackgroundWorker_ProgressChanged";

	internal const string BackgroundWorker_RunWorkerCompleted = "BackgroundWorker_RunWorkerCompleted";

	internal const string BackgroundWorker_WorkerReportsProgress = "BackgroundWorker_WorkerReportsProgress";

	internal const string BackgroundWorker_WorkerSupportsCancellation = "BackgroundWorker_WorkerSupportsCancellation";

	internal const string BackgroundWorker_DoWorkEventArgs_Argument = "BackgroundWorker_DoWorkEventArgs_Argument";

	internal const string BackgroundWorker_DoWorkEventArgs_Result = "BackgroundWorker_DoWorkEventArgs_Result";

	internal const string BackgroundWorker_Desc = "BackgroundWorker_Desc";

	internal const string InstanceCreationEditorDefaultText = "InstanceCreationEditorDefaultText";

	internal const string PropertyTabAttributeBadPropertyTabScope = "PropertyTabAttributeBadPropertyTabScope";

	internal const string PropertyTabAttributeTypeLoadException = "PropertyTabAttributeTypeLoadException";

	internal const string PropertyTabAttributeArrayLengthMismatch = "PropertyTabAttributeArrayLengthMismatch";

	internal const string PropertyTabAttributeParamsBothNull = "PropertyTabAttributeParamsBothNull";

	internal const string InstanceDescriptorCannotBeStatic = "InstanceDescriptorCannotBeStatic";

	internal const string InstanceDescriptorMustBeStatic = "InstanceDescriptorMustBeStatic";

	internal const string InstanceDescriptorMustBeReadable = "InstanceDescriptorMustBeReadable";

	internal const string InstanceDescriptorLengthMismatch = "InstanceDescriptorLengthMismatch";

	internal const string ToolboxItemAttributeFailedGetType = "ToolboxItemAttributeFailedGetType";

	internal const string PropertyDescriptorCollectionBadValue = "PropertyDescriptorCollectionBadValue";

	internal const string PropertyDescriptorCollectionBadKey = "PropertyDescriptorCollectionBadKey";

	internal const string AspNetHostingPermissionBadXml = "AspNetHostingPermissionBadXml";

	internal const string CorruptedGZipHeader = "CorruptedGZipHeader";

	internal const string UnknownCompressionMode = "UnknownCompressionMode";

	internal const string UnknownState = "UnknownState";

	internal const string InvalidHuffmanData = "InvalidHuffmanData";

	internal const string InvalidCRC = "InvalidCRC";

	internal const string InvalidStreamSize = "InvalidStreamSize";

	internal const string UnknownBlockType = "UnknownBlockType";

	internal const string InvalidBlockLength = "InvalidBlockLength";

	internal const string GenericInvalidData = "GenericInvalidData";

	internal const string CannotReadFromDeflateStream = "CannotReadFromDeflateStream";

	internal const string CannotWriteToDeflateStream = "CannotWriteToDeflateStream";

	internal const string NotReadableStream = "NotReadableStream";

	internal const string NotWriteableStream = "NotWriteableStream";

	internal const string InvalidArgumentOffsetCount = "InvalidArgumentOffsetCount";

	internal const string InvalidBeginCall = "InvalidBeginCall";

	internal const string InvalidEndCall = "InvalidEndCall";

	internal const string StreamSizeOverflow = "StreamSizeOverflow";

	internal const string InvalidOperation_HCCountOverflow = "InvalidOperation_HCCountOverflow";

	internal const string Argument_InvalidThreshold = "Argument_InvalidThreshold";

	internal const string Argument_SemaphoreInitialMaximum = "Argument_SemaphoreInitialMaximum";

	internal const string Argument_WaitHandleNameTooLong = "Argument_WaitHandleNameTooLong";

	internal const string Threading_SemaphoreFullException = "Threading_SemaphoreFullException";

	internal const string WaitHandleCannotBeOpenedException_InvalidHandle = "WaitHandleCannotBeOpenedException_InvalidHandle";

	internal const string ArgumentNotAPermissionElement = "ArgumentNotAPermissionElement";

	internal const string ArgumentWrongType = "ArgumentWrongType";

	internal const string BadXmlVersion = "BadXmlVersion";

	internal const string BinarySerializationNotSupported = "BinarySerializationNotSupported";

	internal const string BothScopeAttributes = "BothScopeAttributes";

	internal const string NoScopeAttributes = "NoScopeAttributes";

	internal const string PositionOutOfRange = "PositionOutOfRange";

	internal const string ProviderInstantiationFailed = "ProviderInstantiationFailed";

	internal const string ProviderTypeLoadFailed = "ProviderTypeLoadFailed";

	internal const string SaveAppScopedNotSupported = "SaveAppScopedNotSupported";

	internal const string SettingsResetFailed = "SettingsResetFailed";

	internal const string SettingsSaveFailed = "SettingsSaveFailed";

	internal const string SettingsSaveFailedNoSection = "SettingsSaveFailedNoSection";

	internal const string StringDeserializationFailed = "StringDeserializationFailed";

	internal const string StringSerializationFailed = "StringSerializationFailed";

	internal const string UnknownSerializationFormat = "UnknownSerializationFormat";

	internal const string UnknownSeekOrigin = "UnknownSeekOrigin";

	internal const string UnknownUserLevel = "UnknownUserLevel";

	internal const string UserSettingsNotSupported = "UserSettingsNotSupported";

	internal const string XmlDeserializationFailed = "XmlDeserializationFailed";

	internal const string XmlSerializationFailed = "XmlSerializationFailed";

	internal const string MemberRelationshipService_RelationshipNotSupported = "MemberRelationshipService_RelationshipNotSupported";

	internal const string MaskedTextProviderPasswordAndPromptCharError = "MaskedTextProviderPasswordAndPromptCharError";

	internal const string MaskedTextProviderInvalidCharError = "MaskedTextProviderInvalidCharError";

	internal const string MaskedTextProviderMaskNullOrEmpty = "MaskedTextProviderMaskNullOrEmpty";

	internal const string MaskedTextProviderMaskInvalidChar = "MaskedTextProviderMaskInvalidChar";

	internal const string StandardOleMarshalObjectGetMarshalerFailed = "StandardOleMarshalObjectGetMarshalerFailed";

	internal const string SoundAPIBadSoundLocation = "SoundAPIBadSoundLocation";

	internal const string SoundAPIFileDoesNotExist = "SoundAPIFileDoesNotExist";

	internal const string SoundAPIFormatNotSupported = "SoundAPIFormatNotSupported";

	internal const string SoundAPIInvalidWaveFile = "SoundAPIInvalidWaveFile";

	internal const string SoundAPIInvalidWaveHeader = "SoundAPIInvalidWaveHeader";

	internal const string SoundAPILoadTimedOut = "SoundAPILoadTimedOut";

	internal const string SoundAPILoadTimeout = "SoundAPILoadTimeout";

	internal const string SoundAPIReadError = "SoundAPIReadError";

	private static CultureInfo Culture => null;

	internal SR()
	{
		resources = new ResourceManager("System.Workflow.ComponentModel.StringResources", Assembly.GetExecutingAssembly());
	}

	private static SR GetLoader()
	{
		if (loader == null)
		{
			loader = new SR();
		}
		return loader;
	}

	internal static string GetString(string name, params object[] args)
	{
		return GetString(Culture, name, args);
	}

	internal static string GetString(CultureInfo culture, string name, params object[] args)
	{
		SR sR = GetLoader();
		if (sR == null)
		{
			return null;
		}
		string @string = sR.resources.GetString(name, culture);
		Debug.Assert(@string != null, string.Format(CultureInfo.CurrentCulture, "String resource {0} not found.", new object[1] { name }));
		if (args != null && args.Length != 0)
		{
			return string.Format(CultureInfo.CurrentCulture, @string, args);
		}
		return @string;
	}

	internal static string GetString(string name)
	{
		return GetString(Culture, name);
	}

	internal static string GetString(CultureInfo culture, string name)
	{
		SR sR = GetLoader();
		if (sR == null)
		{
			return null;
		}
		string @string = sR.resources.GetString(name, culture);
		Debug.Assert(@string != null, string.Format(CultureInfo.CurrentCulture, "String resource {0} not found.", new object[1] { name }));
		return @string;
	}
}
