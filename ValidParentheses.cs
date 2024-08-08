namespace LeeCodeProblems;

internal static class ValidParentheses
{
    public static void Test()
    {
        var testCases = new[]
        {
            "()",
            "()[]{}",
            "(]"
        };

        foreach (var testCase in testCases)
        {
            Console.WriteLine("Valid Parentheses" + IsValid(testCase));
        }
    }

    public static bool IsValid(string s)
    {
        if (s.Length <= 1)
            return false;

        var bracketQueue = new List<int>();
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                bracketQueue.Add(1);
                continue;
            }
            if (s[i] == '[')
            {
                bracketQueue.Add(2);
                continue;
            }
            if (s[i] == '{')
            {
                bracketQueue.Add(3);
                continue;
            }
            if (bracketQueue.Count == 0)
                return false;
            if (s[i] == ')' && bracketQueue[^1] == 1)
            {
                bracketQueue.RemoveAt(bracketQueue.Count - 1);
                continue;
            }
            if (s[i] == ']' && bracketQueue[^1] == 2)
            {
                bracketQueue.RemoveAt(bracketQueue.Count - 1);
                continue;
            }
            if (s[i] == '}' && bracketQueue[^1] == 3)
            {
                bracketQueue.RemoveAt(bracketQueue.Count - 1);
                continue;
            }

            return false;
        }
        return bracketQueue.Count == 0;
    }
}


//Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

//    An input string is valid if:

//Open brackets must be closed by the same type of brackets.
//    Open brackets must be closed in the correct order.
//    Every close bracket has a corresponding open bracket of the same type.


//    Example 1:

//Input: s = "()"
//Output: true
//Example 2:

//Input: s = "()[]{}"
//Output: true
//Example 3:

//Input: s = "(]"
//Output: false



//Constraints:

//1 <= s.length <= 104
//s consists of parentheses only '()[]{}'.