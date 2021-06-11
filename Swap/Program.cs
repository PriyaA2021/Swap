using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a,b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap a=" + a + " b =" + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swap a=" + a);
            Console.WriteLine("b=" + b);



        }
    }
}
