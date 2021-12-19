using NUnit.Framework;

namespace HelloWorld.Test
{
  [TestFixture]
  public class ProgramCompositionRootTests
  {
    [Test]
    public void GetRootTest()
    {
      var root = ProgramCompositionRoot.GetRoot();

      Assert.Multiple(() =>
      {
        Assert.IsNotNull(root);
        Assert.IsInstanceOf<IOutputSalutation>(root);
      });
    }
  }
}
