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
				try
				{
					Console.WriteLine("Enter int number");
					Console.WriteLine("absolute value of int number: {0}", GetAbs(Convert.ToInt32(Console.ReadLine())));
					break;
				}
				catch (System.FormatException)
				{
					Console.WriteLine("ERROR: You have entered a symbol, not a number. Try again");
				}
			}
			Console.ReadKey();
		}

		static void AbsForDouble()
		{
			while (true)
			{
				try
				{
					Console.WriteLine("Enter double number");
					Console.WriteLine("absolute value of double number: {0}", GetAbs(Convert.ToDouble(Console.ReadLine())));
					break;
				}
				catch (System.FormatException)
				{
					Console.WriteLine("ERROR: You have entered a symbol, not a number. Try again");
				}
			}
			Console.ReadKey();
		}

		static void AbsForLong()
		{
			while (true)
			{
				try
				{
					Console.WriteLine("Enter long number");
					Console.WriteLine("absolute value of long number: {0}", GetAbs(Convert.ToInt64(Console.ReadLine())));
					break;
				}
				catch (System.FormatException)
				{
					Console.WriteLine("ERROR: You have entered a symbol, not a number. Try again");
				}
			}
			Console.ReadKey();
		}


		static public int GetAbs(int num)
		{
			if (num < 0)
				return -num;
			else return num;
		}

		static public double GetAbs(double num)
		{
			if (num < 0)
				return -num;
			else return num;
		}

		static public long GetAbs(long num)
		{
			if (num < 0)
				return -num;
			else return num;
		}
    }
}
