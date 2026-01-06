using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInterfaces.Interfaces
{
    internal interface ILogger
    {
        void Log (string message)
        {
            Console.WriteLine($"message: {message}");
        }
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);  
    }
}
