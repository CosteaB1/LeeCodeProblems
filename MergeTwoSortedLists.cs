namespace LeetCodeProblems;

internal static class MergeTwoSortedLists
{
    public static void Test()
    {
        //Input: list1 = [1, 2, 4], list2 = [1, 3, 4]
        //Output: [1,1,2,3,4,4]

        //Input: list1 = [], list2 = []
        //Output: []

        //Input: list1 = [], list2 = [0]
        //Output: [0]

        var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

        var list3 = MergeTwoLists(list1,list2);

        PrintList(list3);
    }


    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode();
        ListNode current = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        current.next = list1 ?? list2;

        return dummy.next;
    }

    public static void PrintList(ListNode head)
    {
        var current = head;
        while (current != null)
        {
            Console.Write(current.val);
            if (current.next != null)
            {
                Console.Write(" -> ");
            }
            current = current.next;
        }
        Console.WriteLine(); 
    }

}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

