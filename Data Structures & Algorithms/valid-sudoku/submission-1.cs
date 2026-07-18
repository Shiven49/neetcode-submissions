public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for (int i = 0; i < 9; i++) {
            HashSet<char> row = new HashSet<char>();
            for (int j = 0; j < 9; j++) {
                if (board[i][j] == '.') {
                    continue;
                }
                if (row.Contains(board[i][j])) {
                    return false;
                } else {
                    row.Add(board[i][j]);
                }
            }
        }
        for (int j = 0; j < 9 ; j++){
            HashSet<char> col = new HashSet<char>();
            for(int i=0;i<9;i++){
                if (board[i][j]== '.'){
                    continue;
                }
                if (col.Contains(board[i][j])){
                    return false;
                }else{ 
                    col.Add(board[i][j]);
                }
            }
        }
        for (int row = 0;row<9;row+=3){
            for (int col=0;col<9;col+=3){
                HashSet<char> box=new HashSet<char>();
                for(int i=row;i<row+3;i++){
                    for(int j=col;j<col+3;j++){
                        if (board[i][j]=='.'){
                            continue;
                        }
                        if(box.Contains(board[i][j])){
                            return false;
                        }else{box.Add(board[i][j]);}
                    }
                }
            }
        }
        return true;
}}
