/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int i = 0,j = 0;         
        for (i = 0; i < nums.Length; i++)
        {
           for ( j=i+1 ; j < nums.Length; j++) 
           {
               if (nums[i]+nums[j] == target)
               {
                   return new int[]{i,j};
               }
           }
        }
        return null;        
    }
}
// @lc code=end

