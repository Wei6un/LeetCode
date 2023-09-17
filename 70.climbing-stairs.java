/*
 * @lc app=leetcode id=70 lang=java
 *
 * [70] Climbing Stairs
 */

// @lc code=start
class Solution {
    public int climbStairs(int n) {
        // 迭代
        /*
         * int first = 1;
         * int sec = 2;
         * int tmp = 0;
         * if (n <= 2) {
         *      return n;
         * }else{
         *      for (int i = 3; i<= n; i++){
         *          tmp = sec;
         *          sec+=first;
         *          first=tmp;
         *      }
         * }
         * return sec;
         */
        // 動態規劃
        if (n <= 2) {
            return n;
        } else {
            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;            
            for (int i = 3;i<=n;i++){
                dp[i] = dp[i-1] + dp[i-2];
            }
            return dp[n];
        }

    }
}
// @lc code=end
