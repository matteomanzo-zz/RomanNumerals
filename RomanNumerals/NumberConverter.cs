using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
	public class NumberConverter
	{
		public static string Convert(int num)
		{
			if (num >= 1000) return "M" + Convert(num - 1000);
			if (num >= 900) return "CM" + Convert(num - 900);
			if (num >= 500) return "D" + Convert(num - 500);
			if (num >= 400) return "CD" + Convert(num - 400);
			if (num >= 100) return "C" + Convert(num - 100);            
			if (num >= 90) return "XC" + Convert(num - 90);
			if (num >= 50) return "L" + Convert(num - 50);
			if (num >= 40) return "XL" + Convert(num - 40);
			if (num >= 10) return "X" + Convert(num - 10);
			if (num >= 9) return "IX" + Convert(num - 9);
			if (num >= 5) return "V" + Convert(num - 5);
			if (num >= 4) return "IV" + Convert(num - 4);
			if (num >= 1) return "I" + Convert(num - 1);
			return "";
			
		}
	}
}
