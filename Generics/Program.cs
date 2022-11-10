using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The First Value");
            float firstValue = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please Enter The Second Value");
            float secondValue = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please Enter The Third Value");
            float thirdValue = Convert.ToSingle(Console.ReadLine());

            float output = MaximumFloatNumber.MaximumFloatNum(firstValue, secondValue, thirdValue);
            Console.WriteLine("Maximum Float Number is");
            Console.WriteLine(output);

        }

    }
}
