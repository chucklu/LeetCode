//https://leetcode.com/problems/reverse-linked-list/

public class Solution
{
	//三指针
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

public class Solution
{
	//头插法
    public ListNode ReverseList(ListNode head)
    {
        ListNode newHead = null;
        while (head != null)
        {
            var next = head.next;
            head.next = newHead;
            newHead = head;
            head = next;
        }
        return newHead;
    }
}

public class Solution
{
	//递归法
    public ListNode ReverseList(ListNode head)
    {
        var next = head?.next;
        if (head == null || next == null)
        {
            return head;
        }
        var temp = ReverseList(next);
        next.next = head;
        head.next = null;
        return temp;
    }
}
