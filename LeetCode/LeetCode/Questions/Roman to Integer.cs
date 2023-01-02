using System.Linq;

namespace LeetCode.Questions
{
    class check
    {

        int RomanToInt(string s)
        {
            Dictionary<char, int> roman = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
            int count = 0;
            int prev = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int value = roman[s[i]];
                if (value >= prev)
                {
                    count += value;
                }
                else
                {
                    count -= value;
                }
                prev = value;
            }
            return count;
        }

        //Console.WriteLine(RomanToInt("MCMXCIV"));
    }
}