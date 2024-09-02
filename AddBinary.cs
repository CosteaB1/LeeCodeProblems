using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal static class AddBinary
    {
        public static void Test()
        {
           // Given two binary strings a and b, return their sum as a binary string.

           Console.WriteLine(AddBinary1("11", "1"));
           Console.WriteLine(AddBinary1("1010", "1011"));

        }

        public static string AddBinary1(string a, string b)
        {

            var i = a.Length - 1;
            var j = b.Length - 1;
            var carry = 0;
            var result = "";

            while (i >= 0 || j >= 0 || carry > 0)
            {
                var sum = carry;

                if (i >= 0)
                {
                    sum += a[i] - '0';
                    i--;
                }

                if (j >= 0)
                {
                    sum += b[j] - '0';
                    j--;
                }

                result = (sum % 2) + result;
                carry = sum / 2;
            }



            return result;
        }
    }
}
