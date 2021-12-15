using System;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte testByte = 30;

            sbyte testSbyte = 58;

            int testInt = 3432345;

            uint testUint = 1234234;

            short testShort = 31000;

            ushort testUshort = 60000;

            string controlText = "i Control text";

            string number = "12";

            int convertNumber = Int32.Parse(number);
            Console.WriteLine(convertNumber);
        }
    }
}
