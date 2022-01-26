namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string and a non-negative int n, return a larger string that is n copies of the original string.
        StringTimes("Hi", 2) → "HiHi"
        StringTimes("Hi", 3) → "HiHiHi"
        StringTimes("Hi", 1) → "Hi"
        */
        public string StringTimes(string str, int n)
        {
            string copy = string.Empty;
            int lengthNeeded = str.Length * n;
            while (lengthNeeded > copy.Length)
            {
                copy = copy + str;
            }

            return copy;
        }
    }
}
