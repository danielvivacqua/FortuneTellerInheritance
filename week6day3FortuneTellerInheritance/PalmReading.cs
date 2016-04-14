using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6day3FortuneTellerInheritance
{
    class PalmReading : Magic
    {
        //I started this yesterday but never finished it. I just wanted to create a second class that
        //inherited from Magic.

        //fields

        //properties
        public override bool BlackMagic { get; set; } = true;
        public override string Name { get; set; } = "Palm Reading";
        protected List<string> Phrases { get; set; } = new List<string>();

        //methods
        //I definitely need a refresher on Methods. My plan for while I'm on my trip
        //is to bring my book and do as much Google research on Methods in C# as possible.
        public void Reader()
        {

        }


        //constructors
        public PalmReading()
        {
            //again, I set these values down here in my default constructor. When I'm playing with this later,
            //I'd like to initialize these values up in my properties section. Mel said it's best practice, or
            //at least the way she prefers to do it, so I think I'm going to take it up as how I do it.
            this.PercentEffective = 20;
            this.Price = 13.00M;
            this.Expertise = "beginner";
        }
    }
   
}
