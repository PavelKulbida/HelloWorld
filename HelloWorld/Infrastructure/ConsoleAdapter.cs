using System;
using HelloWorld.Application;

namespace HelloWorld.Infrastructure
{
  internal class ConsoleAdapter : IOutput
  {
    public void Show(string message)
    {
      Console.WriteLine(message);
    }
  }
}
