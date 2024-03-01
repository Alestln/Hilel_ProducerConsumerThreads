namespace ProducerConsumerThreads;

public static class LogData
{
    private const string FilePath = "log.txt";
    private static readonly object Locker = new();

    public static void Log (string message)
    {
        lock (Locker)
        {
            using var filestream = new FileStream(FilePath, FileMode.Append);
            using var streamWriter = new StreamWriter(filestream);
            
            streamWriter.WriteLine(message);
        }
    }
}