using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
		{
			//Console.WriteLine("Array list");
			ALDemo();
			HT();
			SL();
		}

		static void ALDemo()
		{
			//similar to HT and array can be asccessed by key and Index
			//AL: is non generic
			//List Gene : Generic
			ArrayList array = new ArrayList();
			array.Add("Nani");
			array.Add(28);
			array.Add("hyderabad");
			Console.WriteLine("The AL value are");
			foreach (var val in array)
			{
				Console.WriteLine("The value are : " + val);
			}

		}

		static void HT()
		{
			// HT: Non gen,   using DictionaryEntry in foreach
			// Dict Gen : Generic,  using KeyValuepair
			Hashtable ht = new Hashtable();
			ht.Add(0, "Narender");
			ht.Add(1, "Nani");
			ht.Add(2, "B");
			ht.Add(3, 26);

			Console.WriteLine(ht.ContainsKey(2));
			Console.WriteLine(ht.ContainsValue("B"));


			Console.WriteLine("The HT value are");
			foreach (DictionaryEntry de in ht)
			{
				Console.WriteLine("key->" + de.Key + ": value->" + de.Value);
			}

		}

		static void SL()
		{
			SortedList sl = new SortedList();
			sl.Add(0, "Narender");
			sl.Add(1, "Nani");
			sl.Add(2, "reddy");
			sl.Add(3, "B");

			Console.WriteLine(sl.ContainsKey(2));
			Console.WriteLine(sl.ContainsValue("B"));


			Console.WriteLine("The sl value are");
			foreach (DictionaryEntry de in sl)
			{
				Console.WriteLine("key->" + de.Key + ": value->" + de.Value);
			}


			Console.WriteLine("\nAccessing with Icollection\n");
			ICollection keys = sl.Keys;
			ICollection values = sl.Values;
			foreach (var key in keys)
			{
				Console.WriteLine("key->" + key + ": value->" + sl[key]);
			}


		}
	}
}
