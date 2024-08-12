namespace LeetCodeProblems;

internal static class RemoveDuplicatesFromSortedArray
{
    public static void Test()
    {
        // Example 1
        int[] nums1 = { 1, 1, 2 };
        int[] expectedNums1 = { 1, 2 }; 

        var k1 = RemoveDuplicates(nums1); 

        if (k1 != expectedNums1.Length)
        {
            Console.WriteLine("Test 1 failed: Length mismatch");
            return;
        }
        for (var i = 0; i < k1; i++)
        {
            // Check if each element is correctly placed
            if (nums1[i] != expectedNums1[i])
            {
                Console.WriteLine($"Test 1 failed: Element mismatch at index {i}");
                return;
            }
        }

        // Example 2
        int[] nums2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }; 
        int[] expectedNums2 = { 0, 1, 2, 3, 4 }; 

        var k2 = RemoveDuplicates(nums2); 

        if (k2 != expectedNums2.Length)
        {
            Console.WriteLine("Test 2 failed: Length mismatch");
            return;
        }
        for (var i = 0; i < k2; i++)
        {
            if (nums2[i] != expectedNums2[i])
            {
                Console.WriteLine($"Test 2 failed: Element mismatch at index {i}");
                return;
            }
        }

        Console.WriteLine("All tests passed.");
    }



    private static int RemoveDuplicates(int[] nums)
    {
        var i = 0;
        for (var j = 1; j < nums.Length; j++)
        {
            if (nums[i] != nums[j])
            {
                i++;
                nums[i] = nums[j];
            }
        }
        return i + 1;
    }
}