using HelloWorld.Application;
using HelloWorld.Infrastructure;
using SimpleInjector;

namespace HelloWorld
{
  internal static class ProgramCompositionRoot
  {
    private static readonly Container ProgramContainer = new Container();

    static ProgramCompositionRoot()
    {
      ProgramContainer.Register<ISalutator, Salutator>(Lifestyle.Singleton);
      ProgramContainer.Register<IOutput, ConsoleAdapter>(Lifestyle.Singleton);
      ProgramContainer.Register<IOutputSalutation, OutputSalutation>(Lifestyle.Singleton);

      ProgramContainer.Verify();
    }

    public static IOutputSalutation Root => ProgramContainer.GetInstance<IOutputSalutation>();
  }
}
