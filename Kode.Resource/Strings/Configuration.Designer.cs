﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kode.Resource.Strings {
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
    public class Configuration {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Configuration() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Kode.Resource.Strings.Configuration", typeof(Configuration).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration.
        /// </summary>
        public static string ConfigurationSectionName {
            get {
                return ResourceManager.GetString("ConfigurationSectionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to setup.ini.
        /// </summary>
        public static string iniFileName {
            get {
                return ResourceManager.GetString("iniFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KodiIP.
        /// </summary>
        public static string KodiIPKey {
            get {
                return ResourceManager.GetString("KodiIPKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KodiPort.
        /// </summary>
        public static string KodiPortKey {
            get {
                return ResourceManager.GetString("KodiPortKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to txtKodiIP.
        /// </summary>
        public static string txtKodiIPName {
            get {
                return ResourceManager.GetString("txtKodiIPName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to txtKodiPort.
        /// </summary>
        public static string txtKodiPortName {
            get {
                return ResourceManager.GetString("txtKodiPortName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to txtYamahaIP.
        /// </summary>
        public static string txtYamahaIPName {
            get {
                return ResourceManager.GetString("txtYamahaIPName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to YamahaIP.
        /// </summary>
        public static string YamahaIPKey {
            get {
                return ResourceManager.GetString("YamahaIPKey", resourceCulture);
            }
        }
    }
}