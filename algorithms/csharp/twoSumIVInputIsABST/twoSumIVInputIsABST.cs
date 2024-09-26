//https://leetcode.com/problems/two-sum-iv-input-is-a-bst/description/

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
        InOrderTraversal(root, list);

        int i = 0;
        int j = list.Count - 1;
        while (i < j)
        {
            int sum = list[i] + list[j];
            if (sum == k)
            {
                return true;
            }
            if (sum > k)
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

    private void InOrderTraversal(TreeNode node, List<int> list)
    {
        if (node == null)
        {
            return;
        }

        // In-order traversal: Left, Root, Right
        InOrderTraversal(node.left, list);
        list.Add(node.val);
        InOrderTraversal(node.right, list);
    }
}

public class Solution
{
    public bool FindTarget(TreeNode root, int k)
    {
        HashSet<int> set = new HashSet<int>();
        return Find(root, k, set);
    }

    private bool Find(TreeNode node, int k, HashSet<int> set)
    {
        if (node == null)
        {
            return false;
        }
        var delta = k - node.val;
        if (set.Contains(delta))
        {
            return true;
        }
        set.Add(node.val);
        return Find(node.left, k, set) || Find(node.right, k, set);
    }
}

