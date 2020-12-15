
using System;
using System.Collections.Generic;

namespace python_functions
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	namespace functions
	{
		public static class functions{
		
			public static string print(string print)
			{
				Console.WriteLine(print);
				return "0";
			}
			public static string input(string input)
			{
				Console.Write(input);
				Console.ReadLine();
				return "0";
			}
			public static string str(string str)
			{
				Console.WriteLine(str);
				return "0";
			}
		}
	}
	namespace math
	{
		public static class math{
			public static double Add(double ad1, double ad2)
			{	
				Console.WriteLine(ad1 + ad2);
				return 0;
			}
			public static double Subtract(double sub1, double sub2)
			{
				Console.WriteLine(sub1 - sub2);
				return 0;
			}
		}
	}
	
}
