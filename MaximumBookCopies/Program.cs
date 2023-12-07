using System.Text.Json;

public class Program
{
    public static void Main(string[] args) {
        var a = maximumBookCopies(new List<int> {4,6,-6,6,-6});
        Console.WriteLine(JsonSerializer.Serialize(a));
    }
    public static List<int> maximumBookCopies(List<int> portalUpdate)
    {
        List<int> inventory = new List<int>();
        List<int> numberOfCopies = new List<int>();

        for (int i = 0; i < portalUpdate.Count; i++) {
            if (portalUpdate[i] > 0) {
                inventory.Add(portalUpdate[i]);
            }
            else
            {
                if (inventory.Contains(Math.Abs(portalUpdate[i])))
                {
                    inventory.Remove(Math.Abs(portalUpdate[i]));
                }
            }

            //Cuantas copias quedaron de cada libro luego del update
            var a = inventory.GroupBy(id => id)
                .Select(g => {
                    return new
                    {
                        Count = g.Count(),
                        id = g.Key,
                    };
                });

            numberOfCopies.Add(a.Max(x=>x.Count));
        }

        Console.WriteLine(JsonSerializer.Serialize(numberOfCopies));

        return numberOfCopies;
    }
}