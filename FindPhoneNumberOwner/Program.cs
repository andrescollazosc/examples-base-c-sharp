using System;
using System.Linq;

class Program {

    public static void Main(string[] args){
        string[] names ={"Brayan", "Alejandro", "David", "Andres"};
        string[] numbers = {"3204796677", "3505256845", "3168297315", "3208922323"};

        string res = solution(names, numbers, "320");
        Console.WriteLine(res);
    }

    public static string solution(string[] A, string[] B, string P) {
        var phoneNumbers = B.Where(x => x.Contains(P));
        int position;
        List<string> names= [];

        foreach(string phoneNumber in phoneNumbers)
        {
            position = Array.IndexOf(B, phoneNumber);
            if (position >= 0)
            {
                names.Add(A[position]);    
            }
            
        }

        if (names.Any()){
            names.Sort();
            return names.FirstOrDefault();
        }else
        {
            return "NO CONTACT";
        }
        
    }
}