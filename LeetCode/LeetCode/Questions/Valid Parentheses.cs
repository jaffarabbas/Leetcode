using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace LeetCode.Questions
{
    internal class Valid_Parentheses
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Pop();
                    if (c == ')' && top != '(' || c == ']' && top != '[' || c == '}' && top != '{')
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }


        public static void Main()
        {
            string st = "()[]{";
            Console.WriteLine(IsValid(st));
        }
    }
}
