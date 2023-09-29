using System.Diagnostics;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        int queriesRows = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<string>> queries = new List<List<string>>();

        for (int i = 0; i < queriesRows; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
        }

        Stopwatch sw = new Stopwatch();
        sw.Start();
        List<int> result = contacts(queries);
        sw.Stop();
        Console.Write(JsonSerializer.Serialize(result));
        Console.WriteLine("This task took: "+ sw.ElapsedMilliseconds/1000 +" Seconds");
    }

    public static List<int> contacts(List<List<string>> queries)
    {

        //List<string> contacts = new List<string>();
        Dictionary<string,int> contacts = new Dictionary<string,int>();

        List<int> result = new List<int>();

        queries.ForEach(query => { 
            switch (query[0]) {
                case "add":
                    //contacts.Add(query[1]);
                    if (contacts.ContainsKey(query[1]))
                    {
                        contacts[query[1]]++;
                    }
                    else
                    {
                        contacts[query[1]] = 1;
                    }
                    break;
                case "find":
                    //var a = contacts.FindAll(x => x.StartsWith(query[1])).Count;
                    int count = 0;
                    foreach (var contact in contacts.Keys)
                    {
                        if (contact.StartsWith(query[1]))
                        {
                            count += contacts[contact];
                        }
                    }
                    //result.Add(a);
                    result.Add(count);
                    break;
            }
        });

        return result;
    }
}