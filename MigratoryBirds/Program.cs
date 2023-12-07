using Newtonsoft.Json;

public class Program
{
    public static void Main(string []args){
        var a = migratoryBirds(new List<int>{1,4,4,4,5,3});
        Console.WriteLine(a);
    }

    public static int migratoryBirds(List<int> arr)
    {
        var grouped = arr.GroupBy(type => type)
            .Select(g => {
                return new
                {
                    Count = g.Count(),
                    id = g.Key,
                };
            });

        int filtered = grouped.Where(x => x.Count == grouped.Max(row => row.Count)).Min(row => row.id);

        return filtered;
    }
}