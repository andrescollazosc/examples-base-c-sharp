using System;

namespace TestMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 4, 8, 6, 10 };
            int[] result = new int[5];
            int resultOp = 0;

            for (int i = 0; i < array.Length - 1; i++) {
                if (i == 0)
                    resultOp = (array[i] * array[i + 1]);
                else
                    resultOp = (resultOp * array[i + 1]);
            }

            for (int i = 0; i < array.Length; i++) {
                result[i] = resultOp / array[i];
            }

        }
    }


    public abstract class Vehiculo {
        public abstract string GetBrand();

        public string GetPlaca() {
            return "";
        }

        public string GetPlaca(string number) {
            return "";
        }

    }

    public class Carro : Vehiculo {
        public override string GetBrand() {
            return "Ford";
        }
    }

    public class Avion : Vehiculo {
        public override string GetBrand() {
            return "Avianca";
        }
    }


}
