using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("maximum Number is:");
            int output = MaximumIntNumber.MaximumIntNum(15, 25, 35);
            Console.WriteLine(output);
        }
    }
}
