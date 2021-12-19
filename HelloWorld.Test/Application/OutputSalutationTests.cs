using HelloWorld.Application;
using Moq;
using NUnit.Framework;

namespace HelloWorld.Test.Application
{
  [TestFixture]
  public class OutputSalutationTests
  {
    [Test]
    public void ExecuteTest()
    {
      var testString = "any test string";

      var salutatorStub = new Mock<ISalutator>();
      salutatorStub.Setup(x => x.GetMessage())
        .Returns(testString);

      var outputMock = new Mock<IOutput>();

      var outputSalutation = new OutputSalutation(salutatorStub.Object,
        outputMock.Object);

      
      outputSalutation.Execute();


      outputMock.Verify(x => x.Show(testString));
    }
  }
}
