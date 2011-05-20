﻿using System;
using System.Text;
using ICSharpCode.NRefactory.CSharp;
using ICSharpCode.NRefactory.PatternMatching;

namespace IIS.SLSharp.Translation.HLSL
{
    internal sealed partial class HlslVisitor
    {
        public StringBuilder VisitUndocumentedExpression(UndocumentedExpression undocumentedExpression, int data)
        {
            throw new NotImplementedException();
        }

        public StringBuilder VisitArrayCreateExpression(ArrayCreateExpression arrayCreateExpression, int data)
        {
            throw new NotImplementedException();
        }

        public StringBuilder VisitArrayInitializerExpression(ArrayInitializerExpression arrayInitializerExpression, int data)
        {
            throw new NotImplementedException();
        }

        public StringBuilder VisitBaseReferenceExpression(BaseReferenceExpression baseReferenceExpression, int data)
        {
            return null;
        }

        public StringBuilder VisitConditionalExpression(ConditionalExpression conditionalExpression, int data)
        {
            throw new NotImplementedException();
        }

        public StringBuilder VisitDefaultValueExpression(DefaultValueExpression defaultValueExpression, int data)
        {
            throw new NotImplementedException();
        }

        public StringBuilder VisitIndexerExpression(IndexerExpression indexerExpression, int data)
        {
            throw new NotImplementedException();
        }

        public StringBuilder VisitAnonymousTypeCreateExpression(AnonymousTypeCreateExpression anonymousTypeCreateExpression, int data)
        {
            throw new NotImplementedException();
        }

        public StringBuilder VisitParenthesizedExpression(ParenthesizedExpression parenthesizedExpression, int data)
        {
            throw new NotImplementedException();
        }

        public StringBuilder VisitThisReferenceExpression(ThisReferenceExpression thisReferenceExpression, int data)
        {
            return null;
        }

        public StringBuilder VisitUncheckedExpression(UncheckedExpression uncheckedExpression, int data)
        {
            return new StringBuilder();
        }

        public StringBuilder VisitEmptyExpression(EmptyExpression emptyExpression, int data)
        {
            throw new NotImplementedException();
        }

        public StringBuilder VisitEmptyStatement(EmptyStatement emptyStatement, int data)
        {
            return new StringBuilder();
        }

        public StringBuilder VisitForeachStatement(ForeachStatement foreachStatement, int data)
        {
            throw new NotImplementedException();
        }

        public StringBuilder VisitUncheckedStatement(UncheckedStatement uncheckedStatement, int data)
        {
            return new StringBuilder();
        }

        public StringBuilder VisitComposedType(ComposedType composedType, int data)
        {
            throw new NotImplementedException();
        }

        public StringBuilder VisitArraySpecifier(ArraySpecifier arraySpecifier, int data)
        {
            throw new NotImplementedException();
        }

        public StringBuilder VisitCSharpTokenNode(CSharpTokenNode cSharpTokenNode, int data)
        {
            throw new NotImplementedException();
        }

        public StringBuilder VisitIdentifier(Identifier identifier, int data)
        {
            throw new NotImplementedException();
        }

        public StringBuilder VisitPatternPlaceholder(AstNode placeholder, Pattern pattern, int data)
        {
            throw new NotImplementedException();
        }
    }
}
