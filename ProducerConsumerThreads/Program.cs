using System.Collections.Concurrent;
using ProducerConsumerThreads.Entities;

namespace ProducerConsumerThreads;

class Program
{
    static void Main(string[] args)
    {
        Buffer buffer = new Buffer();
        Producer producer = new Producer(buffer);
        Consumer consumer = new Consumer(buffer);

        /*Thread producerThread = new Thread(producer.ProduceData);
        Thread consumerThread = new Thread(consumer.ConsumeData);
        
        producerThread.Start();
        consumerThread.Start();

        producerThread.Join();
        consumerThread.Join();*/

        List<Thread> producerThreads = new List<Thread>();
        List<Thread> consumerThreads = new List<Thread>();

        for (int i = 0; i < 100; i++)
        {
            producerThreads.Add(new Thread(producer.ProduceData));
            consumerThreads.Add(new Thread(consumer.ConsumeData));
        }
        
        for (int i = 0; i < 100; i++)
        {
            producerThreads[i].Start();
            consumerThreads[i].Start();
            
            producerThreads[i].Join();
            consumerThreads[i].Join();
        }
    }
}