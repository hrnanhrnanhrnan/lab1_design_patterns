using lab1_designpatterns.Abstractions;
using System;

namespace lab1_designpatterns
{
    //Thread-safe Singleton class using locks that implements the ILogger interface
    public sealed class Logger : ILogger
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
                //the lock makes sure that the get method is synchronized,
                //so that only one thread can access it at any given point of time
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

        //implements the interface method which just simulates logging the details
        //that is passed in through the parameter by writing it to the console
        public void Log(string details)
        {
            Console.WriteLine($"Logging: {details}");
        }
    }
}
