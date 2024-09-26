//https://leetcode.com/problems/reverse-linked-list/

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode current = head;
        ListNode next = current?.next;
        if (next != null)
        {
            head.next = null;
        }
        while (next != null)
        {
            ListNode next2 = next.next;
            next.next = current;

            current = next;
            next = next2;
        }

        return current;
    }
}