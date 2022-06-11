using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
	internal class Program
	{
		public static void Main()
		{
			Console.WriteLine("Hello World");
			int a = 4;
			object b = a;
			int c = (int)b;
			Console.WriteLine("interger: " + a);
			Console.WriteLine("Object: " + b);
			goto skip;

		come:
			Console.WriteLine("Come: " + a);
			Console.WriteLine("Come: " + b);
			goto end;

		skip:
			Console.WriteLine("this is skip");

			goto come;

		end:
			Console.WriteLine("Ending");
		}
	}
}
