using System;

namespace Practice103
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Num01;
            Double Num02;
            Double Num03;

            Console.Write("Input your first number: ");
            Num01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input your second number: ");
            Num02 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input your Third number: ");
            Num03 = Convert.ToDouble(Console.ReadLine());
            Double result = (Num01 + Num02 + Num03)/3;
            Console.WriteLine("YOUR RESULT IS " +result);
            
            Console.ReadKey();
        }
    }
}
