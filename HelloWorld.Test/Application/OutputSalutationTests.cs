using System;
using HelloWorld.Application;
using HelloWorld.Test.DSL;
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

      var outputMock = Given.OutputMock.Please;

      var outputSalutation = Given.OutputSalutation
        .WithSalutationString(testString)
        .WithOutputMock(outputMock)
        .Please;


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
      var producer = Given.SalutatorMock.Please.Object;
      var consumer =  Given.OutputMock.Please.Object;

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
