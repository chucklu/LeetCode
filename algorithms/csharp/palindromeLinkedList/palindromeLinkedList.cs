//https://leetcode.com/problems/palindrome-linked-list/description/

public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        if (head?.next == null)
        {
            return true;
        }
        var slow = head;
        var fast = head;
        ListNode firstHead = head;
        ListNode secondHead;
        ListNode slowPrev = null;
        // Get the middle of the list.
        // Move slow by 1 and fast by 2
        // slow will have the middle mode
        while (fast?.next != null)
        {
            fast = fast.next.next;
            //We need previous of the slow_ptr for linked lists  with odd elements
            slowPrev = slow;
            slow = slow.next;
        }
        if (slowPrev != null)
        {
            slowPrev.next = null;
        }

        if (fast != null)
        {
            //not null for odd elements
            secondHead = slow.next;
        }
        else
        {
            secondHead = slow;
        }

        secondHead = ReverseList(secondHead);
        bool flag = true;
        while (firstHead != null && secondHead != null)
        {
            if (firstHead.val != secondHead.val)
            {
                flag = false;
                break;
            }
            else
            {
                firstHead = firstHead.next;
                secondHead = secondHead.next;
            }
        }

        if (firstHead != null || secondHead != null)
        {
            flag = false;
        }

        return flag;
    }

    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;
        while (curr != null)
        {
            ListNode nextTemp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextTemp;
        }
        return prev;
    }
}