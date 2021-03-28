using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter a:");
		int a = Convert.ToInt32(Console.ReadLine());
		int x = a;
		Console.WriteLine("Enter b:");
		int b = Convert.ToInt32(Console.ReadLine());
		int y = b;

		while (true)
		{
			if (x == y)
			{
				break;
			}
			else
			{
				if (x < y)
				{
					x = x + a;
				}
				else
				{
					y = y + b;
				}
			}
		}

		Console.WriteLine("result X:" + x);
		Console.WriteLine("result y:" + y);
		Console.WriteLine("result a:" + a);
		Console.WriteLine("result b:" + b);
	}
}