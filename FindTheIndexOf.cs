namespace LeetCodeProblems;

public static class FindTheIndexOf
{
    internal static void Test()
    {
        StrStr("sadbutsad", "sad");
    }

    public static int StrStr(string haystack, string needle)
    {
        var index = haystack.IndexOf(needle, StringComparison.Ordinal);
        return index >= 0 ? 1 : index;
    }

}