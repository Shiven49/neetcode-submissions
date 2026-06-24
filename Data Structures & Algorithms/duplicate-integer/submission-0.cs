public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> contain = new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
            if(contain.Contains(nums[i])){
                return true;
            }
            else{
                contain.Add(nums[i]);
            }
        }
        return false;
    }
}