/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution {
    public int RomanToInt(string s) {
        char[] c_array = s.ToCharArray();        
        int i = 0,ans=0,val_now=0,val_next=0;
        for (i=0; i<c_array.Length; i++)
        {
            val_now = Roman(c_array[i]);
            if (i != c_array.Length - 1){
                val_next = Roman(c_array[i+1]);                
            }
            else
            {
                val_next = 0;
            }            
            ans += (val_now >= val_next ? 1 : -1) * val_now;
        }
        return ans;

    }
    public int Roman(char c)
    {
        switch(c){
            case 'I' : return 1;
            case 'V' : return 5;
            case 'X' : return 10;
            case 'L' : return 50;
            case 'C' : return 100;
            case 'D' : return 500;
            case 'M' : return 1000;
        };  
        return 0;
    }              
}
// @lc code=end

