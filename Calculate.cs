using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayzatTask
{
	/// <summary>
	/// Calculation
	/// </summary>
    public class Calculate
    {
		/// <summary>
		/// ways
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static int totalWays(int n)
		{
			// create an array of n+1 size for storing solutions 
			
			int[] lookup = new int[n + 1];

			// base case: 1 way (with no balls)
			lookup[0] = 1;

			// There is only 1 way to reach the 1st one ball
			lookup[1] = 1;

			// There are 2 ways to reach the 2nd balls
			lookup[2] = 2;

			// Fill the lookup table in bottom-up manner
			for (int i = 3; i <= n; i++)
			{
				lookup[i] = lookup[i - 2] + lookup[i - 1];
              

            }

			return lookup[n];
		}


        public static void printArray(int[] p, int n)
        {

            for (int i =0 ; i < n; i++)
            {
               
                Console.Write(" " + p[i] + " ");
            }
               

            Console.WriteLine();
        }

        // Function to generate all unique  
        // partitions of an integer 
        public static void printAllUniqueParts(int n)
        {

            // An array to store a partition 
            int[] p = new int[n];

            // Index of last element in a  
            // partition 
            int k = 0;

            // Initialize first partition as  
            // number itself 
            p[k] = n;

            // This loop first prints current  
            // partition, then generates next 
            // partition. The loop stops when  
            // the current partition has all 1s 
            while (true)
            {

                // print current partition 
                printArray(p, k + 1);

                // Generate next partition 

                // Find the rightmost non-one  
                // value in p[]. Also, update  
                // the rem_val so that we know 
                // how much value can be  
                // accommodated 
                int rem_val = 0;

                while (k >= 0 && p[k] == 1)
                {
                    rem_val += p[k];
                    k--;
                }

                // if k < 0, all the values are 1 so 
                // there are no more partitions 
                if (k < 0)
                    return;

                // Decrease the p[k] found above  
                // and adjust the rem_val 
                p[k]--;
                rem_val++;


                // If rem_val is more, then the sorted 
                // order is violated. Divide rem_val in 
                // different values of size p[k] and copy 
                // these values at different positions 
                // after p[k] 
                while (rem_val > p[k])
                {
                    p[k + 1] = p[k];
                    rem_val = rem_val - p[k];
                    k++;
                }

                // Copy rem_val to next position and  
                // increment position 
                p[k + 1] = rem_val;
                k++;
            }
        }


     

     

    }
}
