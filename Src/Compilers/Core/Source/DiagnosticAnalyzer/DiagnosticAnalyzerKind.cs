﻿using System;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    /// <summary>
    /// Kind of analysis performed and diagnostics generated by the corresponding <see cref="IDiagnosticAnalyzer"/>
    /// </summary>
    [Flags]
    public enum DiagnosticAnalyzerKind
    {
        /// <summary>
        /// Analyzer performs only syntax level analysis.
        /// </summary>
        Syntax = 0x0001,

        /// <summary>
        /// Analyzer performs local state-less semantic analysis in any given sub-span within a syntax tree or any declared symbol.
        /// </summary>
        SemanticInNodeOrSymbol = 0x0010,

        /// <summary>
        /// Analyzer performs whole document semantic analysis to generate diagnostics.
        /// </summary>
        SemanticInTree = 0x0100,

        /// <summary>
        /// Analyzer performs compilation wide semantic analysis to generate diagnostics.
        /// </summary>
        SemanticInCompilation = 0x1000,

        All = Syntax | SemanticInNodeOrSymbol | SemanticInTree | SemanticInCompilation,
    }
}