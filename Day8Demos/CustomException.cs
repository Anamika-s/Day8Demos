using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Demos
{
    class CustomException : Exception
    {
        public string msg;
        public CustomException(string Message) :  base(Message)
        {
            msg = Message;
        }
    }
}
