using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayzatTask
{
    /// <summary>
    /// Validate Input
    /// </summary>
    public class Validate
    {
      
        /// <summary>
        /// Check if integer
        /// </summary>
        /// <param name="balls"></param>
        /// <param name="NoBalls"></param>
        /// <returns></returns>
        public bool CheckInt(string balls,out int NoBalls)
        {
            return int.TryParse(balls, out NoBalls);
        }

        /// <summary>
        /// Must be greater than 0
        /// </summary>
        /// <param name="NoBalls"></param>
        /// <returns></returns>
        public bool GreaterThan(int NoBalls)
        {
            if (NoBalls > 0 && NoBalls != 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
