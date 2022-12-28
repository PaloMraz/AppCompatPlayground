using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharedCode
{
  public static class ClassLibraryNetFx461AssemblyPathResolver
  {
    public static string GetPath() =>
      Path.GetFullPath(
        Path.Combine(
          Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
          @"..\..\..\..\ClassLibraryNetFx461\bin\Debug\ClassLibraryNetFx461.dll"));
  }
}
