using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_App_Login
{
     class Games
    {

     public Games (string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        string name;
        int price;

        public void show()
        {
            Console.WriteLine(name + " " + price + "$");
        }

        public void buy()
        {

        }
    }
}
