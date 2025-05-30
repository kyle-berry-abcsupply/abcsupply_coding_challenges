// Global using directives for .NET 8
global using System;
global using System.Collections.Generic;
global using System.Linq;

namespace MagicIndex
{
    public class Magic
    {
        /*
        * A Magic Index is defined as an element in an array whose value equals its index.

        * Example: A = [5,7,2,4,8]  A[2] = 2

        * Assume a sorted array containing distinct values.  Write an algorithm to determine if the given array contains a Magic Index.

        * Example Inputs: 
        * [-10, -8, 2, 5, 12] -> true
        * [-5, -4, -3, -2, -1] -> false
        * [ 10, 20, 30, 40] -> false
        */
        public bool ContainsMagicIndex(List<int> sortedArray)
        {
            ArgumentNullException.ThrowIfNull(sortedArray); // Added for nullable reference types
            return false;
        }
    }
}