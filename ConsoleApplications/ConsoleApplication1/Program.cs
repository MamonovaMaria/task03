using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
			Regex reg = new Regex(@"^[a-z][a-z\d]{1,9}$", RegexOptions.IgnoreCase);

			while (true)
			{
				Console.WriteLine("Enter login");
				string login = Console.ReadLine();

				if (reg.IsMatch(login))
				{
					Console.WriteLine("Login correct");
					break;
				}
				Console.WriteLine("Login not correct. Try again");
			}
			Console.ReadKey();
        }
    }
}
