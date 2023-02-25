using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 转义字符
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //转义字符
            string c = "He said,\"I'm tired now";
            Console.WriteLine(c);
            char c2 = '\'';
            Console.WriteLine(c2);
            string towLinseString = "The first-Line sentence.\nThe second-Line sectence.";
            Console.WriteLine(towLinseString);
            string s2 = "abc\\def";
            Console.WriteLine(s2);
            //string wrongString="\%";
            //原义字符串
            string verbatimString = @"The first-Line sentence.The second-Line sentence.";
            Console.WriteLine(verbatimString);
        }
    }
}