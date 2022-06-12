using lab1_designpatterns.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_designpatterns
{
    public sealed class Logger
    {
        private static readonly object InstanceLock = new();
        private static Logger instance = null;
        private Logger()
        {
        }

        public static Logger GetInstance 
        {
            get
            {
                lock (InstanceLock)
                {
                    if(instance == null)
                    {
                        instance = new Logger();
                    }
                    return instance;
                }
            } 
        }

        public void Log(string details)
        {
            Console.WriteLine($"Logging: {details}");
        }
    }
}
