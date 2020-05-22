using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayzatTask
{
    class Program
    {

        static void Main(string[] args)
        {
            Validate _validate = new Validate();
            int _balls = 0;
            try
            {
                replay:
                Console.Clear();
                Console.WriteLine("Input Number of Balls in a Bag:");

                if (_validate.CheckInt(Console.ReadLine(), out _balls))
                {
                    if (_validate.GreaterThan(_balls))
                    {
                        Console.WriteLine("Reuslt Balls :");
                        Console.WriteLine(Calculate.totalWays(_balls));
                        Console.WriteLine("=========================");
                        Calculate.printAllUniqueParts(_balls);
                        Console.ReadKey(); goto replay;
                        

                    }
                    else
                        Console.WriteLine("Number of Balls in the Bag are 0 cannot remove anything.");
                }
                else
                    Console.WriteLine("Only Numbers are accepted for Input of Balls in a Bag");


                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
            }



        }

        
    }
}
