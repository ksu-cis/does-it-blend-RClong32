using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var b = new Banana();
            var a = new Mango();
            var s = new Strawberry();
            var c = new IceCubes();

            Console.WriteLine(b.Blend());
            Console.WriteLine(a.Blend());
            Console.WriteLine(s.Blend());

            List<IBlendable> fruits = new List<IBlendable>() { b, a, s, c };
            
            foreach (dynamic fruit in fruits)
            {
                Console.WriteLine(fruit.Blend());
            }
        }
    }
}
