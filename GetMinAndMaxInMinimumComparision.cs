using System;

public class MinMax {
	public int min;
	public int max;
}
public class Program
{
	public static void Main()
	{
		int []arr = {32, 11, 45, 0,1, 93, 54, 78};
		var val = GetMinAndMax(arr);
		Console.WriteLine("Max Val is {0} and Min value is {1}", val.max, val.min);
	}
	
	
	public static MinMax GetMinAndMax(int[] s) {
		MinMax minMax = new MinMax();
		if(s.Length<2) {
			minMax.min = s[0];
			minMax.max = s[0];
		}
		
       if(s[0]>s[1]) {
		   minMax.max = s[0];
		   minMax.min = s[1];
	   } else {
		    minMax.max = s[1];
		   minMax.min = s[0];
	   }
		for (int i = 2; i< s.Length; i++) {
			if(s[i]>minMax.max) {
				minMax.max = s[i];
			} else if (s[i] < minMax.min) {
				minMax.min = s[i];
		}
	}
	return minMax;
    }
}

// Here we have used two variable to store the min and max and compare one by one for min and max.