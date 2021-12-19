using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("HelloWorld.Test")]

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
