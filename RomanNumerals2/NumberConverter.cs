using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RomanNumerals2
{
	public class NumberConverter
	{
			public string Convert(int num)
			{
				string number = "";

				if (num <= 3)
				{
					number = String.Concat(Enumerable.Repeat("I", num));
				}
				else if (num == 4)
				{
					number = "IV";
				}
				else if (num == 5)
				{
					number = "V";
				}
				else if (num > 5 && num < 9)
				{
					int SpareNumber = num - 5;
					number = Convert(5) + Convert(SpareNumber);
				}
				else if (num == 9)
				{
					number = "IX";
				}
				else if (num == 10)
				{
					number = "X";
				}
				else if (num.ToString().Contains('5') && num % 10 == 0)
				{
					number = "L";
				} 
				else if (num == 1000) 
				{
					number = "M";
				}

				return number;
			}
	}
}

