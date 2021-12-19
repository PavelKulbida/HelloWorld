namespace HelloWorld
{
  class Program
  {
    public static void Main(string[] args)
    {
      var salutator = new Salutator();
      var output = new ConsoleAdapter();

      var message = salutator.GetMessage();
      output.Show(message);
    }
  }
}
