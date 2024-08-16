namespace LeetCodeProblems;

internal static class LengthOfLastWord
{

    public static void Test()
    {
        //Given a string s consisting of words and spaces, return the length of the last word in the string.

        //    A word is a maximal
        //substring
        //    consisting of non-space characters only.

        var s = "Hello World";
        var s1 = "   fly me   to   the moon  ";
        var s3 = "luffy is still joyboy";
        LengthOfLastWord1(s1);
    }

    public static int LengthOfLastWord1(string s)
    {
        var x = s.Trim().Split(' ')
            .Last()
            .Length;

        return x;
    }
}