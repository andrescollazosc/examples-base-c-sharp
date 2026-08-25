using Newtonsoft.Json;
using System.Linq;
using System.Reflection;

class Program
{
    /*
     * Complete the 'climbingLeaderboard' function below.
     * https://www.hackerrank.com/challenges/climbing-the-leaderboard
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY ranked
     *  2. INTEGER_ARRAY player
     */

    public static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player)
    {
        var positionByGame = new List<int>();
        var rankedDistinct = ranked.Distinct().ToList();
        var playerScoresStack = new Stack<int>(player);




        while (playerScoresStack.Count > 0)
        {
            var score = playerScoresStack.Pop();

            var positionToCheck = rankedDistinct.IndexOf(score) + 1;
            if (positionToCheck > 0)
            {
                positionByGame.Add(positionToCheck);
            }
            else
            {
                rankedDistinct.Add(score);

                var rankedOrdered = rankedDistinct.OrderDescending().ToList();
                positionByGame.Add(rankedOrdered.IndexOf(score) + 1);

                rankedDistinct.Remove(score);
            }
        }
        positionByGame.Reverse();
        return positionByGame;
    }

    public static void Main(string[] args)
    {
        var result = ClimbingLeaderboard([100, 90, 90, 80], [70, 80, 105]);
        //var result = ClimbingLeaderboard([100, 100, 50, 40, 40, 20, 10], [5, 25, 50, 120]);
        Console.WriteLine(JsonConvert.SerializeObject(result));
    }

    private int RecursiveBinarySearch(List<int> ranked, int toFind)
    {
        var start = 0;
        var middle = 0;
        var end = 0;

        int result = 0;
        if (toFind >= middle)
        {
            //RecursiveBinarySearch();
        }
        else
        {
            //RecursiveBinarySearch();
        }
        return result;

    }
}