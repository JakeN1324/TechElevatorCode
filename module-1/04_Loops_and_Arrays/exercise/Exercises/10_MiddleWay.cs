namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 2 int arrays, a and b, each length 3, return a new array length 2 containing their middle
         elements.
         MiddleWay([1, 2, 3], [4, 5, 6]) → [2, 5]
         MiddleWay([7, 7, 7], [3, 8, 0]) → [7, 8]
         MiddleWay([5, 2, 9], [1, 4, 5]) → [2, 4]
         */
        public int[] MiddleWay(int[] a, int[] b)
        {
            int aMiddle = a[1];
            int bMiddle = b[1];
            int[] middlesArray = new int[2] { aMiddle, bMiddle };
            return middlesArray;
        }
    }
}
