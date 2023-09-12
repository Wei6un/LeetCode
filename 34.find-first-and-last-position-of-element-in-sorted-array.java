/*
 * @lc app=leetcode id=34 lang=java
 *
 * [34] Find First and Last Position of Element in Sorted Array
 */

// @lc code=start
class Solution {
    public int[] searchRange(int[] nums, int target) {
        int[] rets = { -1, -1 };
        int left = 0;
        int right = nums.length - 1;
        while (left <= right) {
            if (nums[left] == target) {
                rets[0] = left;
                while (left < right) {
                    if (nums[right] == target) {
                        rets[1] = right;
                        return rets;
                    } else {
                        right--;
                    }
                }                
                rets[1] = left;
                return rets;
            } else if (nums[left] < target) {
                left++;
            } else if (nums[right] > target) {
                right--;
            }
        }

        return rets;
    }
}
// @lc code=end
