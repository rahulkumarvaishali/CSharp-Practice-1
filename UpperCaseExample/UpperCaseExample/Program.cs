using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperCaseExample
{
    internal class Program
    {
        static void CheckUpper()
            {
                string str;
                char ch;
                System.Console.Write("Enter the string: ");
                str = System.Console.ReadLine();
                int l = str.Length; 
                for(int i = 0; i < l; i++)
                {
                    ch = str[i];
                    if(char.IsLower(ch))
                    {
                        System.Console.Write(char.ToUpper(ch));
                    }
                    else
                        System.Console.Write(ch);
                }
            }
            static void Main(string[] args)
            {
                CheckUpper();
                System.Console.ReadLine();
            }
        }
    }
