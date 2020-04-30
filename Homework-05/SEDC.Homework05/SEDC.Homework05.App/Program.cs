using SEDC.Homework05.FirstExercise;
using SEDC.Homework05.RacingCars.Models;
using System;

namespace SEDC.Homework05.App
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First Exercise
            Console.WriteLine("Create a dog... Enter parameters for: /nDog's name /nDog's race /nDog's color");
            Dog dog = new Dog(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Console.WriteLine("What is the dog doing: /n Eats /nPlay /n Chase tail");
            string dogActivity = Console.ReadLine();
            if (dogActivity.ToLower() == "eats")
            {
                dog.Eat();
            }
            if (dogActivity.ToLower() == "play")
            {
                dog.Play();
            }
            if (dogActivity.ToLower() == "chase tail")
            {
                dog.ChaseTail();
            }

            Console.ReadLine();
            #endregion

            #region Second Exercise
            Car hyundai = new Car("Hyundai", 120);
            Car mazda = new Car("Mazda", 140);
            Car ferrari = new Car("Ferrari", 280);
            Car porsche = new Car("Porsche", 260);

            Car[] cars = new Car[4] {hyundai, mazda, ferrari, porsche};

            Driver bob = new Driver("Bob", 13);
            Driver greg = new Driver("Greg", 7);
            Driver jill = new Driver("Jill", 11);
            Driver anne = new Driver("Anne", 9);

            Driver[] drivers = new Driver[4] { bob, greg, jill, anne };

            while (true)
            {
                Console.WriteLine("Choose car no.1:");
                for (int i = 0; i < cars.Length; i++)
                {
                    Console.WriteLine($"{i+1}: " + cars[i].Model);
                }
                int firstCarInput = int.Parse(Console.ReadLine());
                Car firstCar = new Car ("test", 1);
                if(firstCarInput == 1)
                {
                    firstCar.Model = hyundai.Model;
                    firstCar.Speed = hyundai.Speed;
                }
                else if(firstCarInput == 2)
                {
                    firstCar.Model = mazda.Model;
                    firstCar.Speed = mazda.Speed;
                }
                else if(firstCarInput == 3)
                {
                    firstCar.Model = ferrari.Model;
                    firstCar.Speed = ferrari.Speed;
                }
                else if (firstCarInput == 4)
                {
                    firstCar.Model = porsche.Model;
                    firstCar.Speed = porsche.Speed;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 4");
                    continue;
                }
                Console.WriteLine("Choose driver no.1:");
                for (int i = 0; i < drivers.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: " + drivers[i].Name);
                }
                int firstDriverInput = int.Parse(Console.ReadLine());
                Driver firstDriver = new Driver("test", 1);
                if(firstDriverInput == 1)
                {
                    firstDriver.Name = bob.Name;
                    firstDriver.Skill = bob.Skill;
                }
                else if (firstDriverInput == 2)
                {
                    firstDriver.Name = greg.Name;
                    firstDriver.Skill = greg.Skill;
                }
                else if (firstDriverInput == 3)
                {
                    firstDriver.Name = jill.Name;
                    firstDriver.Skill = jill.Skill;
                }
                else if (firstDriverInput == 4)
                {
                    firstDriver.Name = anne.Name;
                    firstDriver.Skill = anne.Skill;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 4");
                    continue;
                }

                firstCar.Driver = firstDriver;


                Console.WriteLine("Choose car no.2:");
                for (int i = 0; i < cars.Length; i++)
                {
                    if(firstCar.Model != cars[i].Model)
                    {
                        Console.WriteLine($"{i + 1}: " + cars[i].Model);
                    }
                    
                }
                int secondCarInput = int.Parse(Console.ReadLine());
                Car secondCar = new Car("test", 1);
                if (secondCarInput == 1)
                {
                    secondCar.Model = hyundai.Model;
                    secondCar.Speed = hyundai.Speed;
                }
                else if (secondCarInput == 2)
                {
                    secondCar.Model = mazda.Model;
                    secondCar.Speed = mazda.Speed;
                }
                else if (secondCarInput == 3)
                {
                    secondCar.Model = ferrari.Model;
                    secondCar.Speed = ferrari.Speed;
                }
                else if (secondCarInput == 4)
                {
                    secondCar.Model = porsche.Model;
                    secondCar.Speed = porsche.Speed;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 4");
                    continue;
                }
                Console.WriteLine("Choose driver no.2:");
                for (int i = 0; i < drivers.Length; i++)
                {
                    if(firstDriver.Name != drivers[i].Name)
                    {
                        Console.WriteLine($"{i + 1}: " + drivers[i].Name);
                    } 
                }
                int secondDriverInput = int.Parse(Console.ReadLine());
                Driver secondDriver = new Driver("test", 1);
                if (secondDriverInput == 1)
                {
                    secondDriver.Name = bob.Name;
                    secondDriver.Skill = bob.Skill;
                }
                else if (secondDriverInput == 2)
                {
                    secondDriver.Name = greg.Name;
                    secondDriver.Skill = greg.Skill;
                }
                else if (secondDriverInput == 3)
                {
                    secondDriver.Name = jill.Name;
                    secondDriver.Skill = jill.Skill;
                }
                else if (secondDriverInput == 4)
                {
                    secondDriver.Name = anne.Name;
                    secondDriver.Skill = anne.Skill;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 4");
                    continue;
                }
                secondCar.Driver = secondDriver;

                // How can i call a method some different way ??

                RacingCars.Methods.RaceMethod test = new RacingCars.Methods.RaceMethod();
                test.RaceCars(firstCar, secondCar);

                Console.WriteLine("Do you want to restart the game ? y/n");
                string restartInput = Console.ReadLine();
                if(restartInput.ToLower() == "n")
                {
                    break;
                }

                if(restartInput.ToLower() == "y")
                {
                    continue;
                }
            }
            #endregion
            Console.ReadLine();
        }
    }
}
