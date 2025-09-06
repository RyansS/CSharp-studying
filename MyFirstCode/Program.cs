using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; //delcaration of the variable
            x = 100; //putting a value on int

            int y = 200; //we can use this short way to create a variable

            int z = x + y; // we can use the variables as math operators too

            double decimals  = 12.5; // double is the float of the c sharp

            bool online = true; // bool its a variable which determines if something is true or false

            char symbol = '!'; //its just a variable to put symbols and its only one

            string name = "Ryan!"; // string is the variable which we store words or symbols
            string name2 = symbol + name;

            Console.WriteLine("The height of my house is " + decimals + "cm");
            Console.WriteLine("Are you Online? " + online);
            Console.WriteLine("Hello, " + name2);

            string a = "123";
            Console.WriteLine("The value of the string is: " + a);
            Console.WriteLine(a.GetType());

            Console.WriteLine("\n");
            
            int b = Convert.ToInt32(a); // a convert is useful to convert the variable to another
            Console.WriteLine("A= " + b);
            Console.WriteLine(b.GetType()); // the get type is used for get the type of the variable\
            
         
            int h = 10;
            string f = Convert.ToString(h);
            Console.WriteLine(f);




            int apples = 10;
            apples += 2; // its a shortcut to apples + what else number
            int remainder = apples % 2; // this the remainder, he divide a number for the number after the symbol, and shows what remain from that

            double numb = 5.4;
            double random = Math.Pow(numb, 2); //this is the math function. you can use that to use the Power for example, getting a number to power into it
            double sqr = Math.Sqrt(numb); //this is the square root, he's used for get the square root of a number 
            double pi = Math.Round(numb); // the round gets the number without the decimal part, in other words it round the number. there is a way to round from a higher number too using the Math.Ceilling, and the opposite is possible too with the Math.Floor
            double g = Math.Max(numb, apples);
            Console.WriteLine(g);






            Console.ReadKey();
        }
    }
}
