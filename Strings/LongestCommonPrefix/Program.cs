using System;
using System.Collections.Generic;

namespace LongestCommonPrefix
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] strs= new string[]{ "flower", "floy", "flow" };
            Console.WriteLine(LongestCommonPrefix(strs));
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            var res = "";
            if (strs.Length < 1) return "";
            res = strs[0];
            for(var i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(res) != 0)
                {
                    res = res.Substring(0, res.Length - 1);
                    if (res=="") return "";
                }
            }
            return res;
        }
    }
}
