public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i=0;i<nums.Length;i++){
            int req=target-nums[i];
            if(map.ContainsKey(req)){
                return new int[]{map[req],i};
            }
            if (!map.ContainsKey(nums[i])) {
                map.Add(nums[i], i);
            }
        }
        return null;
    }
}
