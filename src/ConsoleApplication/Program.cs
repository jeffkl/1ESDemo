using System;
using System.Reflection;
using System.Runtime.Loader;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Assembly assembly1 = AssemblyLoadContext.Default.LoadFromAssemblyPath(@"D:\msbuild\bin\Bootstrap-NetCore\NuGet.Versioning.dll");
            Assembly assembly2 = System.Runtime.Loader.AssemblyLoadContext.Default.LoadFromAssemblyPath(@"D:\msbuild\bin\Bootstrap-NetCore\NuGet.Versioning.dll");
        }
    }
}
