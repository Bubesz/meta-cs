﻿using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Compiler
{
    [Flags]
    public enum MetaMofName
    {
        None = 0,
        Type = 1,
        Name = 2
    }

    public class SyntaxAnnotation
    {
        public int First { get; set; }
        public int Last { get; set; }
        public int Kind { get; set; }
    }

    public class SyntaxKind
    {
        public const int Keyword = 1;
        public const int Identifier = 2;
        public const int String = 3;
        public const int Number = 4;
        public const int Comment = 5;
        public const int DocComment = 6;

        public const int Action = 7;
        public const int Options = 8;
        public const int Tokens = 9;
    }

    public enum NameKind
    {
        Namespace,
        Metamodel,
        Class,
        Enum,
        EnumValue,
        Property,
        Const,
        Operation,
        Parameter
    }

    public class NameDefAnnotation
    {
        public NameKind? Kind { get; set; }
    }

    public class NameUseAnnotation
    {
        public NameKind? Kind { get; set; }
    }

    public class TypeDefAnnotation
    {
    }

    public class TypeUseAnnotation
    {
        public NameKind? Kind { get; set; }
    }

    public class ScopeAnnotation
    {

    }

    public class IdentifierAnnotation
    {

    }

    public class QualifiedNameAnnotation
    {

    }

    public abstract class MetaCompiler : IAntlrErrorListener<int>, IAntlrErrorListener<IToken>
    {
        public MetaCompilerDiagnostics Diagnostics { get; private set; }
        public string FileName { get; private set; }
        public string Source { get; private set; }

        public MetaCompiler(string source, string fileName = null)
        {
            this.Diagnostics = new MetaCompilerDiagnostics();
            this.Source = source;
            this.FileName = fileName;
        }

        public abstract void Compile();

        void IAntlrErrorListener<int>.SyntaxError(IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            IToken token = e.OffendingToken;
            if (token != null)
            {
                this.Diagnostics.AddError(msg, this.FileName, new TextSpan(token));
            }
            else
            {
                this.Diagnostics.AddError(msg, this.FileName, new TextSpan(line, charPositionInLine+1, line, charPositionInLine+1));
            }
        }

        void IAntlrErrorListener<IToken>.SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            if (offendingSymbol != null)
            {
                this.Diagnostics.AddError(msg, this.FileName, new TextSpan(offendingSymbol));
            }
            else
            {
                this.Diagnostics.AddError(msg, this.FileName, new TextSpan(line, charPositionInLine+1, line, charPositionInLine+1));
            }
        }
    }
}
