using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6day3FortuneTellerInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //I haven't touched this today. You'll see that it's the same as yesterday's code.
            //I've been focusing on creating classes and making the right classes inherit from the
            //right parents. class Program, Main method is where I sometimes get tripped up. Ever
            //since we've started Object Oriented Programming, coming up with Objects and building
            //classes has felt relatively easy to me. Then when I try to think of how to get them to
            //work here in the Main method, I get all forgetty. So this is where my refresher on 
            //Methods will come in handy.


            //our game will start here
            //let's create a fortune teller
            FortuneTeller fortuneTeller = new FortuneTeller();
            CrystalBall crystalBall = new CrystalBall();

            fortuneTeller.Greet();

            fortuneTeller.StartService((Service)crystalBall); //talk about the service that's being performed

            //This is the only thing I changed yesterday. I had my fortune teller provide information
            //based on my user's favorite ROYGBIV color. So it turns out I am capable of buiilding Methods ...
            //I just need to practice it WAY more.
            fortuneTeller.Color();

            crystalBall.Work(); //run it (do the service)

            crystalBall.Show(); //display it (state results of the service)

            crystalBall.StateEffectiveness(); //state effectiveness of service.

            fortuneTeller.Farewell(); //say goodbye.
        }
    }
}
