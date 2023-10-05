public class Program
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int logsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> logs = new List<string>();

        for (int i = 0; i < logsCount; i++)
        {
            string logsItem = Console.ReadLine();
            logs.Add(logsItem);
        }

        int threshold = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> result = Result.processLogs(logs, threshold);

        //textWriter.WriteLine(String.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();
    }

    class Result
    {

        /*
         * Complete the 'processLogs' function below.
         *
         * The function is expected to return a STRING_ARRAY.
         * The function accepts following parameters:
         *  1. STRING_ARRAY logs
         *  2. INTEGER threshold
         */

        public static List<string> processLogs(List<string> logs, int threshold)
        {
            return null;
        }

    }
}