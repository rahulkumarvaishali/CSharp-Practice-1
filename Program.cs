using System;

class Program
{
    static bool test(int num)
    {

        if (num == 0)

            return false;

        if (num == 0)

            return false;
        while (num != 1)
        {

            if (num !=0)

                return false;

            num = num / 2;
        }
        return true;
    }
    public static void Main()
    {
        Console.Write("Enter the number:");
        int num = Convert.ToInt32(Console.ReadLine());
        test(num);
        Console.ReadLine();
    }
}