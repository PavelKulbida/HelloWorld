using HelloWorld.Application;
using Moq;

namespace HelloWorld.Test.DSL
{
  internal class SalutatorMockBuilder
  {
    public Mock<ISalutator> Please => new();
  }
}
