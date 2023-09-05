/*
 * @lc app=leetcode id=69 lang=java
 *
 * [69] Sqrt(x)
 */

// @lc code=start
class Solution {
    public int mySqrt(int x) {
        if (x<2) {return x;}
        int i=1;
        for(;i<=x/i;i++){
            if (i==x/i) {return i;}
        }
        return i-1;       
    }
}
// @lc code=end

