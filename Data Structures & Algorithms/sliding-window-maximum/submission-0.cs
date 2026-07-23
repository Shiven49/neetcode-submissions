public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        PriorityQueue<(int value, int index), int> pq = new();

        int[] result = new int[nums.Length - k + 1];
        int res = 0;

        for (int i = 0; i < nums.Length; i++) {
            pq.Enqueue((nums[i], i), -nums[i]);

            while (pq.Peek().index <= i - k) {
                pq.Dequeue();
            }

            if (i >= k - 1) {
                result[res++] = pq.Peek().value;
            }
        }

        return result;
    }
}