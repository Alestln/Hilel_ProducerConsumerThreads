using System.Collections.Concurrent;

namespace ProducerConsumerThreads;

public class Buffer
{
    private readonly ConcurrentQueue<int> _bufferQueue = new();

    public void Produce(int data)
    {
        _bufferQueue.Enqueue(data);
    }
    
    public bool Consume(out int data)
    {
        return _bufferQueue.TryDequeue(out data);
    }
}