namespace HelloWorld
{
  internal class OutputSalutation : IOutputSalutation
  {
    private readonly ISalutator _producer;
    private readonly IOutput _consumer;

    public OutputSalutation(ISalutator producer, IOutput consumer)
    {
      _producer = producer;
      _consumer = consumer;
    }

    public void Execute() => _consumer.Show(_producer.GetMessage());
  }
}
