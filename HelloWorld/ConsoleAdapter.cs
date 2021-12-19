using System;

namespace HelloWorld
{
  internal class ConsoleAdapter : IOutput
  {
    public void Show(string message)
    {
      Console.WriteLine(message);
    }
  }
}
