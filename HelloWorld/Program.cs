using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("HelloWorld.Test")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace HelloWorld
{
  internal class Program
  {
    private const int ExitSuccessful = 0;
    private const int ExitUnsuccessful = -1;

    public static int Main()
    {
      try
      {
        ProgramCompositionRoot
          .GetRoot()
          .Execute();

        return ExitSuccessful;
      }
      catch (Exception e)
      {
        Console.WriteLine(e);

        return ExitUnsuccessful;
      }
    }
  }
}
