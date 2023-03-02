/*
 * @lc app=leetcode id=59 lang=csharp
 *
 * [59] Spiral Matrix II
 */

// @lc code=start
public class Solution {
    public int[][] GenerateMatrix(int n) {
        int [][] result = new int[n][];
        for (int i =0;i<n;i++){
            result[i] = new int [n];
        }
        int top = 0,
            right = n-1,
            bottom = n-1,
            left = 0,
            count = 0; 
        while (count < n*n) {  
            //往右          
            for (int i=left;i<=right;i++){
                count++;
                result[left][i] = count;                
            } 
            if (count == n*n) break;
            top+=1;
            //往下
            for (int i=top;i<=bottom;i++){
                count++;
                result[i][right] = count;                                                
            }
            if (count == n*n) break;
            right-=1;
            //往左
            for (int i=right;i>=left;i--){
                count++;
                result[bottom][i] = count;                                                
            }
            if (count == n*n) break;
            bottom-=1;
            //往上
            for (int i=bottom;i>=top;i--){
                count++;
                result[i][left] = count;                                                               
            } 
            if (count == n*n) break;
            left+=1; 
        }         
        return result;
    }
}
// @lc code=end

