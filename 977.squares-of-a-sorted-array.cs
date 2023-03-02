/*
 * @lc app=leetcode id=977 lang=csharp
 *
 * [977] Squares of a Sorted Array
 */

// @lc code=start
public class Solution {
    public int[] SortedSquares(int[] nums) {
       for (int i = 0 ; i < nums.Length ; i++) {
           nums[i] = nums[i] * nums[i];
       }
       Array.Sort(nums);
       return nums;        
    }
}
// @lc code=end

