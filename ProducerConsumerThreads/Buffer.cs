using System.Collections.Concurrent;

namespace ProducerConsumerThreads;

public class Buffer
{
    private object _bufferLock = new();
    private ConcurrentQueue<int> _bufferQueue = new();

    public void Produce(int data)
    {
        _bufferQueue.Enqueue(data);
    }
    
    public int Consume()
    {
        int data;
        while (!_bufferQueue.TryDequeue(out data))
        {
            // Some logic for waiting data
        }
        return data;
    }
}