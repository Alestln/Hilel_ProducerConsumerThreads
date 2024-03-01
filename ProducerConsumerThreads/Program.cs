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

        Thread producerThread = new Thread(producer.ProduceData);
        Thread consumerThread = new Thread(consumer.ConsumeData);

        producerThread.Start();
        consumerThread.Start();

        producerThread.Join();
        consumerThread.Join();
    }
}