﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Reflection;

namespace Portable.System.Data.Common.Properties
{


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Portable.System.Data.Common.Properties.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Format of the initialization string does not conform to specification starting at index {0}..
        /// </summary>
        internal static string ADP_ConnectionStringSyntax {
            get {
                return ResourceManager.GetString("ADP_ConnectionStringSyntax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting non-empty string for &apos;{0}&apos; parameter..
        /// </summary>
        internal static string ADP_EmptyString {
            get {
                return ResourceManager.GetString("ADP_EmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal .Net Framework Data Provider error {0}..
        /// </summary>
        internal static string ADP_InternalProviderError {
            get {
                return ResourceManager.GetString("ADP_InternalProviderError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid keyword, contain one or more of &apos;no characters&apos;, &apos;control characters&apos;, &apos;leading or trailing whitespace&apos; or &apos;leading semicolons&apos;..
        /// </summary>
        internal static string ADP_InvalidKey {
            get {
                return ResourceManager.GetString("ADP_InvalidKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value contains embedded nulls..
        /// </summary>
        internal static string ADP_InvalidValue {
            get {
                return ResourceManager.GetString("ADP_InvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Keyword not supported: &apos;{0}&apos;..
        /// </summary>
        internal static string ADP_KeywordNotSupported {
            get {
                return ResourceManager.GetString("ADP_KeywordNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot convert object of type &apos;{0}&apos; to object of type &apos;{1}&apos;..
        /// </summary>
        internal static string SqlConvert_ConvertFailed {
            get {
                return ResourceManager.GetString("SqlConvert_ConvertFailed", resourceCulture);
            }
        }
    }
}
