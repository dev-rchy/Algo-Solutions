using System;
					
public class Program
{
	public static void Main()
	{
		int []arr = {1,0, 1, 0, 1, 0, 0, 1, 1, 1, 0,1,0,0,1};
		SegregateZeroAndOne(arr);
	}
	
	public static void SegregateZeroAndOne(int []s) {
		int count = 0;
		for(int i = 0 ; i<s.Length; i++) {
			if(s[i]==1) {
				s[i]=0;
				count++;
			}
		}
		for (int i = (s.Length - count); i<s.Length;i++) {
			s[i]= 1;
		}
		Console.WriteLine(String.Join(",", s));
	}
}

//Here the main logic is just convert all the one to zero and keep the count of conversion. After that from that count
//to last index of array just fill it with 1. so we will not be using any extra space here.