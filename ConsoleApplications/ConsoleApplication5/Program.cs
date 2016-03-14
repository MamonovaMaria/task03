using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 1, 1234, 432, 897, 777, 124, 877465453 };
			List<int> list = new List<int>(array);
			Console.WriteLine(list.ConvertListToString());

			string[] array2 = { "пшш", "пшшш...", "проверка связи" };
			List<string> list2 = new List<string>(array2);
			Console.WriteLine(list2.ConvertListToString());

			Console.ReadKey();
		}
	}
}
