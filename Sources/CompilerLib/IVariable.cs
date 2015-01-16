﻿namespace Dot42.CompilerLib
{
    public interface IVariable
    {
        /// <summary>
        /// Gets the name of the variable.
        /// Can be null
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the name of the variable as used in the original code (IL/Java).
        /// Can be null
        /// </summary>
        string OriginalName { get; }

        /// <summary>
        /// Is this property generated by the compiler?
        /// </summary>
        bool IsCompilerGenerated { get; }

        /// <summary>
        /// Gets the type of this variable.
        /// </summary>
        TTypeRef GetType<TTypeRef>(ITypeResolver<TTypeRef> nameConverter);
    }
}