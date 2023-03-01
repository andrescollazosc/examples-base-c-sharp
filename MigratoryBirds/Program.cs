using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main(string []args){
        var a = migratoryBirds(new List<int>{1,4,4,4,5,3});
    }

    public static int migratoryBirds(List<int> arr)
    {
        var orderedArr = arr.OrderBy(x => x);

        int countByType = 0;
        for (int i = 0; i < orderedArr - 1; i++)
        {
            if (orderedArr[i] == orderedArr[i+1])
            {
                countByType++;
            }
        }

        return 0;
    }
}