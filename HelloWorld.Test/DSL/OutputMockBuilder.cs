using HelloWorld.Application;
using Moq;

namespace HelloWorld.Test.DSL
{
  internal class OutputMockBuilder
  {
    public Mock<IOutput> Please => new();
  }
}
