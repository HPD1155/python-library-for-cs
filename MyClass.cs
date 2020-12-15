
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
	
}
