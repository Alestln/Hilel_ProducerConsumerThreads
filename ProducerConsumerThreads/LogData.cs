namespace ProducerConsumerThreads;

public class LogData
{
    private static string _filePath = "log.txt";
    private static object locker = new();

    public static void Log (string message)
    {
        lock (locker)
        {
            using var filestream = new FileStream(_filePath, FileMode.Append);
            using var streamWriter = new StreamWriter(filestream);
        
            streamWriter.WriteLine(message);
        }
    }
}