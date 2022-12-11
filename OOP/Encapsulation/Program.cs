using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleClass obj = new SampleClass();
            Console.WriteLine(obj.num1);
            obj.Print("Hello John");
            obj.Print("Hello Santosh");
            obj.Print("Hello Santosh");
            obj.Demo();
            obj.Addtion(1, 2);
            obj.Addtion(3, 5);
        }
    }
}
