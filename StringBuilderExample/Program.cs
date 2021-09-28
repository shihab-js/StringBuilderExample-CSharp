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

            Console.WriteLine();

            //retrieve string from string builder
            Console.Write(sb.ToString());

            //Append String
            sb.Append("Hi, ");
            sb.AppendLine("World!");

            //Added formated string to string builder
            StringBuilder fString = new StringBuilder("Your Total Cost is: ");
            fString.AppendFormat("{0:C} ", 100);
            Console.WriteLine(fString);

            //insert string
            sb.Insert(5, " C#");
            Console.WriteLine(sb);

            //Removing string from string builder
            sb.Remove(15,10);
            Console.WriteLine(sb);


            //Replace string in stringbuilder
            sb.Replace("C# ", "");
            Console.WriteLine(sb);

        }
    }
}
