using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Demos
{
    class ExceptionDemo3
    {
        static void Main()
        {
            int n;
            try {
                Console.WriteLine("Enter No");
                n = Byte.Parse(Console.ReadLine());
                if (n < 0 && n > 255)
                    throw new Exception("No is out of Range");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            }
    }
}
