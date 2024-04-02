public class Program {

    public static void Main(string[] args) {
        var result = CatAndMouse(1,2,3);
        Console.WriteLine(result);
    }
    static string CatAndMouse(int x, int y, int z)
    {
        var catAdistance = Math.Abs(z - x);
        var catBdistance = Math.Abs(z - y);
        if (catAdistance < catBdistance)
        {
            return "Cat A";
        }
        else if (catBdistance < catAdistance)
        {
            return "Cat B";
        }
        else
            return "Mouse C";

    }
}
