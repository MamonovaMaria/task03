using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
			AbsForInt();
			Console.WriteLine();
			AbsForDouble();
			Console.WriteLine();
			AbsForLong();
        }

		static void AbsForInt()
		{
			while (true)
			{
				Console.WriteLine("Enter int number");
				int num;
				if (Int32.TryParse(Console.ReadLine(), out num))
				{
					Console.WriteLine("absolute value of int number: {0}", GetAbs(num));
					break;
				}
				else
					Console.WriteLine("ERROR: You have entered a symbol or violated the border values. Try again");
			}
			Console.ReadKey();
		}

		static void AbsForDouble()
		{
			while (true)
			{
				Console.WriteLine("Enter double number");
				double num;
				if(Double.TryParse(Console.ReadLine(), out num))
				{
					Console.WriteLine("absolute value of double number: {0}", GetAbs(num));
					break;
				}
				else
					Console.WriteLine("ERROR: You have entered a symbol or violated the border values. Try again");
			}
			Console.ReadKey();
		}

		static void AbsForLong()
		{
			while (true)
			{
				Console.WriteLine("Enter long number");
				long num;
				if(Int64.TryParse(Console.ReadLine(), out num))
				{
					Console.WriteLine("absolute value of long number: {0}", GetAbs(num));
					break;
				}
				else
					Console.WriteLine("ERROR: You have entered a symbol or violated the border values. Try again");
			}
			Console.ReadKey();
		}


		static public int GetAbs(int num)
		{
			if (num < 0)
				return -num;
			else 
				return num;
		}

		static public double GetAbs(double num)
		{
			if (num < 0)
				return -num;
			else 
				return num;
		}

		static public long GetAbs(long num)
		{
			if (num < 0)
				return -num;
			else 
				return num;
		}
	}
}

