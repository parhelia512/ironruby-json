[assembly: IronRuby.Runtime.RubyLibraryAttribute(typeof(IronRuby.Libraries.Json.JsonLibraryInitializer))]

namespace IronRuby.Libraries.Json {
    public sealed class JsonLibraryInitializer : IronRuby.Builtins.LibraryInitializer {
        protected override void LoadModules() {
            IronRuby.Builtins.RubyClass classRef0 = GetClass(typeof(System.SystemException));
            
            
            ExtendClass(typeof(IronRuby.Builtins.FalseClass), null, LoadIronRuby__Builtins__FalseClass_Instance, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            ExtendClass(typeof(IronRuby.Builtins.Hash), null, LoadIronRuby__Builtins__Hash_Instance, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            ExtendClass(typeof(IronRuby.Builtins.MutableString), null, LoadIronRuby__Builtins__MutableString_Instance, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            ExtendClass(typeof(IronRuby.Builtins.RubyArray), null, LoadIronRuby__Builtins__RubyArray_Instance, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            ExtendClass(typeof(IronRuby.Builtins.TrueClass), null, LoadIronRuby__Builtins__TrueClass_Instance, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            IronRuby.Builtins.RubyModule def3 = DefineGlobalModule("JSON__", typeof(IronRuby.Libraries.Json.JSON), 0x00000103, null, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            IronRuby.Builtins.RubyModule def6 = DefineModule("JSON__::Ext", typeof(IronRuby.Libraries.Json.JSON.Ext), 0x00000103, null, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            IronRuby.Builtins.RubyModule def1 = DefineModule("JSON__::Ext::Generator", typeof(IronRuby.Libraries.Json.JSON.Ext.Generator), 0x00000103, null, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            IronRuby.Builtins.RubyClass def4 = DefineClass("JSON__::JSONError", typeof(IronRuby.Libraries.Json.JSON.BaseException), 0x00000103, classRef0, null, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            ExtendClass(typeof(Microsoft.Scripting.Runtime.DynamicNull), null, LoadMicrosoft__Scripting__Runtime__DynamicNull_Instance, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            ExtendClass(typeof(System.Double), null, LoadSystem__Double_Instance, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            ExtendClass(typeof(System.Int32), null, LoadSystem__Int32_Instance, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            ExtendClass(typeof(System.Object), null, LoadSystem__Object_Instance, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            IronRuby.Builtins.RubyClass def2 = DefineClass("JSON__::Ext::Generator::State", typeof(IronRuby.Libraries.Json.GeneratorState), 0x00000003, Context.ObjectClass, LoadJSON____Ext__Generator__State_Instance, LoadJSON____Ext__Generator__State_Class, null, IronRuby.Builtins.RubyModule.EmptyArray);
            IronRuby.Builtins.RubyClass def10 = DefineClass("JSON__::Ext::Parser", typeof(IronRuby.Libraries.Json.Parser), 0x00000003, Context.ObjectClass, LoadJSON____Ext__Parser_Instance, null, null, IronRuby.Builtins.RubyModule.EmptyArray, 
                new System.Func<IronRuby.Runtime.RespondToStorage, IronRuby.Runtime.RubyScope, IronRuby.Builtins.RubyClass, IronRuby.Builtins.MutableString, IronRuby.Builtins.Hash, IronRuby.Libraries.Json.Parser>(IronRuby.Libraries.Json.JSON.Ext.ParserOps.CreateParser)
            );
            IronRuby.Builtins.RubyClass def7 = DefineClass("JSON__::GeneratorError", typeof(IronRuby.Libraries.Json.JSON.GenerateException), 0x00000103, def4, null, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            IronRuby.Builtins.RubyClass def9 = DefineClass("JSON__::ParserError", typeof(IronRuby.Libraries.Json.JSON.ParserException), 0x00000103, def4, null, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            IronRuby.Builtins.RubyClass def5 = DefineClass("JSON__::CircularDatastructure", typeof(IronRuby.Libraries.Json.JSON.CircularDatastructureException), 0x00000103, def7, null, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            IronRuby.Builtins.RubyClass def8 = DefineClass("JSON__::NestingError", typeof(IronRuby.Libraries.Json.JSON.NestingException), 0x00000103, def9, null, null, null, IronRuby.Builtins.RubyModule.EmptyArray);
            def3.SetConstant("Ext", def6);
            def6.SetConstant("Generator", def1);
            def3.SetConstant("JSONError", def4);
            def1.SetConstant("State", def2);
            def6.SetConstant("Parser", def10);
            def3.SetConstant("GeneratorError", def7);
            def3.SetConstant("ParserError", def9);
            def3.SetConstant("CircularDatastructure", def5);
            def3.SetConstant("NestingError", def8);
        }
        
        private static void LoadIronRuby__Builtins__FalseClass_Instance(IronRuby.Builtins.RubyModule/*!*/ module) {
            module.DefineLibraryMethod("to_json", 0x11, 
                new System.Func<System.Boolean, IronRuby.Libraries.Json.GeneratorState, System.Int32, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.Builtins.FalseOps.ToJson)
            );
            
        }
        
        private static void LoadIronRuby__Builtins__Hash_Instance(IronRuby.Builtins.RubyModule/*!*/ module) {
            module.DefineLibraryMethod("to_json", 0x11, 
                new System.Func<IronRuby.Runtime.ConversionStorage<IronRuby.Builtins.MutableString>, IronRuby.Runtime.RespondToStorage, IronRuby.Runtime.UnaryOpStorage, IronRuby.Runtime.BinaryOpStorage, IronRuby.Runtime.CallSiteStorage<System.Action<System.Runtime.CompilerServices.CallSite, System.Exception, IronRuby.Builtins.RubyArray>>, IronRuby.Runtime.RubyScope, IronRuby.Builtins.Hash, IronRuby.Libraries.Json.GeneratorState, System.Int32, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.Builtins.HashOps.ToJson)
            );
            
        }
        
        private static void LoadIronRuby__Builtins__MutableString_Instance(IronRuby.Builtins.RubyModule/*!*/ module) {
            module.DefineLibraryMethod("to_json", 0x11, 
                new System.Func<IronRuby.Builtins.MutableString, IronRuby.Libraries.Json.GeneratorState, System.Int32, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.Builtins.MutableStringOps.ToJson)
            );
            
            module.DefineLibraryMethod("to_json_raw", 0x11, 
                new System.Func<IronRuby.Runtime.RubyScope, IronRuby.Builtins.MutableString, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.Builtins.MutableStringOps.ToJsonRaw)
            );
            
            module.DefineLibraryMethod("to_json_raw_object", 0x11, 
                new System.Func<IronRuby.Runtime.RubyScope, IronRuby.Builtins.MutableString, IronRuby.Builtins.Hash>(IronRuby.Libraries.Json.Builtins.MutableStringOps.ToJsonRawObject)
            );
            
        }
        
        private static void LoadIronRuby__Builtins__RubyArray_Instance(IronRuby.Builtins.RubyModule/*!*/ module) {
            module.DefineLibraryMethod("to_json", 0x11, 
                new System.Func<IronRuby.Runtime.RespondToStorage, IronRuby.Runtime.UnaryOpStorage, IronRuby.Runtime.BinaryOpStorage, IronRuby.Runtime.CallSiteStorage<System.Action<System.Runtime.CompilerServices.CallSite, System.Exception, IronRuby.Builtins.RubyArray>>, IronRuby.Runtime.RubyScope, IronRuby.Builtins.RubyArray, IronRuby.Libraries.Json.GeneratorState, System.Int32, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.Builtins.ArrayOps.ToJson)
            );
            
        }
        
        private static void LoadIronRuby__Builtins__TrueClass_Instance(IronRuby.Builtins.RubyModule/*!*/ module) {
            module.DefineLibraryMethod("to_json", 0x11, 
                new System.Func<System.Boolean, IronRuby.Libraries.Json.GeneratorState, System.Int32, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.Builtins.TrueOps.ToJson)
            );
            
        }
        
        private static void LoadJSON____Ext__Generator__State_Instance(IronRuby.Builtins.RubyModule/*!*/ module) {
            module.DefineLibraryMethod("array_nl", 0x11, 
                new System.Func<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.GetArrayNl)
            );
            
            module.DefineLibraryMethod("array_nl=", 0x11, 
                new System.Action<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.SetArrayNl)
            );
            
            module.DefineLibraryMethod("check_circular?", 0x11, 
                new System.Func<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, System.Boolean>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.GetCheckCircular)
            );
            
            module.DefineLibraryMethod("configure", 0x11, 
                new System.Func<IronRuby.Libraries.Json.GeneratorState, IronRuby.Builtins.Hash, IronRuby.Libraries.Json.GeneratorState>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.Reconfigure)
            );
            
            module.DefineLibraryMethod("forget", 0x11, 
                new System.Func<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, System.Object, System.Object>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.AForget)
            );
            
            module.DefineLibraryMethod("indent", 0x11, 
                new System.Func<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.GetIndent)
            );
            
            module.DefineLibraryMethod("indent=", 0x11, 
                new System.Action<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.SetIndent)
            );
            
            module.DefineLibraryMethod("initialize", 0x12, 
                new System.Func<IronRuby.Libraries.Json.GeneratorState, IronRuby.Builtins.Hash, IronRuby.Libraries.Json.GeneratorState>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.Reinitialize)
            );
            
            module.DefineLibraryMethod("max_nesting", 0x11, 
                new System.Func<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, System.Int32>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.GetMaxNesting)
            );
            
            module.DefineLibraryMethod("max_nesting=", 0x11, 
                new System.Action<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, System.Int32>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.SetMaxNesting)
            );
            
            module.DefineLibraryMethod("object_nl", 0x11, 
                new System.Func<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.GetObjectNl)
            );
            
            module.DefineLibraryMethod("object_nl=", 0x11, 
                new System.Action<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.SetObjectNl)
            );
            
            module.DefineLibraryMethod("remember", 0x11, 
                new System.Func<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, System.Object, System.Boolean>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.ARemember)
            );
            
            module.DefineLibraryMethod("seen?", 0x11, 
                new System.Func<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, System.Object, System.Object>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.ASeen)
            );
            
            module.DefineLibraryMethod("space", 0x11, 
                new System.Func<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.GetSpace)
            );
            
            module.DefineLibraryMethod("space_before", 0x11, 
                new System.Func<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.GetSpaceBefore)
            );
            
            module.DefineLibraryMethod("space_before=", 0x11, 
                new System.Action<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.SetSpaceBefore)
            );
            
            module.DefineLibraryMethod("space=", 0x11, 
                new System.Action<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.SetSpace)
            );
            
            module.DefineLibraryMethod("to_h", 0x11, 
                new System.Func<IronRuby.Runtime.RubyContext, IronRuby.Libraries.Json.GeneratorState, IronRuby.Builtins.Hash>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.ToHash)
            );
            
        }
        
        private static void LoadJSON____Ext__Generator__State_Class(IronRuby.Builtins.RubyModule/*!*/ module) {
            module.DefineLibraryMethod("from_state", 0x21, 
                new System.Func<IronRuby.Runtime.RubyContext, IronRuby.Builtins.RubyModule, System.Object, IronRuby.Libraries.Json.GeneratorState>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.FromState)
            );
            
            module.DefineLibraryMethod("new", 0x21, 
                new System.Func<IronRuby.Builtins.RubyClass, IronRuby.Builtins.Hash, IronRuby.Libraries.Json.GeneratorState>(IronRuby.Libraries.Json.JSON.Ext.Generator.GeneratorStateOps.CreateGeneratorState)
            );
            
        }
        
        private static void LoadJSON____Ext__Parser_Instance(IronRuby.Builtins.RubyModule/*!*/ module) {
            module.DefineLibraryMethod("parse", 0x11, 
                new System.Func<IronRuby.Runtime.RespondToStorage, IronRuby.Runtime.UnaryOpStorage, IronRuby.Runtime.BinaryOpStorage, IronRuby.Runtime.CallSiteStorage<System.Action<System.Runtime.CompilerServices.CallSite, System.Exception, IronRuby.Builtins.RubyArray>>, IronRuby.Runtime.RubyScope, IronRuby.Libraries.Json.Parser, System.Object>(IronRuby.Libraries.Json.JSON.Ext.ParserOps.Parse)
            );
            
        }
        
        private static void LoadMicrosoft__Scripting__Runtime__DynamicNull_Instance(IronRuby.Builtins.RubyModule/*!*/ module) {
            module.DefineLibraryMethod("to_json", 0x11, 
                new System.Func<Microsoft.Scripting.Runtime.DynamicNull, IronRuby.Libraries.Json.GeneratorState, System.Int32, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.Builtins.DynamicNullOps.ToJson)
            );
            
        }
        
        private static void LoadSystem__Double_Instance(IronRuby.Builtins.RubyModule/*!*/ module) {
            module.DefineLibraryMethod("to_json", 0x11, 
                new System.Func<System.Double, IronRuby.Libraries.Json.GeneratorState, System.Int32, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.Builtins.FloatOps.ToJson)
            );
            
        }
        
        private static void LoadSystem__Int32_Instance(IronRuby.Builtins.RubyModule/*!*/ module) {
            module.DefineLibraryMethod("to_json", 0x11, 
                new System.Func<System.Int32, IronRuby.Libraries.Json.GeneratorState, System.Int32, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.Builtins.FixnumOps.ToJson)
            );
            
        }
        
        private static void LoadSystem__Object_Instance(IronRuby.Builtins.RubyModule/*!*/ module) {
            module.DefineLibraryMethod("to_json", 0x11, 
                new System.Func<IronRuby.Runtime.RespondToStorage, IronRuby.Runtime.UnaryOpStorage, IronRuby.Runtime.BinaryOpStorage, IronRuby.Runtime.CallSiteStorage<System.Action<System.Runtime.CompilerServices.CallSite, System.Exception, IronRuby.Builtins.RubyArray>>, IronRuby.Runtime.RubyScope, System.Object, IronRuby.Libraries.Json.GeneratorState, System.Int32, IronRuby.Builtins.MutableString>(IronRuby.Libraries.Json.Builtins.ObjectOps.ToJson)
            );
            
        }
        
    }
}