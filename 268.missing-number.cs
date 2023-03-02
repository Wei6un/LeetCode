/*
 * @lc app=leetcode id=268 lang=csharp
 *
 * [268] Missing Number
 */

// @lc code=start
public class Solution {
    public int MissingNumber(int[] nums) {
        for(int i = 0; i<=nums.Length; i++)
        {
            if (Array.IndexOf(nums,i) == -1)
            {
                return i;
            }
        }
        return 0;        
    }
}
// @lc code=end

