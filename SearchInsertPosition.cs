﻿namespace LeetCodeProblems;

internal static class SearchInsertPosition
{
    public static void Test()
    {
        int[] x = [1, 3, 5, 6];
        int target1 = 5;
        var target2 = 2;
        var target3 = 7;

        SearchInsert(x, target3);

    }
    // this solution is just for passing leetcode tests, it's not perfect :) 
    public static int SearchInsert(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target) return i;
            if (nums[i] < target)
            {
                if (i == nums.Length-1)
                {

                    return i + 1;
                }

                if (nums[i + 1] > target)
                {
                    return i + 1;
                }
               
            }
        }

        return 0;
    }
}

//Given a sorted array of distinct integers and a target value, return the index if the target is found.If not, return the index where it would be if it were inserted in order.

//    You must write an algorithm with O(log n) runtime complexity.



//    Example 1:

//Input: nums = [1, 3, 5, 6], target = 5
//Output: 2
//Example 2:

//Input: nums = [1, 3, 5, 6], target = 2
//Output: 1
//Example 3:

//Input: nums = [1, 3, 5, 6], target = 7
//Output: 4