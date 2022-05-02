public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int length = nums.Length;
        int[] val = new int[length];
        int a = 0;
        for(int i = 0; i<n; i=i+1) {
            val[a] = nums[i];
            val[a+1] = nums[n+i];
            a=a+2;
          }
        return val;
    }
}