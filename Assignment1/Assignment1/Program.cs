//Author: Tony Han
//Course: CSE4253
//Date: 9/14/2020


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment1
{
    class Program
    {
        [System.STAThread]
        static void Main(string[] args)
        {
            char[] separators = new char[] { ',', '.', ':' ,';','!','?',' ','\n','[',']','"','\'','(',')'};
            String[] words = new String[1000];
            String clipStr="aslkjf!jfkdsajf.fasdjfl";
            bool hasString = Clipboard.ContainsText();
            if (hasString)
            {
                clipStr = Clipboard.GetText(TextDataFormat.UnicodeText);
            }
            words = clipStr.Split(separators, 1000, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();

            Array.Sort(words);

            foreach (var item in words)
            {
                foreach (var sep in separators)
                {
                    if (item.Contains(sep))
                    {
                        item.Remove(sep);
                    }
                }
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
