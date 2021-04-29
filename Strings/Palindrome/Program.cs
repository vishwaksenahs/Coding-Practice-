using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "0P";
            Console.WriteLine(IsPalindrome(s));
        }
        public static bool IsPalindrome(string s)
        {
            var i = 0;
            s = s.ToLower();
            var schar = s.ToCharArray();
            for(var m = 0; m < schar.Length; m++)
            {
                if(!((schar[m]>='a' && schar[m] <= 'z') || (schar[m]>='0' && schar[m]<='9')))
                {
                    schar[m] = ' ';
                }
            }
            string str = new string(schar);
            str=str.Replace(" ", String.Empty);
            var j = str.Length - 1;
            while (i <= j && str.Length>1)
            {
                if (str[i] == str[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
