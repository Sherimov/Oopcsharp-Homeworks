using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework05.FirstExercise
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }

        public void Eat()
        {
            Console.WriteLine($"The dog {Name} is now eating");
        }

        public void Play()
        {
            Console.WriteLine($"The dog {Name} is now playing");
        }

        public void ChaseTail()
        {
            Console.WriteLine($"The dog {Name} is now chasing its tail");
        }
    }
}
