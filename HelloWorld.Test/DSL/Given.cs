namespace HelloWorld.Test.DSL
{
  internal static class Given
  {
    public static SalutatorMockBuilder SalutatorMock => new SalutatorMockBuilder();

    public static OutputMockBuilder OutputMock => new OutputMockBuilder();

    public static OutputSalutationBuilder OutputSalutation => new OutputSalutationBuilder();
  }
}
