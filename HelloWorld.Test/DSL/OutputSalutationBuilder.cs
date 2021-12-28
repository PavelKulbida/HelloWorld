using HelloWorld.Application;
using Moq;

namespace HelloWorld.Test.DSL
{
  internal class OutputSalutationBuilder
  {
    private string salutation;
    private Mock<IOutput> output;

    public OutputSalutationBuilder WithSalutationString(string value)
    {
      salutation = value;

      return this;
    }

    public OutputSalutationBuilder WithOutputMock(Mock<IOutput> value)
    {
      output = value;

      return this;
    }

    public OutputSalutation Please
    {
      get
      {
        var salutator = new Mock<ISalutator>();
        salutator.Setup(x => x.GetMessage())
          .Returns(salutation);

        return new OutputSalutation(salutator.Object, output.Object);
      }
    }
  }
}
