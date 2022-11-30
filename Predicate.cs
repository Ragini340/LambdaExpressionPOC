using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionPOC
{
	class Predicate
	{
		public static void Main()
		{
			Predicate<string> isUpper = IsUpperCase;

			bool result = isUpper("hello world!!");

			Console.WriteLine(result);
		}

		public static bool IsUpperCase(string str)
		{
			return str.Equals(str.ToUpper());
		}

	}
}