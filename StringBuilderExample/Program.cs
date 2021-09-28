using System;
using System.Text;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a string builder object

            //StringBuilder sb = new StringBuilder();
            //or

            StringBuilder sb = new StringBuilder("Hello World!",50);

            //print string using loop
            for(int i=0; i<sb.Length; i++)
            {
                Console.Write(sb[i]);
            }



        }
    }
}
