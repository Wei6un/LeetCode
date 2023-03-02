/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 */

// @lc code=start
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        double begin = 0, final = nums.Length - 1;
        int mid=0;                         
        while (begin<=final){
            mid = (int)Math.Floor( (begin + final)/2 ) ;
            if (nums[mid] < target)
            {
                begin=mid+1;
            }
            else if  (nums[mid] > target)
            {
                final=mid+1;
            }
            else
            {
                return mid;                
            }
        }
        return (int)final+1;
    }     
}
// @lc code=end

