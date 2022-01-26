namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
        AltPairs("kitten") → "kien"
        AltPairs("Chocolate") → "Chole"
        AltPairs("CodingHorror") → "Congrr"
        */
        public string AltPairs(string str)
        {
            string newWord = string.Empty;
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            for (int i = 0; i < str.Length; i++)
            {
                newWord = newWord + str.Substring(i, 2);
                i = i + 3;



            }

            return newWord;
        }
    }
}
