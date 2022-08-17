using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerCaseExample
{
    internal class Program
    {
        static void CheckLower()
        {
            string str;
            char ch;
            System.Console.Write("Enter the string: ");
            str = System.Console.ReadLine();
            int l = str.Length;
            for (int i = 0; i < l; i++)
            {
                ch = str[i];
                if (char.IsUpper(ch))
                {
                    System.Console.Write(char.ToLower(ch));
                }
                else
                    System.Console.Write(ch);
            }
        }
        static void Main(string[] args)
        {
            CheckLower();
            System.Console.ReadLine();
        }
    }
}
//  Program Output 
//  Enter the string: AbHIsHEk
// abhishek

