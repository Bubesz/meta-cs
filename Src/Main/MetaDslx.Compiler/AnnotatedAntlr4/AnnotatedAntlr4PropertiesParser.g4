﻿/** A parser grammar for ANTLR v4 annotated grammar properties */
parser grammar AnnotatedAntlr4PropertiesParser;

options {
	tokenVocab=AnnotatedAntlr4PropertiesLexer;
	                       
}

// The main entry point for parsing a v4 grammar.
propertiesBlock
	:	LBRACE propertyAssignment* RBRACE EOF
	;

propertyAssignment
	:	qualifiedProperty ASSIGN expression SEMI
	;

qualifiedProperty
	:   (scope=identifier COLONCOLON)? propertySelector (DOT propertySelector)*
	;

propertySelector
	:   name=identifier (LBRACKET selector=identifier RBRACKET)?
	;

expressionList
    : LPAREN expression (COMMA expression)* RPAREN;

expression
	: literal
	| qualifiedProperty
	| functionCall 
	;

functionCall
	: identifier expressionList
	;

literal 
	: nullLiteral
	| booleanLiteral
    | INTEGER_LITERAL
	| SCIENTIFIC_LITERAL 
    | STRING_LITERAL
	;

identifier : ID;

booleanLiteral : TRUE | FALSE;

nullLiteral : NULL;

