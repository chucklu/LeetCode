public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode current1Prev = null;
        ListNode current2Next;
        ListNode head;
        if (l1 == null)
        {
            return l2;
        }

        if (l2 == null)
        {
            return l1;
        }

        ListNode current1;
        ListNode current2;
        if (l1.val <= l2.val)
        {
            current1 = l1;
            current2 = l2;
        }
        else
        {
            current1 = l2;
            current2 = l1;
        }

        head = current1;
        while (current1 != null && current2 != null)
        {
            if (current1.val <= current2.val)
            {
                current1Prev = current1;
                current1 = current1.next;
            }
            else
            {
                current1Prev.next = current2;
                current1Prev = current2;
                current2Next = current2.next;
                current2.next = current1;
                current2 = current2Next;
            }
        }

        if (current1 == null)
        {
            current1Prev.next = current2;
        }

        return head;
    }
}