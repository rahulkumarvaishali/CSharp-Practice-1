using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_ULDS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upper, lower, digit, special;
            upper = lower = digit = special = 0;
            string str = "Abhi@108";
            char [] arr = str.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] >= 'A' && arr[i] <= 'Z')
                    upper++;
               else if (arr[i] >= 'a' && arr[i] <= 'z')
                    lower++;
                else if (arr[i] >= '0' && arr[i] <= '9')
                    digit++;
                else
                    special++;
            }
            System.Console.WriteLine("Total Upper is: " + upper);
            System.Console.WriteLine("Total Lower is: " + lower);
            System.Console.WriteLine("Total Digit is: " + digit);
            System.Console.WriteLine("Total Special is: " + special);
            System.Console.ReadLine();
        }
    }
}
