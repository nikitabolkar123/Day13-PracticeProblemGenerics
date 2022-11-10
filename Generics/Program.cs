using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Maximum Interger Number is");
            int output = MaximumNumber.MaximumNum(15, 25, 35);
            Console.WriteLine(output);

            Console.WriteLine("Maximum Double Number is");
            double output1 = MaximumNumber.MaximumNum(15.5, 25.5, 35.5);
            Console.WriteLine(output1);

            Console.WriteLine("Maximum String Number is");
            string output2 = MaximumNumber.MaximumNum("abc", "xyz", "pqr");
            Console.WriteLine(output2);
        }

    }
}