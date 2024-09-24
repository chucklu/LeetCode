//Source: https://leetcode.com/problems/two-sum-iv-input-is-a-bst/description/
/***************************************************************************************************** 
Given the root of a binary search tree and an integer k, return true if there exist two elements 
in the BST such that their sum is equal to k, or false otherwise.

Example 1:
Input: root = [5,3,6,2,4,null,7], k = 9
Output: true

Example 2:
Input: root = [5,3,6,2,4,null,7], k = 28
Output: false

Constraints:

    The number of nodes in the tree is in the range [1, 10^4].
    -10^4 <= Node.val <= 10^4
    root is guaranteed to be a valid binary search tree.
    -10^5 <= k <= 10^5
******************************************************************************************************/

public class Solution
{
    public bool FindTarget(TreeNode root, int k)
    {
        List<int> list = new List<int>();
        IterateBinaryTree(root, list);
        list.Sort();
        var array = list.ToArray();

        int i = 0;
        int j = array.Length - 1;
        while (i < j)
        {
            if (array[i] + array[j] == k)
            {
                return true;
            }
            if (array[i] + array[j] > k)
            {
                j--;
            }
            else
            {
                i++;
            }
        }
        return false;
    }

    private static void IterateBinaryTree(TreeNode node, List<int> list)
    {
        if (node == null)
        {
            return;
        }

        list.Add(node.val);
        IterateBinaryTree(node.left, list);
        IterateBinaryTree(node.right, list);
    }
}
