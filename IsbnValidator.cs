using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyDeveloper01
{
    public class IsbnValidator
    {
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

            for (int position = 0; position < curatedstring.Length; position++)
            {
                isbnDigits[position] = GetNthDigit(isbnValue, position);
            }

            return isbnDigits;
        }

        private static int GetNthDigit(int number, int place)
        {
            while (place-- > 0)
            {
                number = number / 10;
            }

            return number % 10;
        }

        private static bool ValidateISBN(int[] isbnDigits)
        {
            if (isbnDigits.Length != 10)
            {
                return false;
            }

            int tempValue = 0;

            for (int position = 0; position < 10; position++)
            {
                tempValue += (position + 1) * isbnDigits[position];
            }

            if (tempValue % 11 != 0)
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
