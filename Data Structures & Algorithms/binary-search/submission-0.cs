public class Solution {
    public int Search(int[] nums, int target) {
        int l=0;
        int r=nums.Length-1;
        while(l<=r){
        int mid = (r+l)/2;
        
            if(target>nums[mid]){
                l=mid +1;
            }
            else if(target<nums[mid]){
                r=mid-1;
            }
            else if(target==nums[mid]){
                return mid;
            }
        }
        return -1;
    }
}
