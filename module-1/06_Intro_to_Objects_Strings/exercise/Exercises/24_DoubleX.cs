namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
        DoubleX("axxbb") → true
        DoubleX("axaxax") → false
        DoubleX("xxxxx") → true
        */
        public bool DoubleX(string str)
        {
            
            if (str.Contains('x'))
            {
                if (str.Substring(str.IndexOf('x'), 2) == "xx")
                {
                    return true;
                }
                return false;

                
                 
            }
            else
            {
                return false;
            }

            
        }
    }
}
