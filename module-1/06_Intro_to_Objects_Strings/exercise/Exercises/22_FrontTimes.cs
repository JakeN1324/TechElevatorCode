namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or
        whatever is there if the string is less than length 3. Return n copies of the front;
        FrontTimes("Chocolate", 2) → "ChoCho"
        FrontTimes("Chocolate", 3) → "ChoChoCho"
        FrontTimes("Abc", 3) → "AbcAbcAbc"
        */
        public string FrontTimes(string str, int n)
        {
            string timesN = string.Empty;
            string first3 = string.Empty;
            int copiesNeeded = 0;
            if (str.Length < 3)
            {
                first3 = str.Substring(0);
                
            }
            else
            {
                first3 = str.Substring(0, 3);
                
            }
            
            while (copiesNeeded < n)
            {
                timesN = timesN + first3;
                copiesNeeded++;
            }

            return timesN;
        }

    }
}
