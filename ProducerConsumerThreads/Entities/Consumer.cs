namespace ProducerConsumerThreads.Entities;

public class Consumer
{
    private Buffer _buffer;

    public Consumer(Buffer buffer)
    {
        _buffer = buffer;
    }

    public void ConsumeData()
    {
        while (true)
        {
            int data = _buffer.Consume();
            LogData.Log($"Consume data: {data}");
            Thread.Sleep(Random.Shared.Next(1000));
        }
    }
}