using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("HelloWorld.Test")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace HelloWorld
{
  class Program
  {
    public static void Main(string[] args)
    {
      ProgramCompositionRoot
        .GetRoot()
        .Execute();
    }
  }
}
