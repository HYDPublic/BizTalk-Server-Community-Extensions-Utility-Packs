﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BizTalk.CustomAdvanced.Functoids {
    using System;
    
    
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
    internal class CustomAdvancedResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CustomAdvancedResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BizTalk.CustomAdvanced.Functoids.CustomAdvancedResources", typeof(CustomAdvancedResources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IDS_DEFAULTVALUEMAPFUNCTOID_BITMAP {
            get {
                object obj = ResourceManager.GetObject("IDS_DEFAULTVALUEMAPFUNCTOID_BITMAP", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use the Default Value Mapping functoid to return a value from one of two input parameters. If the value of the first input parameter is Null or Empty, then the value of the second input parameter is returned, otherwise the first input is returned. This functoid requires two input parameters..
        /// </summary>
        internal static string IDS_DEFAULTVALUEMAPFUNCTOID_DESCRIPTION {
            get {
                return ResourceManager.GetString("IDS_DEFAULTVALUEMAPFUNCTOID_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default Value Mapping.
        /// </summary>
        internal static string IDS_DEFAULTVALUEMAPFUNCTOID_NAME {
            get {
                return ResourceManager.GetString("IDS_DEFAULTVALUEMAPFUNCTOID_NAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This functoid must have exactly 2 input parameters.
        /// </summary>
        internal static string IDS_DEFAULTVALUEMAPFUNCTOID_TOOLTIP {
            get {
                return ResourceManager.GetString("IDS_DEFAULTVALUEMAPFUNCTOID_TOOLTIP", resourceCulture);
            }
        }
    }
}
