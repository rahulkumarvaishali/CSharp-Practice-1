using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    internal class Program
    {
        int id;
        String name;
        float salary;
        public Program(int i, String n, float s)
        {
            id = i;
            name = n;
            salary = s;
            Console.WriteLine(i);
            Console.WriteLine(n);
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            Program obj = new Program(10, "Thakur Abhishek Singh", 957.25f);
            Console.ReadLine();
        }
    }
}
