using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6day3FortuneTellerInheritance
{
    class Therapy : Service
    {
        //fields are under Invisibility Cloak

        //properties
        public virtual int HealingLevel { get; set; }
        public virtual string TherapeuticApproach { get; set; }
        public virtual string SessionLength { get; set; }

        //methods

        //constructors
        public Therapy()
        {
            //I realize that this is my default constructor, and I could've set up all of these properties when I
            //initialized the properties above. I just thought I would initialize the properties here because, I don't know
            //why not? I might revisit this later.
            this.HealingLevel = 10;
            this.TherapeuticApproach = "Gestalt";
            this.SessionLength = "50 minutes";
            this.Name = "Therapy";
            this.Price = 20.00M;
            this.Result = "Feel better";
        }

        public Therapy(string therapeuticApproach)
        {
            //I could use a reminder on why, in these constructors, it's a good idea to use "this."
            this.HealingLevel = 10;
            this.TherapeuticApproach = therapeuticApproach;
            this.SessionLength = "50 Minutes";
            this.Name = "Therapy";
            this.Price = 20.00M;
            this.Result = "Feel better";
        }
        
    }
}
