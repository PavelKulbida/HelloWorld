using HelloWorld.Application;
using NUnit.Framework;

namespace HelloWorld.Test.Application
{
  [TestFixture]
  public class SalutatorTests
  {
    [Test]
    public void GetMessageTest()
    {
      var salutator = new Salutator();

      var message = salutator.GetMessage();

      Assert.AreEqual("Hello world", message);
    }
  }
}