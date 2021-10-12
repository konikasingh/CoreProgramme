using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProblems
{
    class FlipCoin
    {
        //Constant for number of flips and enumeration for heads and tails
        public const int N = 65;
        public enum Flips { Heads, Tails };//Represents heads and tails

        ///generates a number form 0 to 1 and returns Flips.Heads for 0 and Flips.Tails for 1
        static Flips CoinFlip(Random generator)
        {
            if (generator.Next(2) == 0)//generates 0 
            {
                return Flips.Heads;
            }
            return Flips.Tails;
        }

        //prints the content in the array flips and the number of heads and tails and percentage
        static void PrintOutPut(Flips[] flips, int heads, int tails)
        {
            //Iterates through the history of flips
            foreach (Flips flip in flips)
            {
                Console.WriteLine((flip == Flips.Heads ? Flips.Heads : Flips.Tails));
            }

            //Display results.
            Console.WriteLine("Total Flips: {0}", flips.Length);
            Console.WriteLine("Heads: {0} percentage, :{1:p2}.", heads, heads / (double)flips.Length);
            Console.WriteLine("Tails: {0} percentage, :{1:p2}.", tails, tails / (double)flips.Length);
        }

        //Simulates coin flips and prints statistics
        public void CoinnFlip()
        {
            //Local variables 
            Flips[] flips = new Flips[N];//Stores the history of all of the tosses
            Random generator = new Random();// Generates random number values

            int heads = 0;//counts the number of heads
            int tails = 0;//counts the number of tails

            //Generates coin flips and counts heads and tails
            for (int i = 0; i < N; i++)
            {
                if (CoinFlip(generator) == Flips.Heads)
                {
                    heads++;
                    flips[i] = Flips.Heads;
                }
                else
                {
                    tails++;
                    flips[i] = Flips.Tails;
                }
            }

            //Print statistics
            PrintOutPut(flips, heads, tails);

            //Pause the screen
            Console.ReadLine();
        }
    }

}
