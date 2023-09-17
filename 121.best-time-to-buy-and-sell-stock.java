/*
 * @lc app=leetcode id=121 lang=java
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
class Solution {
    public int maxProfit(int[] prices) {
        int max = 0;
        int min = prices[0];
        for (int i = 1; i<=prices.length-1;i++){
            if (prices[i] < min){
                min = prices[i];
            }else if ((prices[i]-min) > max){
                max = prices[i] - min;
            }
        }
        return max;
    }
}
// @lc code=end

