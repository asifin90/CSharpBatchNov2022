using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    internal class SampleClass
    {
        public int num1=10;// members of class
        

        /// <summary>
        ///  method with parameter : printing messages
        /// </summary>
        /// <param name="message">This parameter is used to print messag</param>
        public void Print(string message) // method 
        {
            Console.WriteLine(message); 
           
        }

        /// <summary>
        /// method without parameter
        /// </summary>
        public void Demo()
        {
            Console.WriteLine("Hello John");
        }


        public void Addtion(int num1, int num2)
        {
            Console.WriteLine(num1+num2);
        }

    }
}
