using System;
using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> animalGroups = new Dictionary<string, string>();
            animalGroups["Rhino"] = "Crash";
            animalGroups["Giraffe"] = "Tower";
            animalGroups["Elephant"] = "Herd";
            animalGroups["Lion"] = "Pride";
            animalGroups["Crow"] = "Murder";
            animalGroups["Pigeon"] = "Kit";
            animalGroups["Flamingo"] = "Pat";
            animalGroups["Deer"] = "Herd";
            animalGroups["Dog"] = "Pack";
            animalGroups["Crocodile"] = "Float";

            Dictionary<string, string> lowerAnimalGroups = new Dictionary<string, string>();

            foreach(string animal in animalGroups.Keys)
            {
                lowerAnimalGroups[animal.ToLower()] = animalGroups[animal];
            }


            
            if (!String.IsNullOrEmpty(animalName) && lowerAnimalGroups.ContainsKey(animalName.ToLower()))
            {
                return lowerAnimalGroups[animalName.ToLower()];
            }
            else
            {
                return "unknown";
            }

            

        }
    }
}
