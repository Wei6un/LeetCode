/*
 * @lc app=leetcode id=1816 lang=csharp
 *
 * [1816] Truncate Sentence
 */

// @lc code=start
public class Solution {
    public string TruncateSentence(string s, int k) {
        string[] str = s.Split(' ');        
        string[] ans_arr = new string[k];
        string ans="";        
        for (int i=0;i<k;i++){
            ans_arr[i]=str[i];
        }
        ans = String.Join(" ",ans_arr);
        return ans;        
    }
}
// @lc code=end

