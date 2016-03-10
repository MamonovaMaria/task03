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

			public Point(int X, int Y, int Z)
			{
				x = X;
				y = Y;
				z = Z;
			}

			public static Point operator +(Point point1, Point point2)
			{
				Point resultPoint;
				resultPoint.x = point1.x + point2.x;
				resultPoint.y = point1.y + point2.y;
				resultPoint.z = point1.z + point2.z;
				return resultPoint;
			}
			public static Point operator -(Point point1, Point point2)
			{
				Point resultPoint;
				resultPoint.x = point1.x - point2.x;
				resultPoint.y = point1.y - point2.y;
				resultPoint.z = point1.z - point2.z;
				return resultPoint;
			}

		}

        static void Main(string[] args)
        {
			Point point1;
			Point point2;
			int X1, X2, Y1, Y2, Z1, Z2;

			Console.WriteLine("Enter coordinates of the point1");
			do
			{
				try
				{
					X1 = Convert.ToInt32(Console.ReadLine());
					Y1 = Convert.ToInt32(Console.ReadLine());
					Z1 = Convert.ToInt32(Console.ReadLine());

					break;
				}
				catch (System.FormatException)
				{
					Console.WriteLine("ERROR: You have entered a symbol, not a number. Try enter point again");
				}
			}
			while (true);
			point1 = new Point(X1, Y1, Z1);

			Console.WriteLine("Enter coordinates of the point2");
			do
			{
				try
				{
					X2 = Convert.ToInt32(Console.ReadLine());
					Y2 = Convert.ToInt32(Console.ReadLine());
					Z2 = Convert.ToInt32(Console.ReadLine());

					break;
				}
				catch (System.FormatException)
				{
					Console.WriteLine("ERROR: You have entered a symbol, not a number. Try enter point again");
				}
			}
			while (true);
			point2 = new Point(X2, Y2, Z2);

			Point resultPoint = point1 + point2;
			Print(resultPoint);

			Console.ReadKey();
		}

		static void Print(Point p)
		{
			Console.WriteLine("Point is ({0}; {1}; {2})", p.x, p.y, p.z);
		}
    }
}
