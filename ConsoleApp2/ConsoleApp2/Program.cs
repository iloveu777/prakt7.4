using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            WriteLine("введите строку с цифрами:");
            string st = ReadLine();

            //https://metanit.com/sharp/tutorial/7.4.php
            string st1 = Regex.Replace(st, @"\d+", "");

            WriteLine(st1);*/

            //2.9
            WriteLine("Введите сообщение:");
            string st = ReadLine();
            string[] words = st.Split(new char[] { ' ' });
            Array.Sort(words);
            WriteLine("Слова в алфавитном порядке:");
            foreach (string word in words)
            {
                WriteLine(word);
            }

            ReadKey();
        }
    }
}
