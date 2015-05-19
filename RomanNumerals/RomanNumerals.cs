using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class ConvertNumber
    {
        private string OneToEight(int num)
        {
            string number = "";

            number = (num <= 3) ? number = String.Concat(Enumerable.Repeat("I", num))
                   : (num == 4) ? number = "IV"
                   : (num == 5) ? number = "V"
                   : number = "";

                   if (num > 5 && num < 9)
                   {
                       int SpareNumber = num - 5; number = Convert(5) + Convert(SpareNumber);
                   }

            return number;
        }


        public string Convert(int num)
        {
            string number = "";

            number = OneToEight(num);
            
            if (num == 9)
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
