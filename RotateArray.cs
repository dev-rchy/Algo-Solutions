public class Solution {
    public void Rotate(int[] nums, int k) {       
        
        int[] output = new int[nums.Length];
        int length = nums.Length;
        for(int i=0; i<nums.Length; i++) {
            output[(i+k) % length] = nums[i];
        }
        for(int i=0; i<nums.Length; i++) {
            nums[i] = output[i];
        }
    }
}

//Here the main logic is as we have to rotate array number of times the K is,so if see after k rotation the 
//the last of the K-1 vakue will lie on the starting of array so to get them placed directly their we can use
//formula of [(i+k)%length]. in this way it will automatically fill the array on their required position. 