public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0;

        int maxLen = 0;

        HashSet<char> set = new HashSet<char>();

        for (int r = 0; r < s.Length; r++) {

            while (set.Contains(s[r])) {

                set.Remove(s[l]);

                l++;

            }

            set.Add(s[r]);

            maxLen = Math.Max(maxLen, r - l + 1);

        }

        return maxLen;
    }
}
