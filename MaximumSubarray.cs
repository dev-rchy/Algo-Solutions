ublic class Solution {
    public int MaxSubArray(int[] nums) {
        int sum= 0;
        int max = nums[0];
        for(int i = 0; i<nums.Length; i++) {
             sum= sum+nums[i];
            if(nums[i]>sum) {
                sum= nums[i];
            }
            if(curr>max) {
                max = sum;
            }
        }
        return max;
    }
}

//Here we are checking if sum is greater than nums[i] i.e current element. if yes than do nothing if no than replace
//sum with current element as we have to get the maximum(this case may arise in case of negtive values). than check if 
//the sum is greater than our max if yes than assign sum value to max. 