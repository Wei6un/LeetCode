/*
 * @lc app=leetcode id=36 lang=java
 *
 * [36] Valid Sudoku
 */

// @lc code=start
class Solution {
    public boolean isValidSudoku(char[][] board) {
        HashSet <String> newset = new HashSet <String> ();
        char tmp;
        for (int i=0;i<9;i++){
            for (int j=0;j<9;j++){
                tmp = board[i][j];
                if (tmp != '.'){
                    if ( (newset.contains(tmp+"col"+i)) ||
                         (newset.contains(tmp+"row"+j)) ||
                         (newset.contains(tmp+"grd"+i/3+j/3)) 
                       ){
                           return false; 
                        }
                    newset.add(tmp+"col"+i);
                    newset.add(tmp+"row"+j);                   
                    newset.add(tmp+"grd"+i/3+j/3);                   
                }
            }
        }
        return true;
    }
}
// @lc code=end

