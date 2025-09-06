using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
     class Games // here we have our class for the objects games
    {

        public string name; // we create the caracteristics of our objects
        public int price;   // *important* we have to set the fields and method to public to acess them in the main program

        public void buy() // we create the actions that can happen with our games

        //here we will buy the game
        {
            Console.WriteLine("You will buy " + name + " for " + price + "$");
        }
        public void play() // we create the actions that can happen with our games

            //here we will play the game
        {
            Console.WriteLine("You will play " + name);
        }
    }
}
