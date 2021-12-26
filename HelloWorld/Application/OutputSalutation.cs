using ViennaNET.Utils;

namespace HelloWorld.Application
{
  internal class OutputSalutation : IOutputSalutation
  {
    private readonly ISalutator _producer;
    private readonly IOutput _consumer;

    public OutputSalutation(ISalutator producer, IOutput consumer)
    {
      _producer = producer.ThrowIfNull(nameof(producer));
      _consumer = consumer.ThrowIfNull(nameof(consumer));
    }

    public void Execute() => _consumer.Show(_producer.GetMessage());
  }
}
