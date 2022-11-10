using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int output = MaximumNumberInGenerics.GetMaximum<int>(15, 25, 35);
            Console.WriteLine($"max={output}");
            float output1 = MaximumNumberInGenerics.GetMaximum<float>(15.5f,35.5f,25.5f);
            Console.WriteLine($"max={output1}");
            string output2 = MaximumNumberInGenerics.GetMaximum<string>("abc", "xyz", "pqr");
            Console.WriteLine($"max={output2}");
        }

    }
}

