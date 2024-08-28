using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public static class PlusOne
    {
        public static void Test()
        {
            //You are given a large integer represented as an integer array digits, where each digits[i]
            //is the ith digit of the integer. The digits are ordered from most significant to least significant
            //in left - to - right order.The large integer does not contain any leading 0's.
            //    Increment the large integer by one and return the resulting array of digits.
        }

        public static int[] PlusOne2(int[] digits)
        {
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            var result = new int[digits.Length + 1];
            result[0] = 1;

            return result;
        }
    }
}
