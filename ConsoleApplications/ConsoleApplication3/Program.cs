using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
		struct Point
		{
			public int x;
			public int y;
			public int z;

			public Point(int x, int y, int z)
			{
				this.x = x;
				this.y = y;
				this.z = z;
			}

			public static Point operator +(Point point1, Point point2)
			{
				return new Point(point1.x + point2.x, point1.y + point2.y, point1.z + point2.z);
			}

			public static Point operator -(Point point1, Point point2)
			{
				return new Point(point1.x - point2.x, point1.y - point2.y, point1.z - point2.z);
			}

		}

        static void Main(string[] args)
        {
			Console.WriteLine("Enter coordinates of the point1 via Enter");
			Point point1 = CreatPoint();

			Console.WriteLine("Enter coordinates of the point2 via Enter");
			Point point2 = CreatPoint();

			Console.Write("Sum of two points is ");
			Print(point1 + point2);

			Console.Write("Difference of two points is ");
			Print(point1 - point2);

			Console.ReadKey();
		}

		static void Print(Point p)
		{
			Console.WriteLine(" ({0}; {1}; {2})", p.x, p.y, p.z);
		}

		static Point CreatPoint()
		{
			int x, y, z;
			do
			{
				try
				{
					x = Convert.ToInt32(Console.ReadLine());
					y = Convert.ToInt32(Console.ReadLine());
					z = Convert.ToInt32(Console.ReadLine());

					break;
				}
				catch (System.FormatException)
				{
					Console.WriteLine("ERROR: You have entered a symbol, not a number. Try enter point again");
				}
			}
			while (true);
			return new Point(x, y, z);

		}

    }
}
