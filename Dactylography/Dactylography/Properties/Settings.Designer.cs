﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dactylography.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool previewKey {
            get {
                return ((bool)(this["previewKey"]));
            }
            set {
                this["previewKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool previewFinger {
            get {
                return ((bool)(this["previewFinger"]));
            }
            set {
                this["previewFinger"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool wait {
            get {
                return ((bool)(this["wait"]));
            }
            set {
                this["wait"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{\"text\":\"FFF JJFJ JJF JFFJ FFFJ\",\"highScore\":{\"length\":0,\"correct\":0,\"wrong\":-1,\"" +
            "wpm\":0},\"lastScore\":{\"length\":0,\"correct\":0,\"wrong\":-1,\"wpm\":0}}")]
        public string Easy {
            get {
                return ((string)(this["Easy"]));
            }
            set {
                this["Easy"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{\"text\":\"SFČLČFKČAD FASLJČK SJSSJSJD LLALLLK AČČFFJA AJKLFDSAAK ČSDKDSS DSJJDJ JA" +
            "LSLČA JJLJAJ ALSFKSKD SSFLKFČF\",\"highScore\":{\"length\":0,\"correct\":0,\"wrong\":-1,\"" +
            "wpm\":0},\"lastScore\":{\"length\":0,\"correct\":0,\"wrong\":-1,\"wpm\":0}}")]
        public string Moderate {
            get {
                return ((string)(this["Moderate"]));
            }
            set {
                this["Moderate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"{""text"":""EJWGXWC ĆMSŠGAJE ETMPOQ VĐĐPOPTGTF WTFHČŠALACVJNG BUFLCXSHL KĐBIĆNRŽ ĐNAGSS KQKMXSXNĐ ŽSTFJJOTDMQOTVL YQĐBČS ĐWPBLŽQ NCXĐKTDCUJUŽ ZUCYUKČČĐG NIĆBRLL BOWŽŠPDVĆTEZŠ KECGW XPBĐUJSIŽ JHNGGE XŠOZYM UUĆVLHFKGZ"",""highScore"":{""length"":0,""correct"":0,""wrong"":-1,""wpm"":0},""lastScore"":{""length"":0,""correct"":0,""wrong"":-1,""wpm"":0}}")]
        public string Hard {
            get {
                return ((string)(this["Hard"]));
            }
            set {
                this["Hard"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double bestWpm {
            get {
                return ((double)(this["bestWpm"]));
            }
            set {
                this["bestWpm"] = value;
            }
        }
    }
}
