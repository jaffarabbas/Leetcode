using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Questions
{
    internal class String_to_Integer__atoi_
    {
        public static int MyAtoi(string str)
        {
            // Check for an empty string
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            // Trim leading white spaces
            str = str.TrimStart();

            // Check if the string is empty after trimming white spaces
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            // Check for the sign
            int sign = 1;
            if (str[0] == '+')
            {
                str = str.Substring(1);
            }
            else if (str[0] == '-')
            {
                sign = -1;
                str = str.Substring(1);
            }

            // Check if the string is empty after removing the sign
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            // Check if the first character is a digit
            if (!char.IsDigit(str[0]))
            {
                return 0;
            }

            // Convert the string to integer
            int result = 0;
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    break;
                }
                int digit = c - '0';
                if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7))
                {
                    return sign == 1 ? int.MaxValue : int.MinValue;
                }
                result = result * 10 + digit;
            }

            return result * sign;
        }

        public static void Main()
        {
            string st = "4193 with words";
            Console.WriteLine(MyAtoi(st));
        }
    }
}
