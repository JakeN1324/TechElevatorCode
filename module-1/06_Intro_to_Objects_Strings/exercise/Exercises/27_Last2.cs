﻿namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return the count of the number of times that a substring length 2 appears in the string and
        also as the last 2 chars of the string, so "hixxxhi" yields 1 (we won't count the end substring).
        Last2("hixxhi") → 1
        Last2("xaxxaxaxx") → 1
        Last2("axxxaaxx") → 2
        */
        public int Last2(string str)
        {



            string lastLetters = str.Substring(str.Length - 2);
            string theRest = str.Substring(0, str.Length - 1);
            int counter = 0;

            if (str.Length >= 0)
            {
                for (int i = 0; i < theRest.Length - 1; i++)
                {
                    if (str.Substring(i, 2) == lastLetters)
                    {
                        counter++;
                    }
                }
            }
            

            return counter;



        }
    }
}
