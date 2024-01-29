using System.Globalization;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        int aCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = new List<int>();

        for (int i = 0; i < aCount; i++)
        {
            int aItem = Convert.ToInt32(Console.ReadLine().Trim());
            a.Add(aItem);
        }

        List<decimal> result = runningMedian(a);

        Console.WriteLine(JsonSerializer.Serialize(result));
    }

    public static List<decimal> runningMedian(List<int> a)
    {
        List<decimal> medians = new List<decimal>();
        List<int> ordered = new List<int>();

        for (int i = 0; i < a.Count; i++)
        {
            ordered.Add(a[i]);
            ordered.Sort();
            if (ordered.Count == 1)
            {
                decimal myDecimal1 = a[i] + 0.0m;
                medians.Add(myDecimal1);
            } else if (ordered.Count == 2) 
            {
                decimal myDecimal2 = (ordered[0] + ordered[1]) / 2.0m;
                medians.Add(myDecimal2 + 0.0m);
            } else if (ordered.Count > 2)
            {
                int middle = ordered.Count / 2;
                if (ordered.Count % 2 == 0)
                {
                    //Tome los dos de la mitad
                    decimal first = ordered[middle - 1];
                    decimal second = ordered[middle];
                    decimal myDecimal3 = (first + second) / 2.0m;
                    medians.Add(myDecimal3 + 0.0m);
                }
                else
                {
                    //Tome el de la mitad
                    medians.Add(ordered[middle] + 0.0m);
                }
            }
        } 

        return medians;
    }
}
