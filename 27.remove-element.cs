/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int ans = 0;
        for (int i=0;i < nums.Length; i++){
            if (nums[i] != val){
                nums[ans] = nums[i];
                ans++;
            }
        }
        return ans;        
    }
}
// @lc code=end

