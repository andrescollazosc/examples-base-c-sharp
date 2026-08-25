using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class Program
{
    public static async Task Main()
    {
        HttpClient client = new HttpClient();
        string s = await client.GetStringAsync("https://coderbyte.com/api/challenges/json/json-cleaning");
        Console.WriteLine(s);
        Console.WriteLine(CleanJson(s));
    }

    public static string CleanJson(string originalJson)
    {
        JObject jsonObject = JObject.Parse(originalJson);

        RemoveMarkedProperties(jsonObject);

        return JsonConvert.SerializeObject(jsonObject);
    }

    private static void RemoveMarkedProperties(JObject obj)
    {

        foreach (var prop in obj.Properties().ToList())
        {

            if (prop.Value.Type == JTokenType.Object)
            {
                RemoveMarkedProperties((JObject)prop.Value);
            }
            else if (prop.Value.Type == JTokenType.Array)
            {
                JArray array = (JArray)prop.Value;
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i].Type == JTokenType.Object)
                    {
                        RemoveMarkedProperties((JObject)array[i]);
                    }
                }
            }
            else if (string.IsNullOrEmpty(prop.Value.ToString()) || prop.Value.ToString() == string.Empty
            || prop.Value.ToString() == "" || prop.Value.ToString().Equals("-") || prop.Value.ToString().Equals("N/A"))
            {
                prop.Remove();
            }

        }

    }

}

