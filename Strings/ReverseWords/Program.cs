using System;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "i love programming very much";
            Console.Write(str);
            var strArray = str.Split(' ');
            var outStr = "";
            for (var i = strArray.Length - 1; i >= 0; i--)
            {
                outStr += strArray[i] + ' ';
            }
            Console.Write(outStr);
        }
    }
}
