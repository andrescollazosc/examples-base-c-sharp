using System;

namespace C_sharp_practices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Declaracion de variables implicita
            var nombre = "Juan"; //string
            var edad = 25; //int
            var salario = 2500.50; //double
            var activo = true; //bool

            //Declaracion de variables explicita
            string ciudad = "Bogotá";
            int cantidad = 10;
            double precio = 99.99;
            bool esValido = false;

            //Tipos de Datos Primitivos
            byte byteValue =255; // 1 byte 	0 a 255
            sbyte sbyteValue =-128; // 1 byte 	-128 a 127
            short shortValue =32767; // 2 bytes 	-32,768 a 32,767
            ushort ushortValue =65535; // 2 bytes 	0 a 65,535
            int intValue =2147483647; // 4 bytes 	-2,147,483,648 a 2,147,483,647
            uint uintValue =4294967295; // 4 bytes 	0 a 4,294,967,295
            long longValue =9223372036854775807; // 8 bytes 	-9,223,372,036,854,775,808 a 9,223,372,036,854,775,807
            ulong ulongValue =18446744073709551615; // 8 bytes 	0 a 18,446,744,073,709,551,615
            float floatValue =-3.402823e38f; // 4 bytes 	-3.402823e38f a 3.402823e38f
            double doubleValue =1.7976931348623e308; // 8 bytes 	-1.7976931348623e308 a 1.79769313486232e308
            decimal decimalValue =79228162514264337593543950335m; // 16 bytes 	-79228162514264337593543950335m a 79228162514264337593543950335m
            char charValue = '\uffff'; // 2 bytes 	'\u0000' a '\uffff'
            string stringValue = "Hello, World!"; // 2 bytes por caracter 	"" (cadena vacía) a cualquier cadena de caracteres
            bool boolValue = true; // 1 byte 	true o false

            //Constantes y valores literales
            const double PI = 9.99999; // Constante compile-time
            const string APP_NAME = "MyApp";

            //Literales numéricos
            int hexValue = 0xFF; // 255
            int binaryValue = 0b1010; // 10
            long big = 1_000_000_000; // 1000000000 Underscores para legibilidad
            double ciento = 1_000.50; // 1000.50

            //Conversion de tipos

            // Implicita
            int miEntero = 42;
            double miDouble = miEntero; // Conversión implícita de int a double

            // Explicita
            double otroDouble = 42.5;
            int otroInt = (int)otroDouble; // 42.5 se convierte a 42 (truncamiento, no redondeo)

            //Metodos de conversion seguros
            string numStr = "123";
            int num = int.Parse(numStr);
            int num2 = int.TryParse(numStr, out int result) ? result : 0;//Seguro

            //Convert clase estatica
            string a = "456";
            int b = Convert.ToInt32(a); // 456
            double c = Convert.ToDouble(b); // 456.0

            //Operadores

            // Aritméticos
            int valA = 10, valB =3;
            //console.WriteLine(valA + valB); // 13

    }

    class Person
    {
        public Guid id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DNI { get; set; }
    }

    class Residence
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string CountryCode { get; set; }
        public string PostalCode { get; set; }
    }

    class ContactInformation
    {
        public Residence Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string IPAddress { get; set; }
    }

    class Migrant : Person
    {
        ContactInformation ContactInfo { get; set; }
    }

    public enum MigrationStatus
    {
        Planned,
        InTransit,
        Settled,
        Returned,
        Unknown
    }

    public enum MigrantStatus
    {
        AsylumSeeker,
        Refugee,
        Undocumented,
        TemporaryProtectedStatus,
        Other
    }
}
