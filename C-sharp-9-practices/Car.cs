namespace C_sharp_9_practices
{
    public class Car
    {

        public string GetBrand(string brand) => $"Brand's car is { brand }";



    }

    public class CarEnt
    {
        public string Brand { get; set; }
        public string Plate { get; set; }
    }

}
