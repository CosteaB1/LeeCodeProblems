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
        return index;
    }

    public static int StrStr2(string haystack, string needle)
    {
        var occur = -1;

        //if (needle.Length > haystack.Length)
        //{
        //    return -1;
        //}

        var haystackCharArray = haystack.ToCharArray();
        var needleCharArray = needle.ToCharArray();

        var startIndexOccur = -1;
        var neddleIndexOccur = 0;

        for (var i = 0; i < haystackCharArray.Length; i++)
        {
            if (needleCharArray.Length < neddleIndexOccur)
            {
                occur = 1;
                break;
            }

            if (haystackCharArray[i] == needleCharArray[neddleIndexOccur])
            {
                neddleIndexOccur++;
            }
        }

        return -1;
    }

}