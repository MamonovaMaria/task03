using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
			Regex reg = new Regex(@"\b\B*\w*\d*-*металл-*\B*\w*\d*\b", RegexOptions.IgnoreCase);

			String text = "металл, ультарметаллический объект, МегаМеталл!, ути-металлик, МЕТАААЛ!, МеТаЛл, Металл-неудачник, дрова+бумага!=металл, .Металл/";

			foreach (Match match in reg.Matches(text))
			{
				Console.WriteLine("Однокоренное слово {0}", match);
			}

			Console.ReadKey();
        }
    }
}
