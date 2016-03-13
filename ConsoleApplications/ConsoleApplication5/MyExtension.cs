using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
	static class MyExtension
	{
		public static string ConvertListToString<T>(this IList<T> list)
		{
			StringBuilder r = new StringBuilder("");

			for (int i = 0; i < list.Count - 1; i++)
				r = r.AppendFormat("{0}, ", list[i]);
			r.Append(list[list.Count-1]);

			return r.ToString();
		}
	}
}
