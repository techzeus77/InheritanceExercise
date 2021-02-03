﻿using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE - Create a class Animal
            // give this class 4 members that all Animals have in common


            // DONE - Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // DONE - Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myBird = new Bird();
            myBird.WingColor = "Blue";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.BeakLength = 3.5;




            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var lizard = new Reptile()
            {

                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "Swamp",
                CanGrowTail = true,


            };

            var myAnimals = new Animal[] { myBird, lizard };
            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive; {animal.IsAlive}");
                Console.WriteLine($"Age; {animal.Age} years old");
                Console.WriteLine($"It has {animal.LegCount} legs");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
                Console.WriteLine($"");

            }




        }
    }
}
