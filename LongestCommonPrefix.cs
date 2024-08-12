namespace LeetCodeProblems
{
    internal static class LongestCommonPrefix
    {
        public static void Test()
        {
            var testCases = new string[][]
            {
                ["flower", "flow", "flight"],
                ["dog", "racecar", "car"]
            };

            foreach (var testCase in testCases)
            {
                Console.WriteLine("The longest common prefix is: " + LongestCommonPrefixM(testCase));
            }
        }

        public static string LongestCommonPrefixM(string[] strs)
        {
            var arrayLength = strs.Length;
            var result = strs[0];
            var prefixLength = result.Length;

            for (var i = 0; i < arrayLength; i++)
            {
                while (!strs[i].StartsWith(result))
                {
                    result = result.Substring(0, prefixLength - 1);
                    prefixLength--;
                }
                if (result.Length == 0)
                {
                    return "";
                }
            }


            return result;
        }
    }
}

//14.Longest Common Prefix
//Easy
//    Topics
//Companies
//    Write a function to find the longest common prefix string amongst an array of strings.

//    If there is no common prefix, return an empty string "".



//    Example 1:

//Input: strs = ["flower", "flow", "flight"]
//Output: "fl"
//Example 2:

//Input: strs = ["dog", "racecar", "car"]
//Output: ""
//Explanation: There is no common prefix among the input strings.


//    Constraints:

//1 <= strs.length <= 200
//0 <= strs[i].length <= 200
//strs[i] consists of only lowercase English letters.
