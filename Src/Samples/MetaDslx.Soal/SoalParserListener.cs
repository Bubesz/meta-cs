//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\balaz\AppData\Local\Temp\rtfqoasx.jcq\SoalParser.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace MetaDslx.Soal {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SoalParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public interface ISoalParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.main"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMain([NotNull] SoalParser.MainContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.main"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMain([NotNull] SoalParser.MainContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.qualifiedName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualifiedName([NotNull] SoalParser.QualifiedNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.qualifiedName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualifiedName([NotNull] SoalParser.QualifiedNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.identifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierList([NotNull] SoalParser.IdentifierListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.identifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierList([NotNull] SoalParser.IdentifierListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.qualifiedNameList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualifiedNameList([NotNull] SoalParser.QualifiedNameListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.qualifiedNameList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualifiedNameList([NotNull] SoalParser.QualifiedNameListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.namespaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespaceDeclaration([NotNull] SoalParser.NamespaceDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.namespaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespaceDeclaration([NotNull] SoalParser.NamespaceDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] SoalParser.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] SoalParser.DeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.structDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStructDeclaration([NotNull] SoalParser.StructDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.structDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStructDeclaration([NotNull] SoalParser.StructDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.exceptionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExceptionDeclaration([NotNull] SoalParser.ExceptionDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.exceptionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExceptionDeclaration([NotNull] SoalParser.ExceptionDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.propertyDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertyDeclaration([NotNull] SoalParser.PropertyDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.propertyDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertyDeclaration([NotNull] SoalParser.PropertyDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.databaseDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatabaseDeclaration([NotNull] SoalParser.DatabaseDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.databaseDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatabaseDeclaration([NotNull] SoalParser.DatabaseDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.entityDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntityDeclaration([NotNull] SoalParser.EntityDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.entityDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntityDeclaration([NotNull] SoalParser.EntityDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.interfaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceDeclaration([NotNull] SoalParser.InterfaceDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.interfaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceDeclaration([NotNull] SoalParser.InterfaceDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.operationDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperationDeclaration([NotNull] SoalParser.OperationDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.operationDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperationDeclaration([NotNull] SoalParser.OperationDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterList([NotNull] SoalParser.ParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterList([NotNull] SoalParser.ParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameter([NotNull] SoalParser.ParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameter([NotNull] SoalParser.ParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.componentDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComponentDeclaration([NotNull] SoalParser.ComponentDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.componentDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComponentDeclaration([NotNull] SoalParser.ComponentDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.componentElements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComponentElements([NotNull] SoalParser.ComponentElementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.componentElements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComponentElements([NotNull] SoalParser.ComponentElementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.componentElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComponentElement([NotNull] SoalParser.ComponentElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.componentElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComponentElement([NotNull] SoalParser.ComponentElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.componentService"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComponentService([NotNull] SoalParser.ComponentServiceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.componentService"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComponentService([NotNull] SoalParser.ComponentServiceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.componentReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComponentReference([NotNull] SoalParser.ComponentReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.componentReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComponentReference([NotNull] SoalParser.ComponentReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.componentServiceOrReferenceBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComponentServiceOrReferenceBody([NotNull] SoalParser.ComponentServiceOrReferenceBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.componentServiceOrReferenceBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComponentServiceOrReferenceBody([NotNull] SoalParser.ComponentServiceOrReferenceBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.componentServiceOrReferenceElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComponentServiceOrReferenceElement([NotNull] SoalParser.ComponentServiceOrReferenceElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.componentServiceOrReferenceElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComponentServiceOrReferenceElement([NotNull] SoalParser.ComponentServiceOrReferenceElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.componentProperty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComponentProperty([NotNull] SoalParser.ComponentPropertyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.componentProperty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComponentProperty([NotNull] SoalParser.ComponentPropertyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.componentImplementation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComponentImplementation([NotNull] SoalParser.ComponentImplementationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.componentImplementation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComponentImplementation([NotNull] SoalParser.ComponentImplementationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.compositeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompositeDeclaration([NotNull] SoalParser.CompositeDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.compositeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompositeDeclaration([NotNull] SoalParser.CompositeDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.compositeElements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompositeElements([NotNull] SoalParser.CompositeElementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.compositeElements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompositeElements([NotNull] SoalParser.CompositeElementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.compositeElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompositeElement([NotNull] SoalParser.CompositeElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.compositeElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompositeElement([NotNull] SoalParser.CompositeElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.compositeComponent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompositeComponent([NotNull] SoalParser.CompositeComponentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.compositeComponent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompositeComponent([NotNull] SoalParser.CompositeComponentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.compositeWire"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompositeWire([NotNull] SoalParser.CompositeWireContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.compositeWire"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompositeWire([NotNull] SoalParser.CompositeWireContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.wireService"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWireService([NotNull] SoalParser.WireServiceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.wireService"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWireService([NotNull] SoalParser.WireServiceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.wireReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWireReference([NotNull] SoalParser.WireReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.wireReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWireReference([NotNull] SoalParser.WireReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.bindingDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBindingDeclaration([NotNull] SoalParser.BindingDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.bindingDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBindingDeclaration([NotNull] SoalParser.BindingDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.bindingLayers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBindingLayers([NotNull] SoalParser.BindingLayersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.bindingLayers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBindingLayers([NotNull] SoalParser.BindingLayersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.transportLayer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransportLayer([NotNull] SoalParser.TransportLayerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.transportLayer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransportLayer([NotNull] SoalParser.TransportLayerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.transportLayerKind"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransportLayerKind([NotNull] SoalParser.TransportLayerKindContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.transportLayerKind"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransportLayerKind([NotNull] SoalParser.TransportLayerKindContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.encodingLayer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEncodingLayer([NotNull] SoalParser.EncodingLayerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.encodingLayer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEncodingLayer([NotNull] SoalParser.EncodingLayerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.encodingLayerKind"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEncodingLayerKind([NotNull] SoalParser.EncodingLayerKindContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.encodingLayerKind"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEncodingLayerKind([NotNull] SoalParser.EncodingLayerKindContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.protocolLayer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProtocolLayer([NotNull] SoalParser.ProtocolLayerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.protocolLayer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProtocolLayer([NotNull] SoalParser.ProtocolLayerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.protocolLayerKind"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProtocolLayerKind([NotNull] SoalParser.ProtocolLayerKindContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.protocolLayerKind"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProtocolLayerKind([NotNull] SoalParser.ProtocolLayerKindContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.endpointDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEndpointDeclaration([NotNull] SoalParser.EndpointDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.endpointDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEndpointDeclaration([NotNull] SoalParser.EndpointDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.endpointProperties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEndpointProperties([NotNull] SoalParser.EndpointPropertiesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.endpointProperties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEndpointProperties([NotNull] SoalParser.EndpointPropertiesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.endpointProperty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEndpointProperty([NotNull] SoalParser.EndpointPropertyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.endpointProperty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEndpointProperty([NotNull] SoalParser.EndpointPropertyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.endpointBindingProperty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEndpointBindingProperty([NotNull] SoalParser.EndpointBindingPropertyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.endpointBindingProperty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEndpointBindingProperty([NotNull] SoalParser.EndpointBindingPropertyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.endpointAddressProperty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEndpointAddressProperty([NotNull] SoalParser.EndpointAddressPropertyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.endpointAddressProperty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEndpointAddressProperty([NotNull] SoalParser.EndpointAddressPropertyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.returnType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnType([NotNull] SoalParser.ReturnTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.returnType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnType([NotNull] SoalParser.ReturnTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.typeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeReference([NotNull] SoalParser.TypeReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.typeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeReference([NotNull] SoalParser.TypeReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.simpleType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleType([NotNull] SoalParser.SimpleTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.simpleType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleType([NotNull] SoalParser.SimpleTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.objectType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObjectType([NotNull] SoalParser.ObjectTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.objectType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObjectType([NotNull] SoalParser.ObjectTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.primitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimitiveType([NotNull] SoalParser.PrimitiveTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.primitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimitiveType([NotNull] SoalParser.PrimitiveTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.voidType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVoidType([NotNull] SoalParser.VoidTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.voidType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVoidType([NotNull] SoalParser.VoidTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.onewayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOnewayType([NotNull] SoalParser.OnewayTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.onewayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOnewayType([NotNull] SoalParser.OnewayTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.nullableType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNullableType([NotNull] SoalParser.NullableTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.nullableType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNullableType([NotNull] SoalParser.NullableTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.arrayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayType([NotNull] SoalParser.ArrayTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.arrayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayType([NotNull] SoalParser.ArrayTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] SoalParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] SoalParser.IdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] SoalParser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] SoalParser.LiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.nullLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNullLiteral([NotNull] SoalParser.NullLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.nullLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNullLiteral([NotNull] SoalParser.NullLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.booleanLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanLiteral([NotNull] SoalParser.BooleanLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.booleanLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanLiteral([NotNull] SoalParser.BooleanLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.integerLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntegerLiteral([NotNull] SoalParser.IntegerLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.integerLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntegerLiteral([NotNull] SoalParser.IntegerLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.decimalLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecimalLiteral([NotNull] SoalParser.DecimalLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.decimalLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecimalLiteral([NotNull] SoalParser.DecimalLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.scientificLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScientificLiteral([NotNull] SoalParser.ScientificLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.scientificLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScientificLiteral([NotNull] SoalParser.ScientificLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SoalParser.stringLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStringLiteral([NotNull] SoalParser.StringLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SoalParser.stringLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStringLiteral([NotNull] SoalParser.StringLiteralContext context);
}
} // namespace MetaDslx.Soal