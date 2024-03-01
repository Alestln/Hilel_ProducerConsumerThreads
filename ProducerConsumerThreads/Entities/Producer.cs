namespace ProducerConsumerThreads.Entities;

public class Producer
{
    private readonly Buffer _buffer;
    private int _data = 1;

    public Producer(Buffer buffer)
    {
        _buffer = buffer;
    }

    public void ProduceData()
    {
        _buffer.Produce(_data);
        LogData.Log($"Produce data: {_data}");
        Thread.Sleep(Random.Shared.Next(1000));
        _data++;
    }
}