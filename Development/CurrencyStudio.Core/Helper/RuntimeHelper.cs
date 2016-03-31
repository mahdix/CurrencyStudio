using System;
using System.Collections;
using System.Reflection;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using Microsoft.CSharp;
using System.Resources;
using System.IO;
using CurrencyStudio.Core.RuntimeSystem;

namespace CurrencyStudio.Core.Helper
{
    public static class RuntimeHelper
    {
        static RuntimeHelper()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
        }

        //key is assemblyfile and value is object extarcted from assembly
        private static Hashtable objectCache = new Hashtable();

        public static RuntimeResult GetObjectInstance(string cacheId, string codeParameter, Type interfaceType, List<string> referencedAssemblies)
        {
            return GetObjectInstance(cacheId, codeParameter, "",true, interfaceType, referencedAssemblies);
        }

        public static RuntimeResult GetObjectInstance(string cacheId,string codeParameter,string codeFolder, bool isInlineCode,Type interfaceType,List<string> referencedAssemblies)
        {
            if ( objectCache[cacheId] == null )
            {
                RuntimeResult result = null;

                if ( isInlineCode )
                {
                    result = CompileCode(codeParameter,interfaceType,referencedAssemblies);
                }
                else
                {
                    result = LoadObjectFromAssembly(codeParameter, codeFolder, interfaceType, referencedAssemblies);
                }

                if (result.Success == false)
                {
                    return result;
                }

                objectCache[cacheId] = result.CreatedObject;
            }

            RuntimeResult cr = new RuntimeResult();
            cr.Success = true;
            cr.CreatedObject = objectCache[cacheId];

            return cr;
        }

        private static RuntimeResult CompileCode(string code,Type interfaceType,List<string> referenceAssemblies)
        {
            RuntimeResult result = new RuntimeResult();
            
            CompilerParameters CompilerParams = new CompilerParameters();

            CompilerParams.GenerateInMemory = true;
            CompilerParams.TreatWarningsAsErrors = false;
            CompilerParams.GenerateExecutable = false;
            CompilerParams.CompilerOptions = "/optimize";

            string[] references = { "System.dll", "mscorlib.dll", "System.Xml.dll", "CurrencyStudio.Core.dll" };
            CompilerParams.ReferencedAssemblies.AddRange(references);

            foreach (string assemblyName in referenceAssemblies)
            {
                string path = Path.Combine(FileUtils.AppFolder, Def.CommonLibFolder);
                path = Path.Combine(path, assemblyName);

                CompilerParams.ReferencedAssemblies.Add(path);
            }

            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerResults compile = provider.CompileAssemblyFromSource(CompilerParams, code);

            if (compile.Errors.HasErrors)
            {
                string text = "Compile error: ";

                foreach (CompilerError ce in compile.Errors)
                {
                    text += "rn" + ce.ToString();
                }
                result.Success = false;
                result.ErrorMessage = text;
                return result;
            }

            result.CreatedObject = Utils.RuntimeCreateObject(interfaceType, compile.CompiledAssembly);
            result.Success = true;

            return result;
        }

        //for custom assemblies we need to load assembly and read the object we need
        private static RuntimeResult LoadObjectFromAssembly(string assemblyFile,string assemblyFolder, Type interfaceType,List<string> referenceAssemblies)
        {
            string path = Path.Combine(FileUtils.AppFolder, assemblyFolder);
            path = Path.Combine(path,assemblyFile);

            
            //TODO: handle common lib here
            Assembly objectLib = Assembly.LoadFile(path);

            object result = Utils.RuntimeCreateObject(interfaceType, objectLib);

            RuntimeResult cr = new RuntimeResult();
            cr.Success = (result != null);
            cr.CreatedObject = result;

            return cr;
        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            if (RuntimeManager.HasInstance() == false) return null;

            string dllName = new AssemblyName(args.Name).Name + ".dll";

            //args.Name
            if (RuntimeManager.GetInstance().CommonLibraries.Contains(dllName))
            {
                string path = Path.Combine(FileUtils.AppFolder, Def.CommonLibFolder);
                path = Path.Combine(path, dllName);

                return Assembly.LoadFile(path);
            }

            return null;
        }

        public static string GetDefaultSignalDefinitionCode()
        {
            return Utils.LoadResource("CurrencyStudio.Core.Helper.RuntimeTemplates.SignalTemplate.cs");
        }

        public static string GetDefaultExpertPredicateCode()
        {
            return Utils.LoadResource("CurrencyStudio.Core.Helper.RuntimeTemplates.ExpertPredicateTemplate.cs");
        }

        public static string GetDefaultExpertCode()
        {
            return Utils.LoadResource("CurrencyStudio.Core.Helper.RuntimeTemplates.ExpertTemplate.cs");
        }

        public static string GetDefaultPortfolioManagerCode()
        {
            return Utils.LoadResource("CurrencyStudio.Core.Helper.RuntimeTemplates.PortfolioManagerTemplate.cs");
        }

        public static void ResetObjectCache()
        {
            objectCache.Clear();
        }
    }

    public class RuntimeResult
    {
        public bool Success = true;
        public string ErrorMessage = "";
        public object CreatedObject = null;
    }
}
