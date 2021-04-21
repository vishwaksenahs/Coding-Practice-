using System;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = new char[] { 'h','e','l','l','o' };
            ReverseString(s);
        }
        public static void ReverseString(char[] s)
        {
            var j = s.Length - 1;
            for (var i = 0; i < s.Length / 2; i++)
            {
                var t = s[i];
                s[i] = s[j];
                s[j] = t;
                j--;
            }
        }
    }
}
