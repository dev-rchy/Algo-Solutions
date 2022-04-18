public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int length = nums.Length;
        int[] a = new int[length*2];
           for(int i = 0;i<nums.Length;i++){
               a[i]=nums[i];
               a[(i+(length))] = nums[i];
} 
      return a;  
    }
}