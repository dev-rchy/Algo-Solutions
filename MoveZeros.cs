using System;
					
public class Program
{
	public static void Main()
	{
		int []arr = {4,0,1,0,1,0,3,12};
		MoveZeroes(arr);
	}
	
	public static void MoveZeroes(int[] nums) {
        int temp = 0;
        for (int i = 0; i<nums.Length; i++) { 
            if(nums[i]!=0) {
                nums[temp] = nums[i];
                temp++;
             }
          }
        for(int i=temp;i<nums.Length;i++) {
           nums[i]=0;
           }
	Console.WriteLine(String.Join(",", nums));
      }
}

//Just move non zeroes to starting by maintaining counter and use the same counter to fill the zeroes in the end.
