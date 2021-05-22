namespace C_sharp_9_practices
{
    public static class Extencios
    {

        public static bool IsLetter1(this char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
    }
}
