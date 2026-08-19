public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length)

            return FindMedianSortedArrays(nums2, nums1);

        int total = nums1.Length + nums2.Length;

        int half = (total + 1) / 2;

        int l = 0;

        int r = nums1.Length;

        while (l <= r) {

            int i = l + (r - l) / 2;

            int j = half - i;

            int left1 = i == 0 ? int.MinValue : nums1[i - 1];

            int right1 = i == nums1.Length ? int.MaxValue : nums1[i];

            int left2 = j == 0 ? int.MinValue : nums2[j - 1];

            int right2 = j == nums2.Length ? int.MaxValue : nums2[j];

            if (left1 <= right2 && left2 <= right1) {

                if (total % 2 == 1)

                    return Math.Max(left1, left2);

                return (Math.Max(left1, left2) +

                        Math.Min(right1, right2)) / 2.0;

            }

            if (left1 > right2)

                r = i - 1;

            else

                l = i + 1;

        }

        return 0;
    }
}
