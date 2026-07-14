public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> contains = new HashSet<int>();
        for(int i=0; i<nums.Length; i++){
             if(contains.Contains(nums[i])){
                return true;
             }
             
            contains.Add(nums[i]);
        }
        return false;
    }
}