using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstNonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "dddccdbba";
            var res = FirstUniqChar(s);
            Console.WriteLine(res);
        }
        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> tally = new Dictionary<char, int>();
            for(var i= 0;i < s.Length; i++)
            {
                if (tally.ContainsKey(s[i]))
                {
                    tally[s[i]] = 0;
                }
                else
                {
                    tally[s[i]] = 1;
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (tally[(s[i])] == 1)
                    return i;
            }
            return -1;
        }
    }
}
