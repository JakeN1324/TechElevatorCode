namespace Exercises
{
    public partial class LogicalBranchingExercises
    {
        /*
         Given a non-negative number "num", return true if num is within 2 of a multiple of 10. Note: (a % b)
         is the remainder of dividing a by b, so (7 % 5) is 2.
         NearTen(12) → true
         NearTen(17) → false
         NearTen(19) → true
         */
        public bool NearTen(int num)
        {
            int result = num % 10;
            if (result = num % 8 || result = num % 9)
            {
                return true;
            }
            
            if (result = num % 11 || result = num % 12)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
