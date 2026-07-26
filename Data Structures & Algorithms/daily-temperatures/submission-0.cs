public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> stack = new();
        int[] ans = new int[temperatures.Length];
        for (int i = 0; i < temperatures.Length; i++) {
            while (stack.Count > 0 &&

                   temperatures[i] > temperatures[stack.Peek()]) {
                int prev = stack.Pop();

                ans[prev] = i - prev;
            }

            stack.Push(i);
        }

        return ans;
    }
}
