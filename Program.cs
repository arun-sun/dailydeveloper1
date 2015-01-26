using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyDeveloper01
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 465277;
            //int place = 0;
            //int digit = GetNthDigit(number, place);
            //Console.WriteLine("Digit = {0}", digit);

            //int[] isbnDigits = new int[10];
            //isbnDigits[9] = 0;
            //isbnDigits[8] = 7;
            //isbnDigits[7] = 4;
            //isbnDigits[6] = 7;
            //isbnDigits[5] = 5;
            //isbnDigits[4] = 3;
            //isbnDigits[3] = 2;
            //isbnDigits[2] = 6;
            //isbnDigits[1] = 9;
            //isbnDigits[0] = 9;
            //bool result = ValidateISBN(isbnDigits);
            //Console.WriteLine("Result = {0}", result);

            string isbnString = "0-7475-3269-9";
            bool result = IsValidISBN(isbnString);
            Console.WriteLine("Result = {0}", result);
        }


        public static bool IsValidISBN(string isbnString)
        {
            int[] isbnDigits = GetISBNDigits(isbnString);

            return ValidateISBN(isbnDigits);
        }

        private static int[] GetISBNDigits(string isbnString)
        {
            string curatedstring = isbnString.Replace("-", "");

            int isbnValue = Convert.ToInt32(curatedstring);

            int[] isbnDigits = new int[curatedstring.Length];

            for(int position = 0 ; position < curatedstring.Length ; position++)
            {
                isbnDigits[position] = GetNthDigit(isbnValue, position);
            }

            return isbnDigits;
        }

        private static int GetNthDigit(int number, int place)
        {
            while(place-- > 0)
            {
                number = number / 10;
            }

            return number % 10;
        }

        private static bool ValidateISBN(int[] isbnDigits)
        {
            if(isbnDigits.Length != 10)
            {
                return false;
            }

            int tempValue = 0;

            for (int position = 0; position < 10; position++)
            {
                tempValue += (position + 1) * isbnDigits[position];
            }
            
            if(tempValue % 11 != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
