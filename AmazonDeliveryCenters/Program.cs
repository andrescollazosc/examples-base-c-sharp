using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        //var a = suitableLocations(new List<int> { 2, 0, 3, -4 }, 22);
        //var a = suitableLocations(new List<int> { -2, 1, 0 }, 8);
        var a = suitableLocations(new List<int> { -1, 0, 1 }, 8);
        Console.WriteLine(JsonSerializer.Serialize(a));
    }
    public static int suitableLocations(List<int> center, long d)
    {
        List<int> organizedList = new List<int>();
        organizedList.AddRange(center);
        organizedList.Sort();
        int suitableCenters = 0;

        for (int x = organizedList[0]; x <= organizedList.Max(); x++)
        {
            int formula = 0;
            for (int i = 0; i < center.Count; i++)
            {
                formula += 2 * Math.Abs(x - center[i]);
            }

            if (formula <= d)
            {
                suitableCenters++;
            }
        }

        return suitableCenters;
    }
}
