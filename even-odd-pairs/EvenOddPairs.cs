namespace even_odd_pairs;

public static class EvenOddPairs
{
    public static bool HasEvenOddPairs(int[] nums)
    {

        if (nums.Length % 2 == 0)
        {
            int countOfEvens = nums.Count(x => x % 2 == 0);

            if (countOfEvens == nums.Length / 2)
                return true;
        }

        return false;
    }
}
