//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\balaz\AppData\Local\Temp\qgadigol.4qr\SoalParser.g4 by ANTLR 4.5.1

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
