using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConstructeurDestructeur.models
{
    internal class ExceptionNameIncorrect : Exception
    {
        public string Message { get; private set; }
        public string Origin { get; private set; }

        public ExceptionNameIncorrect(string message , string origin)
        {
            Message = message;
            Origin = origin;
        }
    }
}
