/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        string str="",
               target = "";        
        int i = 0,
            len = 0;
        bool isminus = false;
        str = x.ToString();
        len = str.Length;        
        for (i=len-1; i>=0; i--)
        {
            if (str.Substring(0,1) == "-"){
                isminus = true;
                str = str.Substring(1,len);
            }
            target = target + str.Substring(i,1);
        }
        if (target==str)
        {
            return true;
        }          
        else
        {
            return false;          
        }          
    }
}
// @lc code=end

