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
        if (_bufferQueue.TryDequeue(out data))
        {
            return data;
        }
        return -1; // Return a sentinel value if the queue is empty
    }
}