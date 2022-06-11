using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_inheritances
{
    internal class Program
    {
        static void Main(string[] args)
		{
			//Console.WriteLine("changed for git");
			//invoking car class
			//car car = new car();
			//accessing property
			//car.color();
			Suzuki suzuki = new Suzuki();
			baleno baleno = new baleno();

		}

		class car
		{
			public car()
			{
				Console.WriteLine("This is default car method");
			}

			public void color()
			{
				string color;
				color = "blue";
				Console.WriteLine("Color of the car: " + color);
			}
		}

		class Suzuki : car
		{
			public Suzuki()
			{
				Console.WriteLine("This is suzuki default");
			}
		}

		class baleno : Suzuki
		{
			public baleno()
			{
				Console.WriteLine("This is a suzuki child baleno");
			}
		}

		class swift : Suzuki
		{
			public swift()
			{
				Console.WriteLine("This is a car child");
			}
		}
	}
}
