/*
 * @lc app=leetcode id=1137 lang=java
 *
 * [1137] N-th Tribonacci Number
 *         if (n == 0) {
            return 0;
        }
        if (n < 3) {
            return 1;
        }

        int[] rets = new int[n+1];

        rets[0] = 0;
        rets[1] = 1;
        rets[2] = 1;

        for (int i = 3; i <= n; i++) {
            rets[i] = rets[i - 3] + rets[i - 2] + rets[i - 1];
        }

        return rets[n];
 */

// @lc code=start
class Solution {

    public int tribonacci(int n) {
        int a = 0;
        int b = 1;
        int c = 1;
        for (int i = 3; i <= n; i++) {
            int temp = a + b + c;
            a = b;
            b = c;
            c = temp;
        }
        return c;
    }
}
// @lc code=end
