using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class MaximumNumber<T> where T : IComparable<T>
    {
        public T[] inputArray;

        public MaximumNumber(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public T[] Sort(T[] inputArray)
        {
            Array.Sort(inputArray);
            return inputArray;
        }

        public T MaxValue(params T[] inputArray)
        {
            var sortedValue = Sort(inputArray);
            return sortedValue[^1];

        }
        public T MaxMethod()
        {
            var max = MaxValue(this.inputArray);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.inputArray);
            Console.WriteLine($"Maximum value :{max}");
        }
    }
}
