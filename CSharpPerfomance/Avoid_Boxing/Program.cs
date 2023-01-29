using System;

namespace Avoid_Boxing
{
    class Program
    {
        public const int ITERATIONS = 1000000;

        public static void WithoutBoxingTestMethod(int value)
        {
            // do something with the value
        } 
        
        public static void WithBoxingTestMethod(object value)
        {
            // do something with the value
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < ITERATIONS; i++)
            {
                //WithoutBoxingTestMethod(i);
                WithBoxingTestMethod(i);
            }
        }
    }
}
