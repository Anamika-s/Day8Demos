using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Demos
{
    class ExceptionDemo2
    {
        static void Main()
        {
            int age=0;
            string name= string.Empty;
            try
            {
                Console.WriteLine("Enter Age");
                age = Byte.Parse(Console.ReadLine());
                if (age < 20 || age > 30)
                    throw new CustomException("Age shud be in Range 20 - 30");
                Console.WriteLine("Enter NAme");
                name = Console.ReadLine();
                if (name.Length < 10)
                    throw new CustomException("MIn 10 characters needed");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("NAme is " + name);
            Console.WriteLine("Age is " + age);

        }
    }
        //static void Main()
        //{
        //    int n;
        //    try
        //    {
        //        Console.WriteLine("Enter No");
        //        n = Byte.Parse(Console.ReadLine());
        //        if (n < 0 && n > 255)
        //            throw new Exception("No is out of Range");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
   // }


    //static void Main()
    //{
    //    int num;
    //    int den;
    //    int res = 0;
    //    int[] numArray = new int[10];
    //    try
    //    {
    //        Console.WriteLine("Enter Number");
    //        num = Byte.Parse(Console.ReadLine());
    //        Console.WriteLine("Enter Denominator");
    //        den = Byte.Parse(Console.ReadLine());
    //        res = num / den;
    //        numArray[11] = 10;
    //    }

    //    catch (FormatException ex)
    //    {
    //        Console.WriteLine(ex.Source);
    //        Console.WriteLine(ex.InnerException.ToString());
    //        Console.WriteLine(ex.Message);
    //    }
    //    catch(DivideByZeroException ex)
    //    {
    //        Console.WriteLine(ex.Message);
    //    }
    //    catch(OverflowException ex)
    //    {
    //        Console.WriteLine(ex.Message);
    //    }
    //   catch(IndexOutOfRangeException ex)
    //    {
    //        Console.WriteLine(ex.Message);
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine(ex.Message);
    //    }
    //    Console.WriteLine("The Result is " + res);
    //}
}

