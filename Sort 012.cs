public class Solution {
    public void SortColors(int[] nums) {
        int zero = 0;
        int one = 0;
        int two = 0;
        for(int i= 0; i<nums.Length; i++) {
            if(nums[i]==0) {
                nums[zero] = 0;
                zero++;
} else if (nums[i]==1) {
                one++;
} else  {
                two++;
            }
}
        for(int i = zero; i<nums.Length-two;i++) {
            nums[i]=1;
}
        for (int i = nums.Length-two;i< nums.Length;i++) {
            nums[i] = 2;
        }
    }
}