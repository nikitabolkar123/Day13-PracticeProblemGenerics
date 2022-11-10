using System;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 22, 33, 66, 77,88 };
            MaximumNumber<int> generic = new MaximumNumber<int>(array);
            generic.PrintMaxValue();
        }

    }
}