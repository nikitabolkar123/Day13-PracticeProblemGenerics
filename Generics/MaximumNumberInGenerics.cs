using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class MaximumNumberInGenerics
    {
        public static T GetMaximum<T>(T first_Value, T second_Value, T third_Value) where T : IComparable<T>
        {
            if (first_Value.CompareTo(second_Value) > 0 && first_Value.CompareTo(third_Value) > 0)
            {
                return first_Value;
            }
            else if (second_Value.CompareTo(first_Value) > 0 && second_Value.CompareTo(third_Value) > 0)
            {
                return second_Value;
            }
            else if (third_Value.CompareTo(first_Value) > 0 && third_Value.CompareTo(second_Value) > 0)
            {
                return third_Value;
            }
            else
            {
                throw new Exception("Values are The same");
            }
        }
    }
}