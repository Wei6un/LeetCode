/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
       if (strs.Length == 0) return "";
       if (strs.Length == 1) return strs[0];       
       int i = 0 ;
       for (; i < strs[0].Length ; i ++){           
           for (int j = 0 ; j < strs.Length ; j ++){
              if (strs[j].Length <= i || strs[0][i] != strs[j][i]) 
                {                                                                               
                return strs[0][0..i];                  
              }
            }
        }
        return strs[0][0..i];
    }            
}
// @lc code=end

