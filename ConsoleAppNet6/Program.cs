using System.Reflection;

namespace ConsoleAppNet6
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Load the net461 assembly dynamically.
      var assembly = Assembly.UnsafeLoadFrom(SharedCode.ClassLibraryNetFx461AssemblyPathResolver.GetPath());

      // Retrieve exported types and call any public methods without arguments.
      var exportedTypes = assembly.GetExportedTypes();
      foreach (var type in exportedTypes)
      {
        Console.WriteLine($"Exported type: '{type.AssemblyQualifiedName}'");

        var staticMethodsWithoutrguments = type
          .GetMethods(BindingFlags.Public | BindingFlags.Static)
          .Where(m => m.GetParameters().Length == 0);
        foreach (var staticMethod in staticMethodsWithoutrguments)
        {
          Console.WriteLine($"  Invoking {staticMethod.Name}: {staticMethod.Invoke(null, null)}");
        }
      }

      Console.ReadLine();
    }
  }
}