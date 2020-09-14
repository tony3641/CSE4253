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
            char[] separators = new char[] { ',', '.', ':' ,';','!','?',' ','\n','[',']','"','\'','(',')'}; //declare separators
            String[] words = new String[1000];
            String clipStr="";
            bool hasString = Clipboard.ContainsText();

            if (hasString)//if the clipboard is not empty
            {
                clipStr = Clipboard.GetText(TextDataFormat.UnicodeText);
                words = clipStr.Split(separators, 1000, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray(); //get unique words
                Array.Sort(words);

                foreach (var item in words) //traverse the array
                {
                    foreach (var sep in separators)
                    {
                        if (item.Contains(sep))
                        {
                            item.Remove(sep); //remove any separator from the string
                        }
                    }
                    Console.WriteLine(item.ToLower());
                }
            }
            
            Console.ReadKey();
        }
    }
}
