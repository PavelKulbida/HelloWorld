namespace HelloWorld
{
  internal class OutputSalutation
  {
    private readonly Salutator _producer;
    private readonly ConsoleAdapter _consumer;

    public OutputSalutation(Salutator producer, ConsoleAdapter consumer)
    {
      _producer = producer;
      _consumer = consumer;
    }

    public void Execute() => _consumer.Show(_producer.GetMessage());
  }
}
