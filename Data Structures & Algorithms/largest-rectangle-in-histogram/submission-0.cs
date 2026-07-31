public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<(int start, int height)> stack = new();

        int maxArea = 0;

        for (int i = 0; i < heights.Length; i++) {
            int start = i;

            while (stack.Count > 0 && stack.Peek().height > heights[i]) {
                var (index, height) = stack.Pop();

                maxArea = Math.Max(maxArea, height * (i - index));

                start = index;
            }

            stack.Push((start, heights[i]));
        }

        while (stack.Count > 0) {
            var (index, height) = stack.Pop();

            maxArea = Math.Max(maxArea, height * (heights.Length - index));
        }

        return maxArea;
    }
}
