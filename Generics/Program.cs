using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output = MaximumNumber<int>.GetMaximum(15, 25, 35);
            Console.WriteLine($"max={output}");
            float output1 = MaximumNumber<float>.GetMaximum(15.5f, 25.5f, 35.5f);
            Console.WriteLine($"max={output1}");
            string output2 = MaximumNumber<string>.GetMaximum("abc", "pqr", "lmn");
            Console.WriteLine($"max={output2}");
        }

    }
}