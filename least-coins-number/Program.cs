using System;

class Program
{
    
    
    public static int[] CoinDeterminer(int num)
    {
        int[] coins = { 1, 5, 7, 9, 11 };
        if (num < 0) return null;
        if (num == 0) return new int[coins.Length];

        int[] dp = new int[num + 1];
        int[] lastCoin = new int[num + 1];

        for (int i = 1; i <= num; i++)
        {
            dp[i] = int.MaxValue / 2;
            lastCoin[i] = -1;
        }

        dp[0] = 0;

        for (int i = 1; i <= num; i++)
        {
            for (int c = 0; c < coins.Length; c++)
            {
                int coin = coins[c];
                if (coin <= i && dp[i - coin] + 1 < dp[i])
                {
                    dp[i] = dp[i - coin] + 1;
                    lastCoin[i] = c;
                }
            }
        }

        if (lastCoin[num] == -1) return null;

        int[] counts = new int[coins.Length];
        int cur = num;
        while (cur > 0)
        {
            int idx = lastCoin[cur];
            if (idx < 0) break;
            counts[idx]++;
            cur -= coins[idx];
        }

        return counts;
    }

    static void Main()
    {
        Init();
    }

    static void Init()
    {
        Console.WriteLine("Please type the value, and I can show you how much coins of 1, 5, 7, 9, and 11 do you need.");
        if (!int.TryParse(Console.ReadLine(), out int value))
        {
            Console.WriteLine("Input not valid. Try again.");
            Console.WriteLine("Once again?. Press Y or y");
            var contErr = Console.ReadLine();
            if (contErr == "Y" || contErr == "y") Init();
            return;
        }

        var counts = CoinDeterminer(value);
        if (counts == null)
        {
            Console.WriteLine("No se encontró una combinación de monedas para esa cantidad.");
        }
        else
        {
            int[] coins = { 1, 5, 7, 9, 11 };
            var parts = new System.Collections.Generic.List<string>();
            for (int i = coins.Length - 1; i >= 0; i--)
            {
                int cnt = counts[i];
                if (cnt <= 0) continue;
                string moneda = cnt == 1 ? "una moneda" : $"{cnt} monedas";
                parts.Add($"{moneda} de {coins[i]}");
            }

            string phrase;
            if (parts.Count == 0)
            {
                phrase = $"Para tener {value} no necesitas monedas.";
            }
            else if (parts.Count == 1)
            {
                phrase = $"Para tener {value} necesitas {parts[0]}";
            }
            else
            {
                string allButLast = string.Join(", ", parts.GetRange(0, parts.Count - 1));
                string last = parts[parts.Count - 1];
                phrase = $"Para tener {value} necesitas {allButLast} y {last}";
            }

            Console.WriteLine(phrase + ".");
        }
        Console.WriteLine("Once again?. Press Y or y");
        var cont = Console.ReadLine();
        if(cont == "Y" || cont == "y")
            Init();
    }

}