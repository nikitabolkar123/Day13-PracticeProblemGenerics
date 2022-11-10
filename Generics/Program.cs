using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter The First Value");
            string firstValue = Console.ReadLine(); //Taking input From User

            Console.WriteLine("Please Enter The Second Value");
            string secondValue = Console.ReadLine(); //Taking input From User

            Console.WriteLine("Please Enter The Third Value");
            string thirdValue = Console.ReadLine(); //Taking input From User

            string output = MaximumStringNumber.MaximumStringNum(firstValue, secondValue, thirdValue);
            Console.WriteLine("Maxmimum string value is:");
            Console.WriteLine(output);

        }

    }
}

