using System;

namespace NeedleHaystack_strStr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrStr("mississippi", "issipi"));
        }
        public static int StrStr(string haystack, string needle)
        {
            var r = -1;
            if ((haystack.Length == 0 && needle.Length == 0) || needle.Length == 0)
            {
                return 0;
            }
            if (haystack.Length < needle.Length)
            {
                return -1;
            }
            for (var i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    if (compare(i, haystack, needle))
                    {
                        return i;
                    }
                }
            }
            return r;
        }
        public static bool compare(int m, string haystack, string needle)
        {
            var nlen = needle.Length;
            var hlen = haystack.Length;
            if (hlen - m >= nlen)
            {
                for(var i = 0; i < nlen; i++)
                {
                    if (haystack[m] != needle[i])
                    {
                        return false;
                    }
                    else
                    {
                        m++;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
