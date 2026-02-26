using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureIs; 

static class Temperature // here the class must be static
{
    public static void weather(int degree) // the method has to be public if we wanna acess him in another class
    {
        if (degree >= 20)
        {
            Console.WriteLine("It's warm today");
        }
            if (degree >= 30)
            {
                Console.WriteLine("It's very hot today!");
            }
                if (degree <= 10)
                {
                    Console.WriteLine("Today is very cold!");
                }
                    if (degree >= 40)
                    {
                        Console.WriteLine("We're burning?");
                    }
    }
}
