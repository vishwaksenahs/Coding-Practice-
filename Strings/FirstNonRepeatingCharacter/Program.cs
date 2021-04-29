using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstNonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "abababababababababababbbbbbbbbbbbbbbbbbbbbbbb";
            var res = FirstUniqChar(s);
            var r = FrequencySort(s);
            Console.WriteLine(res);
            Console.WriteLine(r);
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
        public static string FrequencySort(string s)
        {
            int[] tally = new int[126];
            StringBuilder res = new StringBuilder();
            Dictionary<char, int> tallys = new Dictionary<char, int>();
            for (var i = 0; i < s.Length; i++)
            {
                tally[s[i]]++;
                if (tallys.ContainsKey(s[i]))
                {
                    tallys[s[i]]++;
                }
                else
                {
                    tallys[s[i]] = 1;
                }
            }
            var values = tallys.Values.ToArray();
            values=values.OrderByDescending(x => x).ToArray();
            for (var i = 0; i < values.Length; i++)
            {
                for(var j = 48; j < 123; j++)
                {
                    if (values[i] == tally[j])
                    {
                        while (tally[j]!=0)
                        {
                            res.Append((char)j);
                            tally[j]--;
                        }
                    }
                }
            }
            return res.ToString(); 
        }
    }
}
