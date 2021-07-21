using System;

namespace Day8Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int den;
            int res=0;
            try
            {
                Console.WriteLine("Enter Number");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Denominator");
                den = int.Parse(Console.ReadLine());
                 res = num / den;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Its in finally block");
            }
            Console.WriteLine("The Result is " + res);
        }
    }
}