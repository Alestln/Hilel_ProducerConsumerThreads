namespace ProducerConsumerThreads.Entities;

public class Consumer
{
    private readonly Buffer _buffer;

    public Consumer(Buffer buffer)
    {
        _buffer = buffer;
    }

    public void ConsumeData()
    {
        if (_buffer.Consume(out var data))
        {
            LogData.Log($"Consume data: {data}");
            Thread.Sleep(Random.Shared.Next(1000));
        }
        else
        {
            // Some logic for waiting result
            // Possible spawn location StackOverflow exception
            Thread.Sleep(500);
            ConsumeData();
        }
    }
}