using System;

public class UsingParamsArray
{
	public static int MultiplicationTable(params int[] nums)
	{
		for (int i = 1; i <= nums.Length; i++)
		{
			for(int j=1; j <= nums.Length; j++)
			{
				Console.WriteLine("{0}x{1}={2}", i, j, i * j);
			}
			Console.WriteLine();		}
		return 0;
	}
	public static void Main()
	{
		int number= MultiplicationTable(1,2,3,4,5,6,7,8,9,10);
	}
}
