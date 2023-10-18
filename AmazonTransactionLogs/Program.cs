using System.Text.Json;

// https://www.hackerrank.com/test/63ek10mhil5/60d306ab105867d80fca544041154273

public class Program
{
    public static void Main(string[] args)
    {
        var logs = new List<string> { "1 2 50", "1 7 70", "1 3 20", "2 2 17" };

        int threshold = 2;

        List<string> result = ProcessLogs(logs, threshold);

        Console.WriteLine(JsonSerializer.Serialize(result));
    }

    /// <summary>
    /// Receive a list of transactions to calculate the id's that have more than a threshold transactions
    /// </summary>
    /// <param name="logs"></param>
    /// <param name="threshold"></param>
    /// <returns>A list of id's that have more than a threshold transactions</returns>
    public static List<string> ProcessLogs(List<string> logs, int threshold)
    {
        List<string> resultIds = new List<string>();
        
        logs.ForEach(log =>
        {
            var arrDataBylog = log.Split(" ");

            string sender_user_id = arrDataBylog[0];
            string recipient_user_id = arrDataBylog[1];

            if (sender_user_id == recipient_user_id)
            {
                resultIds.Add(sender_user_id);
            }
            else
            {
                resultIds.Add(sender_user_id);
                resultIds.Add(recipient_user_id);
            }
        });

        var grouped = resultIds.GroupBy(id => id)
            .Select(g => {
                return new
                {
                    Count = g.Count(),
                    id = g.Key,
                };
            });

        List<string> finalIds = new List<string>();
        foreach (var keyValue in grouped)
        {
            if (keyValue.Count>=threshold)
            {
                finalIds.Add(keyValue.id);
            }
        }
        finalIds.Sort();

        return finalIds;
    }
}