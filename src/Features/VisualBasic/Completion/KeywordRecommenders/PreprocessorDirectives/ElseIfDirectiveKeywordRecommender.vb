' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports System.Threading
Imports Microsoft.CodeAnalysis.Completion.Providers
Imports Microsoft.CodeAnalysis.VisualBasic.Extensions.ContextQuery

Namespace Microsoft.CodeAnalysis.VisualBasic.Completion.KeywordRecommenders.PreprocessorDirectives
    ''' <summary>
    ''' Recommends the "#ElseIf" preprocessor directive
    ''' </summary>
    Friend Class ElseIfDirectiveKeywordRecommender
        Inherits AbstractKeywordRecommender

        Protected Overrides Function RecommendKeywords(context As VisualBasicSyntaxContext, cancellationToken As CancellationToken) As IEnumerable(Of RecommendedKeyword)
            If context.IsPreprocessorStartContext Then
                Dim innermostKind = context.SyntaxTree.GetInnermostIfPreprocessorKind(context.Position, cancellationToken)

                If innermostKind.HasValue AndAlso innermostKind.Value <> SyntaxKind.ElseDirectiveTrivia Then
                    Return SpecializedCollections.SingletonEnumerable(New RecommendedKeyword("#ElseIf", VBFeaturesResources.ElseIfCCKeywordToolTip))
                End If
            End If

            Return SpecializedCollections.EmptyEnumerable(Of RecommendedKeyword)()
        End Function
    End Class
End Namespace
