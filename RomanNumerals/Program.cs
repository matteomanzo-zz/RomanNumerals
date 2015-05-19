using System;

namespace RomanNumerals
{
	public class Program
	{
		public static void Main ()
		{
			Console.WriteLine ("Type a number");
			string input = Console.ReadLine ();
			int num = Convert.ToInt32 (input);
			Console.WriteLine (NumberConverter.Convert(num));
		}
	}
}

