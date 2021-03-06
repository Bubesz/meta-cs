//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\balaz\AppData\Local\Temp\21gz4dhl.25l\AnnotatedAntlr4PropertiesParser.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace MetaDslx.Compiler {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="AnnotatedAntlr4PropertiesParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public interface IAnnotatedAntlr4PropertiesParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.propertiesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertiesBlock([NotNull] AnnotatedAntlr4PropertiesParser.PropertiesBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.propertiesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertiesBlock([NotNull] AnnotatedAntlr4PropertiesParser.PropertiesBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertyAssignment([NotNull] AnnotatedAntlr4PropertiesParser.PropertyAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertyAssignment([NotNull] AnnotatedAntlr4PropertiesParser.PropertyAssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.qualifiedProperty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualifiedProperty([NotNull] AnnotatedAntlr4PropertiesParser.QualifiedPropertyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.qualifiedProperty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualifiedProperty([NotNull] AnnotatedAntlr4PropertiesParser.QualifiedPropertyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.propertySelector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertySelector([NotNull] AnnotatedAntlr4PropertiesParser.PropertySelectorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.propertySelector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertySelector([NotNull] AnnotatedAntlr4PropertiesParser.PropertySelectorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.expressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionList([NotNull] AnnotatedAntlr4PropertiesParser.ExpressionListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.expressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionList([NotNull] AnnotatedAntlr4PropertiesParser.ExpressionListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] AnnotatedAntlr4PropertiesParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] AnnotatedAntlr4PropertiesParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] AnnotatedAntlr4PropertiesParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] AnnotatedAntlr4PropertiesParser.FunctionCallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] AnnotatedAntlr4PropertiesParser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] AnnotatedAntlr4PropertiesParser.LiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] AnnotatedAntlr4PropertiesParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] AnnotatedAntlr4PropertiesParser.IdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.booleanLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanLiteral([NotNull] AnnotatedAntlr4PropertiesParser.BooleanLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.booleanLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanLiteral([NotNull] AnnotatedAntlr4PropertiesParser.BooleanLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.nullLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNullLiteral([NotNull] AnnotatedAntlr4PropertiesParser.NullLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnnotatedAntlr4PropertiesParser.nullLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNullLiteral([NotNull] AnnotatedAntlr4PropertiesParser.NullLiteralContext context);
}
} // namespace MetaDslx.Compiler
