public class Program
{
    public static void Main(string[] args)
    {
        int logsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> logs = new List<string>();

        for (int i = 0; i < logsCount; i++)
        {
            string logsItem = Console.ReadLine();
            logs.Add(logsItem);
        }

        int threshold = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> result = processLogs(logs, threshold);
    }

    public static List<string> processLogs(List<string> logs, int threshold)
    {
        return null;
    }
}