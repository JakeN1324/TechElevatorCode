namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a non-empty string like "Code" return a string like "CCoCodCode".
        StringSplosion("Code") → "CCoCodCode"
        StringSplosion("abc") → "aababc"
        StringSplosion("ab") → "aab"
        */
        public string StringSplosion(string str)
        {
            string splosion = string.Empty;
            int length = 1;
            while (length <= str.Length)
            {

                splosion = splosion + str.Substring(0, length);
                length++;
            }

            return splosion;
        }
    }
}
