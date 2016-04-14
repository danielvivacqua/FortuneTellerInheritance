using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6day3FortuneTellerInheritance
{
    class Therapist:Employee
    {
        //fields are under the Invisibility Cloak

        //properties
        public override string Name { get; set; } = "Duane";
        public override string ExperienceLevel { get; set; } = "advanced";
        public override decimal Price { get; set; } = 20.00M;

        //methods
        //I have some ideas about methods that the Employee Therapist would use ...
        // ... but I need a refresher on Methods.

        //constructors
        //Can't think of what else I would need, looking at FortuneTeller for reference.
        //I could create a constructor that allows the user to input the therapist's name
        //and experience level.

    }
}
