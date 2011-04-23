﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.Ast;
using IIS.SLSharp.Descriptions;
using IIS.SLSharp.Shaders;
using Mono.Cecil;

namespace IIS.SLSharp.Translation.GLSL
{
    public sealed class GlslTransform: ITransform
    {
        private readonly HashSet<Tuple<string, string>> _functions = new HashSet<Tuple<string, string>>();

        public void ResetState()
        {
            _functions.Clear();
        }

        /// <summary>
        /// Public translation interface.
        /// Translates the given method to GLSL
        /// </summary>
        /// <param name="s">Shader type definition.</param>
        /// <param name="m">A method representing a shader to translate.</param>
        /// <param name="attr">The shader type pass either (FragmentShaderAttribute or VertexShaderAttribute) </param>
        /// <returns>The translated GLSL shader source</returns>
        public FunctionDescription Transform(TypeDefinition s, MethodDefinition m, CustomAttribute attr)
        {
            if (s == null)
                throw new ArgumentNullException("s");

            if (m == null)
                throw new ArgumentNullException("m");

            if (attr == null)
                throw new ArgumentNullException("attr");

            var d = AstMethodBodyBuilder.CreateMethodBody(m, new DecompilerContext
            {
                CurrentType = s,
                CurrentMethod = m,
                CancellationToken = CancellationToken.None
            });

            var glsl = new GlslVisitor(d, attr);

            _functions.UnionWith(glsl.Functions);

            var entry = (bool)attr.ConstructorArguments.FirstOrDefault().Value;
            var sig = entry ? "void main()" : GlslVisitor.GetSignature(m);
            
            var code = glsl.Result;
            var desc = new FunctionDescription(entry ? "main" : Shader.GetMethodName(m), sig + code);

            return desc;
        }

        public List<string> ForwardDeclare(bool debugInfo)
        {
            return _functions.Select(f => f.Item1 + ";" + (debugInfo ? " // " + f.Item2 : string.Empty)).ToList();
        }
    }
}
