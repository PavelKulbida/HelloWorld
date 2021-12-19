using HelloWorld.Application;
using HelloWorld.Infrastructure;

namespace HelloWorld
{
  internal static class ProgramCompositionRoot
  {
    public static IOutputSalutation GetRoot()
    {
      var salutator = new Salutator();
      var output = new ConsoleAdapter();

      return new OutputSalutation(salutator, output);
    }
  }
}
