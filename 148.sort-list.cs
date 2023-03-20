/*
 * @lc app=leetcode id=148 lang=csharp
 *
 * [148] Sort List
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode SortList(ListNode head)
    {
        if (head == null)
        {
            return null;
        }
        else if (head.next == null)
        {
            return head;
        }
        ListNode ans = null;
        List<int> list = new List<int>();
        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }
        list.Sort();
        list.Reverse();
        foreach (int i in list)
        {
            ListNode newNode = new ListNode(i);
            newNode.next = ans;
            ans = newNode;
        }
        return ans;
    }
}
// @lc code=end

