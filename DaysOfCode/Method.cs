using System;
using System.Linq;

namespace DaysOfCode
{
    public class Method
    {
        public Method()
        {
        }


        //        Create a boolean method called Has23 that takes in an integer array “nums”.
        //        Given an int array length 2, return true if it contains a 2 or a 3.
        //has23([2, 5]) → true
        //has23([4, 3]) → true
        //has23([4, 5]) → false
        public bool Has23(int[] nums)
        {
            if (nums.Contains(2) || nums.Contains(3))
            {
                return true;
            }

            return false;
        }
    }
}
