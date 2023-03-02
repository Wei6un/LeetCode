/*
 * @lc app=leetcode id=258 lang=csharp
 *
 * [258] Add Digits
 */

// @lc code=start
public class Solution {
    public int AddDigits(int num) {
        if (num<10) {return num;}        
        while (num > 9){
            int sum = 0;
            char[] nums = num.ToString().ToCharArray();
            for(int i = 0; i < nums.Length; i++){
                sum+= Convert.ToInt32(nums[i].ToString());
            } 
            num = sum;
        }
        return num;            
    }
}
// @lc code=end

