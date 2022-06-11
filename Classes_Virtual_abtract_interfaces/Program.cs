using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Virtual_abtract_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
		{
			addition addition = new addition();
			Console.WriteLine("addition is : " + addition.add());
			//function args
			Console.WriteLine("addition is : " + addition.add(10, 15));

			//Virtual
			swift swift = new swift();
			swift.color();
			swift.regno = 2345;
			Console.WriteLine("The Registration no is: " + swift.regno);
			//sealed
			suv suv = new suv();
			//static
			tuv.display();


		}

		class addition
		{
			internal int add()
			{
				int a = 5;
				int b = 6;
				int c = a + b;

				return c;
			}

			internal int add(int a, int b)
			{
				int c = a + b;

				return c;
			}
		}


		class car
		{
			public car()
			{
				Console.WriteLine("This is default car method");
			}

			public virtual void color()
			{
				string color;
				color = "blue";
				Console.WriteLine("Color of the base class car: " + color);
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
			public int regno;
			// Encapsulation
			public int RegNo
			{
				get { return regno; }
				set { regno = value; }
			}

			public override void color()
			{
				string color;
				color = "white";
				base.color();
				Console.WriteLine("Color of the child class car: " + color);
			}
		}

		// Abstract class
		abstract class vehicle
		{
			public int a;

			public void type()
			{
				Console.WriteLine("Vehicles: ");
			}

			abstract public void getid();
		}

		class transport : vehicle
		{
			public override void getid()
			{
				Console.WriteLine("this is abstract class");
			}
		}

		//interfaces

		interface Itransport
		{
			//int a cannot have fields
			int ID { get; set; }

			void Ivehicle1();
			void Ivehicle2();
		}

		class interfaces : car, Itransport
		{

			public int ID
			{
				get { return ID; }
				set { ID = value; }
			}

			public void Ivehicle1()
			{
				Console.WriteLine("Hey");
			}
			public void Ivehicle2()
			{
				Console.WriteLine("Hey");
			}

		}

		//sealed classes cannot be inherited
		sealed class suv : car
		{
			string str;
			public suv()
			{
				Console.WriteLine("this is sealed class");
			}
		}

		//static class

		static class tuv
		{
			static string name;
			public static void display()
			{
				Console.WriteLine("This is static class abstract+sealed");
			}
		}
	}
}
