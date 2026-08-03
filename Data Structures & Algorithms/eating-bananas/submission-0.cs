public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1;

        int r = 0;

        foreach (int pile in piles) r = Math.Max(r, pile);

        int ans = r;

        while (l <= r) {
            int mid = l + (r - l) / 2;

            int hours = 0;

            foreach (int pile in piles) hours += (pile + mid - 1) / mid;

            if (hours <= h) {
                ans = mid;

                r = mid - 1;

            }

            else {
                l = mid + 1;
            }
        }

        return ans;
    }
}
