using System;
using System.Collections.Generic;

namespace C_sharp_9_practices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsActive(0));

            char k = 'b';
            Console.WriteLine(k.IsLetter1());


            Console.WriteLine(ValidateNull("Hi"));

            // Instnace class
            Car car = new();

            List<CarEnt> list = new()
            {
                new() { Brand = "Mazda 3", Plate = "dfghj" },
                new() { Brand = "Renault ", Plate = "djasdhj" },
            };

            foreach (var item in list)
            {
                Console.WriteLine(item.Brand);
            }

            Console.WriteLine(car.GetBrand("Mazda 3"));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(GetSalary(1));


        }

        // Functions 
        private static bool IsActive(int value) => value is 0 ? false : true;

        private static string ValidateNull(string value)
        {
            string message = string.Empty;

            if (value is not null)
            {
                message = "Hola mundo";
            }

            return message;
        }



        private static int GetSalary(int option) =>
            option switch
            {
                ((int)SalaryEnum.First) => 10000,
                ((int)SalaryEnum.Second) => 20000,
                ((int)SalaryEnum.Third) => 30000,
                _ => 500
            };

    }

    public enum SalaryEnum { 
        First = 1,
        Second,
        Third
    }

}
