//https://leetcode.com/problems/reverse-linked-list/

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;       // This will be the new tail of the list (starting as null)
        ListNode current = head;    // Start with the head of the list

        while (current != null)
        {
            ListNode next = current.next; // Save the next node
            current.next = prev;          // Reverse the pointer
            prev = current;               // Move prev to current
            current = next;               // Move current to the next node
        }

        return prev; // At the end, prev will be the new head of the reversed list
    }
}
