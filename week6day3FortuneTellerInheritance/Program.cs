﻿using System;
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
            //our game will start here
            //let's create a fortune teller
            FortuneTeller fortuneTeller = new FortuneTeller();
            CrystalBall crystalBall = new CrystalBall();

            fortuneTeller.Greet();

            fortuneTeller.StartService((Service)crystalBall); //talk about the service that's being performed

            fortuneTeller.Color();

            crystalBall.Work(); //run it (do the service)

            crystalBall.Show(); //display it (state results of the service)

            crystalBall.StateEffectiveness(); //state effectiveness of service.

            fortuneTeller.Farewell(); //say goodbye.
        }
    }
}
