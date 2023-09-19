/*
 * @lc app=leetcode id=674 lang=java
 *
 * [674] Longest Continuous Increasing Subsequence
 */

// @lc code=start
class Solution {
    public int findLengthOfLCIS(int[] nums) {
        int ans = 0;
        int count = 0;        
        int onum = 0;
        for(int i = 0;i < nums.length ;i++){                    
            if (nums[i] > onum) {                
                count++;
            }else{                
                count = 1;
            }
            ans = Math.max(count,ans);
            onum = nums[i];
        }        
        return ans;
    }
}
// @lc code=end

