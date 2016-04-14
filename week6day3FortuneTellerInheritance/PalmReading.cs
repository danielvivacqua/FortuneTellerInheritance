using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6day3FortuneTellerInheritance
{
    class PalmReading : Magic
    {
        //fields

        //properties
        public override bool BlackMagic { get; set; } = true;
        public override string Name { get; set; } = "Palm Reading";
        protected List<string> Phrases { get; set; } = new List<string>();

        //methods
        public void Reader()
        {

        }


        //constructors
        public PalmReading()
        {
            this.PercentEffective = 20;
            this.Price = 13.00M;
            this.Expertise = "beginner";
        }
    }
   
}
