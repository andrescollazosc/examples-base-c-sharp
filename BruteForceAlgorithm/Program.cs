using System.Diagnostics;

public class Program
{
    public delegate bool DelBruteForceAlgo(ref char[] inputs);
    public static void Main(String[] args) {
        var watch = new Stopwatch();
        int tries = 0;
        watch.Start();

        DelBruteForceAlgo testCallback = delegate (ref char[] inputs) {
            var str = new String(inputs);
            Console.WriteLine($"testCallback - {str}");
            tries++;
            return (str == "f71d05c0");
        };

        bool result = BruteForce("01234567abcdef", 1, 8, testCallback);
        watch.Stop();

        Console.WriteLine($"{tries} tries in {watch.ElapsedMilliseconds} ms");
    }

    private static bool BruteForce(string inputs, int startLength, int endLength, DelBruteForceAlgo testCallback)
    {
        for (int len = startLength; len <= endLength; ++len)
        {
            char[] chars = new char[len];

            for (int i = 0; i < len; i++) {
                chars[i] = inputs[0];
            }
            
            if (testCallback(ref chars))
                return true;

            for (int i1 = len - 1; i1 > -1; --i1)
            {
                int i2 = 0;

                for (i2 = inputs.IndexOf(chars[i1]) + 1; i2 < inputs.Length; ++i2)
                {
                    chars[i1] = inputs[i2];
                    if (testCallback(ref chars))
                    {
                        return true;
                    }

                    for (int i3 = i1; i3 < len; ++i3)
                    {
                        if (chars[i3] != inputs[inputs.Length - 1])
                        {
                            i1 = len;
                            goto outerBreak;
                        }
                    }
                }
            outerBreak:
                if (i2 == inputs.Length)
                    chars[i1] = inputs[0];
            }
        }
            
        return false;
    }
}