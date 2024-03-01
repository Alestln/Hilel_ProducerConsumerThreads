namespace ProducerConsumerThreads.Entities;

public class Producer
{
    private Buffer _buffer;

    public Producer(Buffer buffer)
    {
        _buffer = buffer;
    }

    public void ProduceData()
    {
        int count = 1;
        while (true)
        {
            //int data = Random.Shared.Next(100);
            int data = count;
            _buffer.Produce(data);
            LogData.Log($"Produce data: {data}");
            Thread.Sleep(Random.Shared.Next(1000));
            count++;
        }
    }
}