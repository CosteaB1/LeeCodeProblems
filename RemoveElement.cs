namespace LeetCodeProblems;

internal static  class RemoveElement
{
    public static void Test()
    {
        var val = 3;
        int[] nums = [3, 2, 2, 3];
        RemoveElementM(nums, val);
    }

    public static int RemoveElementM(int[] nums, int val)
    {
        var cont = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val) continue;
            nums[cont] = nums[i];
            cont++;

        }


        return cont;
    }
}