using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kellen
{
	class Pro
	{
		static void Main(string[] args)
		{
			int r;
			int t;
			string a;
			Console.WriteLine("enter two numbers");
			r = Convert.ToInt32(Console.ReadLine());
			t = Convert.ToInt32(Console.ReadLine());

			var olly = new calculator();

			Console.WriteLine("enter an operator");
			a = Console.ReadLine();
			if(a=="+")
			Console.WriteLine("addition: {0}",olly.add(r,t));

			if (a == "-")
				Console.WriteLine("subtraction: {0}", olly.subtruction(r, t));

			if (a == "*")
				Console.WriteLine("multiplication: {0}", olly.multiplication(r, t));

			if (a == "/")
				Console.WriteLine("division: {0}", olly.division(r, t));

			else
				Console.WriteLine("invalid");



			Console.ReadLine();

		}
	}
}
