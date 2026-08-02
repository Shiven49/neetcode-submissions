public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;

        int cols = matrix[0].Length;

        int top = 0;

        int bottom = rows - 1;

        while (top <= bottom) {

            int row = top + (bottom - top) / 2;

            if (target > matrix[row][cols - 1]) {

                top = row + 1;

            }

            else if (target < matrix[row][0]) {

                bottom = row - 1;

            }

            else {

                int l = 0;

                int r = cols - 1;

                while (l <= r) {

                    int mid = l + (r - l) / 2;

                    if (matrix[row][mid] == target)

                        return true;

                    if (matrix[row][mid] < target)

                        l = mid + 1;

                    else

                        r = mid - 1;

                }

                return false;

            }

        }

        return false;
    }
}
