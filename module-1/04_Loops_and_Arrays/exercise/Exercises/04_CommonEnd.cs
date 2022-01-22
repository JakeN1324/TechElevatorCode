namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 2 arrays of ints, a and b, return true if they have the same first element or they have
         the same last element. Both arrays will be length 1 or more.
         CommonEnd([1, 2, 3], [7, 3]) → true
         CommonEnd([1, 2, 3], [7, 3, 2]) → false
         CommonEnd([1, 2, 3], [1, 3]) → true
         */
        public bool CommonEnd(int[] a, int[] b)
        {
            int firstA = a[0];
            int lastA = a[a.Length - 1];
            int firstB = b[0];
            int lastB = b[b.Length - 1];
            if (firstA == firstB || lastA == lastB)
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
