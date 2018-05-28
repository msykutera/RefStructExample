using System;

namespace RefStructExample
{
    public struct Example
    {
        public int Index { get; private set; }

        public void IncreaseIndex() => Index += 1;
    }

    class Program
    {
        static void NonRefMethod(Example example) => example.IncreaseIndex();

        static void RefMethod(ref Example example) => example.IncreaseIndex();

        static void Main(string[] args)
        {
            var nonRefExample = new Example();
            var refExample = new Example();

            for (var i = 0; i < 10000000; i++)
            {
                NonRefMethod(nonRefExample);
                RefMethod(ref refExample);
            }

            Console.WriteLine(nonRefExample.Index);
            Console.WriteLine(refExample.Index);
            Console.ReadLine();
        }
    }
}