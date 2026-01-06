using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTryCatch
{
    internal class MyException : Exception
    {
        public string Message { get; private set; }


        public MyException(string message)
        {
            Message = message;
        }
    }
}
