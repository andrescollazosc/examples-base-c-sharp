using swap_nodes_algo;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args) {
        Node root = new Node
        {
            Value = 1,
            Left = new Node
            {
                Value = 2,
                Right = new Node
                {
                    Value = 4,
                }
            },
            Right = new Node
            {
                Value = 3,
                Right = new Node
                {
                    Value = 5
                }
            }
        };

        List<List<int>> indexes = new List<List<int>> {
            new List<int> { 2, 3 },
            new List<int> { 4, -1 },
            new List<int> { 5, -1 },
            new List<int> { 6, -1 },
            new List<int> { 7, 8 },
            new List<int> { -1, 9 },
            new List<int> { -1, -1 },
            new List<int> { 10, 11 },
            new List<int> { -1, -1 },
            new List<int> { -1, -1 },
            new List<int> { -1, -1 },
        };
        Console.WriteLine("Indexes: " + JsonSerializer.Serialize(indexes) + "\n");

        List<int> queries = new List<int> { 2, 4 };
        Console.WriteLine("Queries:");
        Console.WriteLine(queries.Count);
        Console.WriteLine(JsonSerializer.Serialize(queries) + "\n");

        var a = SwapNodes(indexes, queries);
    }

    /// <summary>
    /// https://www.hackerrank.com/challenges/swap-nodes-algo/problem
    /// </summary>
    /// <param name="indexes"></param>
    /// <param name="queries"></param>
    /// <returns>Two-dimensional array where each element is an array of integers representing the node indices of an in-order traversal after a swap operation.</returns>
    public static List<List<int>> SwapNodes(List<List<int>> indexes, List<int> queries)
    {
        
        int h = 1;

        List<List<List<int>>> tree = new List<List<List<int>>>();


        int counterByLevel = 1;

        for (int j = 1; j <= counterByLevel; j++) {
            var level = new List<List<int>>();

            level.AddRange(indexes.Take(counterByLevel));
            tree.Add(level);

            Console.WriteLine(JsonSerializer.Serialize(level));

            if (indexes.Count >= counterByLevel)
            {
                indexes.RemoveRange(0, counterByLevel);
                
            }
            else
            {
                break;
            }

            counterByLevel = counterByLevel * 2;
        }



        Console.WriteLine("Depth");
        Console.WriteLine(JsonSerializer.Serialize(h));

        return null;
    }

}