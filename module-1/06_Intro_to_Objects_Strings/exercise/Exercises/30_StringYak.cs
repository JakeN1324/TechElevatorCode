namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed.
        The "yak" strings will not overlap.
        StringYak("yakpak") → "pak"
        StringYak("pakyak") → "pak"
        StringYak("yak123ya") → "123ya"
        */
        public string StringYak(string str)
        {
            string withoutYak = string.Empty;
            if (str.Contains("yak"))
            {
                while (str.Contains("yak"))
                {
                    withoutYak = str.Remove(str.IndexOf("yak"), 3);
                }
            }
            else
            {
                withoutYak = str;
            }

            return withoutYak;
        }
    }
}
