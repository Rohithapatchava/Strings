using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "hello";
            Console.WriteLine(data);
            string a = data.Insert(5, "My");
            string bn = "you are so nice";
            string cd = "you are so nice";
            Console.WriteLine(a);
            Console.WriteLine(string.Concat(a, bn,cd));
            string up = data.ToUpper();
            string lc = up.ToLower();
            Console.WriteLine("substring is {0}", bn.Substring(4, 4));
            Console.WriteLine("{0}\n{1}", up, lc);
            string[] names = new string[] { "rohitha", "sarah", "supraja", "sucharitha", "prasanna" };
            foreach(string st in names)
            {
                Console.WriteLine(st);
            
            }
            string allnames = string.Join(",", names);
            Console.WriteLine(allnames);
            string s1 = "welcome to c sharp";
            string[] words = s1.Split();
            foreach(string s in words)
            {
                Console.WriteLine(s);
            }
            string nstr = string.Copy(s1);
            Console.WriteLine("copied string is {0}",nstr);
            int i = s1.IndexOf("to");
            Console.WriteLine("index of  is {0}", i);
            int l = s1.Length;
            Console.WriteLine("length of the string "+l);
            int c = string.Compare("hello", "world");
            Console.WriteLine("comparision is" + c);
            words.Reverse();
            foreach(string w in names)
            {
                Console.WriteLine(w);
            }
        }
    }
}
