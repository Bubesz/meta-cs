//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\balaz\AppData\Local\Temp\lxcm2qwt.thm\SoalParser.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace MetaDslx.Soal {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="SoalParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public interface ISoalParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.main"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMain([NotNull] SoalParser.MainContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.qualifiedName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQualifiedName([NotNull] SoalParser.QualifiedNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.identifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierList([NotNull] SoalParser.IdentifierListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.qualifiedNameList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQualifiedNameList([NotNull] SoalParser.QualifiedNameListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.namespaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamespaceDeclaration([NotNull] SoalParser.NamespaceDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclaration([NotNull] SoalParser.DeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.structDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructDeclaration([NotNull] SoalParser.StructDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.exceptionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExceptionDeclaration([NotNull] SoalParser.ExceptionDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.entityDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEntityDeclaration([NotNull] SoalParser.EntityDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.propertyDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPropertyDeclaration([NotNull] SoalParser.PropertyDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.databaseDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatabaseDeclaration([NotNull] SoalParser.DatabaseDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.entityReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEntityReference([NotNull] SoalParser.EntityReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.interfaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInterfaceDeclaration([NotNull] SoalParser.InterfaceDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.operationDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperationDeclaration([NotNull] SoalParser.OperationDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterList([NotNull] SoalParser.ParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameter([NotNull] SoalParser.ParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.componentDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComponentDeclaration([NotNull] SoalParser.ComponentDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.componentElements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComponentElements([NotNull] SoalParser.ComponentElementsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.componentElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComponentElement([NotNull] SoalParser.ComponentElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.componentService"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComponentService([NotNull] SoalParser.ComponentServiceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.componentReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComponentReference([NotNull] SoalParser.ComponentReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.componentServiceOrReferenceBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComponentServiceOrReferenceBody([NotNull] SoalParser.ComponentServiceOrReferenceBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.componentServiceOrReferenceElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComponentServiceOrReferenceElement([NotNull] SoalParser.ComponentServiceOrReferenceElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.componentProperty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComponentProperty([NotNull] SoalParser.ComponentPropertyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.componentImplementation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComponentImplementation([NotNull] SoalParser.ComponentImplementationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.componentLanguage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComponentLanguage([NotNull] SoalParser.ComponentLanguageContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.compositeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompositeDeclaration([NotNull] SoalParser.CompositeDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.compositeElements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompositeElements([NotNull] SoalParser.CompositeElementsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.compositeElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompositeElement([NotNull] SoalParser.CompositeElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.compositeComponent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompositeComponent([NotNull] SoalParser.CompositeComponentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.compositeWire"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompositeWire([NotNull] SoalParser.CompositeWireContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.wireSource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWireSource([NotNull] SoalParser.WireSourceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.wireTarget"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWireTarget([NotNull] SoalParser.WireTargetContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.deploymentDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeploymentDeclaration([NotNull] SoalParser.DeploymentDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.deploymentElements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeploymentElements([NotNull] SoalParser.DeploymentElementsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.deploymentElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeploymentElement([NotNull] SoalParser.DeploymentElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.environmentDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnvironmentDeclaration([NotNull] SoalParser.EnvironmentDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.runtimeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRuntimeDeclaration([NotNull] SoalParser.RuntimeDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.runtimeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRuntimeReference([NotNull] SoalParser.RuntimeReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.assemblyReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssemblyReference([NotNull] SoalParser.AssemblyReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.databaseReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatabaseReference([NotNull] SoalParser.DatabaseReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.bindingDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBindingDeclaration([NotNull] SoalParser.BindingDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.bindingLayers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBindingLayers([NotNull] SoalParser.BindingLayersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.transportLayer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTransportLayer([NotNull] SoalParser.TransportLayerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.transportLayerKind"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTransportLayerKind([NotNull] SoalParser.TransportLayerKindContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.encodingLayer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEncodingLayer([NotNull] SoalParser.EncodingLayerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.encodingLayerKind"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEncodingLayerKind([NotNull] SoalParser.EncodingLayerKindContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.protocolLayer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProtocolLayer([NotNull] SoalParser.ProtocolLayerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.protocolLayerKind"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProtocolLayerKind([NotNull] SoalParser.ProtocolLayerKindContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.endpointDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEndpointDeclaration([NotNull] SoalParser.EndpointDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.endpointProperties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEndpointProperties([NotNull] SoalParser.EndpointPropertiesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.endpointProperty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEndpointProperty([NotNull] SoalParser.EndpointPropertyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.endpointBindingProperty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEndpointBindingProperty([NotNull] SoalParser.EndpointBindingPropertyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.endpointAddressProperty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEndpointAddressProperty([NotNull] SoalParser.EndpointAddressPropertyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.returnType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnType([NotNull] SoalParser.ReturnTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.typeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeReference([NotNull] SoalParser.TypeReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.simpleType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleType([NotNull] SoalParser.SimpleTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.objectType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitObjectType([NotNull] SoalParser.ObjectTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.primitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimitiveType([NotNull] SoalParser.PrimitiveTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.voidType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVoidType([NotNull] SoalParser.VoidTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.onewayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOnewayType([NotNull] SoalParser.OnewayTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.nullableType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNullableType([NotNull] SoalParser.NullableTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.arrayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayType([NotNull] SoalParser.ArrayTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] SoalParser.IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteral([NotNull] SoalParser.LiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.nullLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNullLiteral([NotNull] SoalParser.NullLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.booleanLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanLiteral([NotNull] SoalParser.BooleanLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.integerLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntegerLiteral([NotNull] SoalParser.IntegerLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.decimalLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDecimalLiteral([NotNull] SoalParser.DecimalLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.scientificLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScientificLiteral([NotNull] SoalParser.ScientificLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SoalParser.stringLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringLiteral([NotNull] SoalParser.StringLiteralContext context);
}
} // namespace MetaDslx.Soal
