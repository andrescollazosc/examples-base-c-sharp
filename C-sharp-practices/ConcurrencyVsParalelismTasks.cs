using System;
using System.Threading;
using System.Threading.Tasks;

namespace C_sharp_9_practices
{
    public static class ConcurrencyVsParalelismTasks
    {
        public static async Task<string> GetFirstTaskAsync(){
            Console.WriteLine($"Starting {nameof(GetFirstTaskAsync)}");
            Thread.Sleep(5000);
            Console.WriteLine($"{nameof(GetFirstTaskAsync)} Completed");
            return "uno";
        }

        public static async Task GetSecondTaskAsync(){
            Console.WriteLine($"Starting {nameof(GetSecondTaskAsync)}");
            Thread.Sleep(5000);
            Console.WriteLine($"{nameof(GetSecondTaskAsync)} Completed");
        }

        public static async Task GetThirdTaskAsync(){
            Console.WriteLine($"Starting {nameof(GetThirdTaskAsync)}");
            Thread.Sleep(5000);
            Console.WriteLine($"{nameof(GetThirdTaskAsync)} Completed");
        }
    }

}
