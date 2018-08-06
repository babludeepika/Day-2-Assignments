using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class ZeroValueException:Exception
    {
        string msg;
       public ZeroValueException()
        {
            msg = "the result is negative";
        }
        public ZeroValueException(string m)
        {
            msg = m;
        }
        public override string Message
        {
            get
            {
                return msg;
            }
            
        }

    }
}
