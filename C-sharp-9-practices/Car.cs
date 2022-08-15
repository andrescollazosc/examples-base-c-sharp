namespace C_sharp_9_practices
{

    public interface ICar {
        public string GetBrandI(string brand);
    }

    public interface ICar2
    {
        public string GetBrandI2(string brand);
    }
    public abstract class Car
    {
        private readonly int _a = 1;
        private const int _b = 1;

        public Car() {
            _a = 2;
            //_b = 2;
        }
        public string GetBrand(string brand) => $"Brand's car is { brand }";



    }

    public abstract class Car2
    {

        public string GetBrand2(string brand) => $"Brand's car is { brand }";



    }
    public class CarEnt: Car, ICar, ICar2
    {
        public string Brand { get; set; }
        public string Plate { get; set; }

        public string GetBrandI(string brand)
        {
            throw new System.NotImplementedException();
        }

        public string GetBrandI2(string brand)
        {
            throw new System.NotImplementedException();
        }
    }

}
