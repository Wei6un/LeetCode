/*
 * @lc app=leetcode id=209 lang=csharp
 *
 * [209] Minimum Size Subarray Sum
 */

// @lc code=start
public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int ans = Int32.MaxValue,sum=0,j=0;       
        for (int i = 0; i < nums.Length ; i++)
        {
           sum += nums[i];
           while (sum >= target) {
               ans = Math.Min(ans,i-j+1);
               sum -= nums[j];
               j++;
           }
        }
        if (ans == Int32.MaxValue) {ans = 0;}
        return ans;         
    }
}
// @lc code=end

