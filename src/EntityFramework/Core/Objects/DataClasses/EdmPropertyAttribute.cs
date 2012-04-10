namespace System.Data.Entity.Core.Objects.DataClasses
{
    using System;
    using System.Diagnostics.CodeAnalysis;

#pragma warning disable 3015 // no accessible constructors which use only CLS-compliant types

    /// <summary>
    /// Base attribute for properties mapped to store elements.
    /// Implied default AttributeUsage properties Inherited=True, AllowMultiple=False,
    /// The metadata system expects this and will only look at the first of each of these attributes, even if there are more.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public abstract class EdmPropertyAttribute: System.Attribute
    {
        /// <summary>
        /// Only allow derived attributes from this assembly
        /// </summary>
        internal EdmPropertyAttribute()
        {
        }
    }
}