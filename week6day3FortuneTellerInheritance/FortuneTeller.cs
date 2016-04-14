using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6day3FortuneTellerInheritance
{
    class FortuneTeller:Employee
    {
        //I'm just setting this up as a regular old class. 
        //Later, I might choose to make it in a game where I inherit from a Human class
        //(and have a customer also inherit from Human), but for our first round, this is great.

        //Properties
        public override string Name { get; set; } = "Esmerelda";
        public override string ExperienceLevel { get; set; } = "beginner";
        public override decimal Price { get; set; } = 40.00M;

        //Methods

        public void Greet()
        {
            Console.WriteLine("Hello! Come in ... I feel a presence about you.");
            Console.WriteLine("Let me see what I have to offer you today.");
        }

        public void Farewell()
        {
            Console.WriteLine("Thank you, and may your future be bright and mysterious.");
        }

        public void Color()
        {
            Console.WriteLine("Please tell me your favorite ROYGBIV color by selecting a letter from ROYGBIV.");
            string userColor = Console.ReadLine();
            string userQuality = "";
            switch(userColor)
            {
                case "R":
                    userQuality = "You have a deep passion in your heart.";
                    break;
                case "O":
                    userQuality = "You are creative and talented.";
                    break;
                case "G":
                    userQuality = "You are successful and intuitive.";
                    break;
                case "B":
                    userQuality = "You have an incredible capacity for love.";
                    break;
                case "I":
                    userQuality = "You are very comforting and compassionate.";
                    break;
                case "V":
                    userQuality = "You're pretty much the best ever.";
                    break;
                default:
                    userQuality = "You're not too bad.";
                    break;
            }
            Console.WriteLine(userQuality);
        }


        /// <summary>
        /// Create a new fortune teller, giving it a name and experience level.
        /// </summary>
        /// <param name="name">The fortune teller's name.</param>
        /// <param name="experienceLevel">A string value (beginner, intermediate, advanced) for this fortune teller.</param>
        //Constructors
        public FortuneTeller(string name, string experienceLevel)
        {
            this.Name = name;
            this.ExperienceLevel = experienceLevel;
        }

        public FortuneTeller()
        {
        }
    }

}
