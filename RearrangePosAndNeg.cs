using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		 int[] arr = { 1,-1, 2,0, -3, 4, 5, 6, -7, 8, 9 };
		RearrangePosNeg(arr);
	}
	
	public static void RearrangePosNeg(int[] a) {
		int count=0; int temp =0;
		for(int i = 0; i<a.Length; i++) {
			if(a[i]<0) {
				temp = a[count];
				a[count] = a[i];
				a[i] = temp;
				count++;
			}
		}
		Console.WriteLine(String.Join(",", a));
	}
}