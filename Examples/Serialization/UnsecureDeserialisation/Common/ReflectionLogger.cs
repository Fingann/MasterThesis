using System;
using System.Diagnostics;

namespace Common
{
    public static class ReflectionLogger
    {
        public static void LogMethod()
        {
            StackTrace stackTrace = new StackTrace();

// get calling method name
            Console.WriteLine(stackTrace.GetFrame(1).GetMethod().Name);
        }
    }
}