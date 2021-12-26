using System;
using HelloWorld.Application;
using Moq;
using NUnit.Framework;

namespace HelloWorld.Test.Application
{
  [TestFixture]
  internal class OutputSalutationTests
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

    [Test]
    [TestCaseSource(nameof(NullableParameters), new object[] { nameof(ConstructorExeptionTest) })]
    public void ConstructorExeptionTest(ISalutator producer, IOutput consumer)
    {
      Assert.Throws<ArgumentNullException>(() =>
      {
        _ = new OutputSalutation(producer, consumer);
      });
    }

    private static TestCaseData[] NullableParameters(string testMethodName)
    {
      var producer = new Mock<ISalutator>().Object;
      var consumer = new Mock<IOutput>().Object;

      return new[]
      {
        new TestCaseData(new object[] { null, null })
          .SetName($"{testMethodName}(null, null)"),
        new TestCaseData(new object[] { null, consumer })
          .SetName($"{testMethodName}(null, value)"), 
        new TestCaseData(new object[] { producer, null})
          .SetName($"{testMethodName}(value, null)")
      };
    }
  }
}
