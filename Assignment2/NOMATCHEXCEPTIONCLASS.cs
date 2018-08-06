using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class NOMATCHEXCEPTIONCLASS:Exception
    {
        string msg;
        private readonly string message;

        public NOMATCHEXCEPTIONCLASS()
        {
            msg = "THE TWO STRINGS ARE DIFFERENT";
        }
        public NoMatchException()
        {
            msg = message;
        }
        public override string Message
        {
            get
            { return msg; }
        }


    }
}

