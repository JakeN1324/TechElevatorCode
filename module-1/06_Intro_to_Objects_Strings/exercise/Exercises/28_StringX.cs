namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            string withoutX = string.Empty;
            
            if (str.Substring(0, 1) == "x")
            {
                withoutX = "x";
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != 'x')
                {
                    withoutX = withoutX + str[i];
                }
                
            }

            if (str.Substring(str.Length - 1) == "x")
            {
                return withoutX + str.Substring(str.Length - 1);
            }
            else
            {
                return withoutX;
            }
            

        }
    }
}
