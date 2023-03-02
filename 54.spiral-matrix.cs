/*
 * @lc app=leetcode id=54 lang=csharp
 *
 * [54] Spiral Matrix
 */

// @lc code=start
public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        int width = matrix[0].Length;
        int height = matrix.Length;
        int lenght = width * height;

        List<int> result = new List<int>(lenght);
        int top = 0,
            right = width - 1,
            bottom = height - 1,
            left = 0;            

        while (result.Count < lenght) {  
            //往右          
            for (int i=left;i<=right;i++){
                result.Add(matrix[left][i]);                
            } 
            if (result.Count==lenght) break;
            top+=1;
            //往下
            for (int i=top;i<=bottom;i++){
                result.Add(matrix[i][right]);                
            }
            if (result.Count==lenght) break;
            right-=1;
            //往左
            for (int i=right;i>=left;i--){
                result.Add(matrix[bottom][i]);                
            }
            if (result.Count==lenght) break;
            bottom-=1;
            //往上
            for (int i=bottom;i>=top;i--){
                result.Add(matrix[i][left]);                
            } 
            if (result.Count==lenght) break;
            left+=1;                        
        }
        return result;
    }
}
// @lc code=end

