using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryNetFx461
{
  public class Class1
  {
    public static string GetVersion() =>
      $".NET Runtime: '{System.Environment.Version}', System.Object: '{typeof(object).AssemblyQualifiedName}'";
  }
}
