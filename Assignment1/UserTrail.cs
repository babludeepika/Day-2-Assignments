using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment1
{
    class UserTrail
    {
        
        int var1 = int.Parse(Console.ReadLine());
        int var2 = int.Parse(Console.ReadLine());
        public void Show()
        {
            try { 
            
            if (var1 < 0)
                Console.WriteLine("var1 is less than 0");
            else
                Console.WriteLine("var1 is greater than 0");
            if (var2 < 0)
                Console.WriteLine("var2 is less than 0");
            else
                Console.WriteLine("var2 is greater than 0");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Calculate()
        {
            try
            {
                int result = var1 - var2;
                if (result< 0)
                    throw new ZeroValueException();
                else
                    Console.WriteLine("result =" + (var1-var2));
            }


            catch (ZeroValueException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}








