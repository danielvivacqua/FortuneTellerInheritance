using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6day3FortuneTellerInheritance
{
    class Employee
    {
        //fields are under Invisibility Cloak

        //properties
        public virtual string Name { get; set; }
        public virtual string ExperienceLevel { get; set; }
        public virtual decimal Price { get; set; }

        //methods
        //I cut and paste this into here. It seemed like every employee could say this, although
        //I might change the script to make it more generic.
        public void StartService(Service service)
        {
            //Stubbed
            Console.WriteLine("For you, my {0}! Yes, perfect. It only costs {1} and that's fine by everyone.", service.Name, service.Price);
        }

        //constructors
        public Employee()
        {

        }
    }
}
