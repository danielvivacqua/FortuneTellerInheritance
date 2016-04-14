using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6day3FortuneTellerInheritance
{
    class CBT : Therapy
    {
        //fields under Invisibility Cloak

        //properties
        public override string TherapeuticApproach { get; set; } = "Cognitive Behavioral Therapy";
        public override string SessionLength { get; set; } = "45 minutes";
        public override int HealingLevel { get; set; } = 8;

        //haven't gotten to specific Methods and Constructors yet. Trying to be creative with a method that would
        //be used in CBT.

    }
}
