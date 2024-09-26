//https://leetcode.com/problems/linked-list-cycle/

public class Solution {
        /// <summary>
        /// Floyd’s Cycle-Finding 
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycle(ListNode head)
        {
              bool flag = false;
            var slow = head;
            var fast = head;
            while (slow != null && fast?.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
}