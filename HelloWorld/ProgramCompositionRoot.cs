namespace HelloWorld
{
  internal static class ProgramCompositionRoot
  {
    public static OutputSalutation GetRoot()
    {
      var salutator = new Salutator();
      var output = new ConsoleAdapter();

      return new OutputSalutation(salutator, output);
    }
  }
}
