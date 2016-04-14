using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6day3FortuneTellerInheritance
{
    class CrystalBall : Magic
    {
        //straight up field. I really don't need a property. Just using globally so random behaves well.
        private Random random = new Random();

        //properties
        protected List<string> Phrases { get; set; } = new List<string>();
        public override string Name { get; set; } = "Crystal Ball";

        //methods
        public override void Work()
        {
            base.Work();
            //now let's call a method that will get a result for the crystal ball
            this.Result = GetPhrase();
        }

        //Could use a refresher on access modifiers, specifically "protected" and "internal"
        protected void CreatePhrases()
        {
            Phrases.Add("Your best friend will be there for you when you need them.");
            Phrases.Add("I see joy in your near future");
            Phrases.Add("You will soon feel deeply loved.");
            Phrases.Add("I believe you will be successful in all of your endeavors.");
            Phrases.Add("You will soon make a friend who will be in your life forever.");
            Phrases.Add("You will see something adorable today.");
        }

        //let's create an overloaded method now
        internal void CreatePhrases(string phrase)
        {
            Phrases.Add(phrase);
        }

        private string GetPhrase()
        {
            //local variable
            int randomNumber = random.Next(Phrases.Count);
            return Phrases.ElementAt(randomNumber);
        }

        //constructor
        //let's override some of the properties of what we inherited from magic and service here.
        public CrystalBall()
        {
            this.Price = 20.00M;
            this.PercentEffective = 65;
            this.BlackMagic = false;
            this.Expertise = "beginner";
            //I want to call my initializer for phrases.
            CreatePhrases();
        }

    }

}
