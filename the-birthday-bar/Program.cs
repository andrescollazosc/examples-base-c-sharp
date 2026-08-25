public class Program
{
    public static void Main(string[] args){

        // https://www.hackerrank.com/challenges/the-birthday-bar/
        Console.WriteLine(birthday(new List<int>{2,2,1,3,2}, 4, 2));
    }

    public static int birthday(List<int> s, int d, int m)
    {
        int counter = 0;

        Queue<int> s_queue = new Queue<int>(s);
        while(s_queue.Count > 0){
            var resSum = s_queue.Take(m).Sum();
            
            if(resSum == d){
                counter++;
            }

            s_queue.Dequeue();
        }

        return counter;
    }
}