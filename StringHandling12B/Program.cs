using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling12B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Be familiar with and be able to use:
            string aString = "This is a string";
            //length
            Console.WriteLine(aString.Length);

            //position
            Console.WriteLine(aString[0]);
            Console.WriteLine(aString[aString.Length-1]);
            for (int i = 0; i < aString.Length; i++)
            {
                Console.WriteLine(aString[i]);
            }
            //substring
            Console.WriteLine(aString.Substring(4));
            Console.WriteLine(aString.Substring(3, 8));
            // Console.WriteLine(aString.Substring(6, 12)); went past end of string

            //concatenation
            Console.WriteLine("the value of my string is " + aString);
            Console.WriteLine("a string is " + aString + "!");
            Console.WriteLine($"this is a string {aString} look at it!");
            Console.WriteLine($"{aString} {aString}");
            Console.WriteLine("Using parameters to join {0}", aString);
            string first = "First String";
            string second = "Second String";
            Console.WriteLine("using + to join" + first + " " + second);
            Console.WriteLine($"using string formatter {first} {second}");
            Console.WriteLine("Using parameters, {0} {1}",first,second); 

            

            //character → character code
            char aChar = 'A';
            Console.WriteLine(Convert.ToInt32(aChar));
            aChar = '1';
            Console.WriteLine(Convert.ToInt32(aChar));

            string personName;
            Console.Write("Enter your name: ");
            personName = Console.ReadLine();
            for (int i = 0;i < personName.Length;i++)
            {
                Console.WriteLine(Convert.ToInt32(personName[i]));
            }


            //character code → character
            Console.WriteLine(Convert.ToChar(65));
            for (int i = 65; i < 91; i++)
            {
                Console.Write(Convert.ToChar(i));
            }
            Console.WriteLine();
            //string conversion operations.
            //Expected string conversion operations:

            //string to integer
            int numInput;
            Console.Write("Enter a number: ");
            numInput =Convert.ToInt32( Console.ReadLine());

            //string to float
            double floatInput;
            Console.Write("Enter a float number: ");
            floatInput = Convert.ToDouble( Console.ReadLine());

            //integer to string
            Console.WriteLine(numInput);
            Console.WriteLine(numInput.ToString() + " is the number");
            Console.WriteLine(numInput.ToString().Length);
            Console.WriteLine(Convert.ToString(numInput));

            //float to string
            Console.WriteLine(floatInput.ToString());
            Console.WriteLine(Convert.ToString(floatInput));
            //date / time to string
            DateTime d = DateTime.Now;
            Console.WriteLine(d.ToString());
            //string to date / time.
            string DOB = "21/11/1999";
            DateTime DOBasADate = Convert.ToDateTime(DOB);
            Console.WriteLine(DOBasADate.DayOfWeek);


        }
    }
}
