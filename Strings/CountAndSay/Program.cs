using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CountAndSay
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "Hello!";
            //Console.WriteLine(String.Compare(str, "Hello.").GetType());
            //var n = Convert.ToInt32(Console.ReadLine());
            //var arr = new int[n];
            //var line = Console.ReadLine();
            //var numbers = line.Split(' ');
            //var min = Int32.Parse(numbers[0]);
            //var odnum = 0;
            //var fact = 1;
            //var flag = false;
            //for (var i=0;i<n;i++)
            //{
            //    arr[i] = Int32.Parse(numbers[i]);
            //    if (arr[i]>1 && arr[i] % 2 != 0)
            //    {
            //        odnum++;
            //    }
            //    if (arr[i] == 1)
            //    {
            //        flag = true;
            //    }
            //}
            //while (odnum > 1)
            //{
            //    fact = fact * odnum;
            //    odnum--;
            //}
            //if (flag)
            //{
            //    fact += 1;
            //}
            //Console.WriteLine(fact);
            CountAndSay(4);

        }
        public static string CountAndSay(int n)
        {
            Dictionary<int, string> res = new Dictionary<int, string>();
            res[1] = "1";
            //res[2] = "11";
            for (int x = 2; x <= n; x++)
            {
                res[x] = say(x - 1, res);
            }
            return res[n];
        }
        public static string say(int m, Dictionary<int,string> res)
        {
            var str = "";
            var t = res[m];
            t += '$';
            char []s = t.ToCharArray();
            int c = 1;
            for(int j = 1; j < s.Length; j++)
            {
                if (s[j] != s[j - 1])
                {
                    str += c.ToString();
                    str += s[j - 1].ToString();
                    c = 1;
                } else { c++; }
            }
            res[m + 1] = str.ToString();
            return str.ToString();
        }
    }
}
