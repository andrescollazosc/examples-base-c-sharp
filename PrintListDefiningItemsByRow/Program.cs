public class Program
{
    public static void Main()
    {
        List<object> myList = new List<object>{
            "Object1String",
            true,
            1023931,
            new{ Name = "Object4"},
            "Object5String",
            true,
            1023932,
            new{ Name = "Object8"},
            false
        };

        string s = OutputItems(myList, 3);

        Console.Write(s);
    }

    public static String OutputItems(List<object> myListOfItems, int objectsPerLine)
    {
        string result = "";
        int line = 1;

        for (int i = 0; i < myListOfItems.Count; i++)
        {
            if (i % objectsPerLine == 0)
            {
                result = result + $"\n Line {line}:";
                line++;
            }
            result = result + $" {myListOfItems[i].ToString()}";
        }

        return result;
    }
}