/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */

// @lc code=start
public class Solution {
    public int Reverse(int x) {
        string str="",
               target = "";        
        int i = 0,  
            ans = 0;              
        bool isminus = false;     
        str = x.ToString();          
        if (str.Substring(0,1) == "-"){
            isminus = true; 
            str = str.Substring(1,str.Length-1);           
        }                     
        for (i=str.Length-1; i>=0; i--)
        {            
            target = target + str.Substring(i,1);
        }
        Int32.TryParse(target, out ans);
        if (isminus){
           ans = ans * -1;
        }
        return ans;          
    }
}
// @lc code=end

