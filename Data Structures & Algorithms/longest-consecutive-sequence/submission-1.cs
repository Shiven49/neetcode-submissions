public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int length=0;
        for(int i=0;i<nums.Length;i++){
            if(!set.Contains(nums[i]-1)){
                int current= nums[i];
                int len=1;
                while(set.Contains(current+1)){
                    current++;
                    len++;
                }
                length=Math.Max(len,length);
            }
            }
        
        return length;
    }}

