using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfo
{
    public class UserInterface
    {
        public void Run()
        {
            Console.WriteLine("Welcome to Pet Info");

            Pet dog = new Pet();
            dog.petName = "Bella";
            dog.PetType = "dog";
            dog.PetAge = 4;

            Pet dog2 = new Pet();
            dog2.petName = "Yoshi";
            dog2.SetColor("Black");

            Console.WriteLine(dog.petName + " " + dog.PetType + " " + dog.PetAge + " " + dog.Color);
            Console.WriteLine(dog2.petName);

            Console.ReadLine();

            return;
        }
        
    }
}
