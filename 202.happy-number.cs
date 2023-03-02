/*
 * @lc app=leetcode id=202 lang=csharp
 *
 * [202] Happy Number
 */

// @lc code=start
public class Solution {
    public bool IsHappy(int n) {
        while (n > 4) {
            int sum = 0;
            char[] nums = n.ToString().ToCharArray();
            for(int i = 0; i < nums.Length; i++){
                sum+= Convert.ToInt32(nums[i].ToString())*Convert.ToInt32(nums[i].ToString());
            } 
            n = sum;
        }
        if (n == 1) {
            return true;
        }else
        {
            return false;
        }        
    }
}
// @lc code=end

