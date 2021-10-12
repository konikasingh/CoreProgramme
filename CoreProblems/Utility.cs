using System;

namespace CoreProblems
{
    class Utility
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the choice from 1 to 10");
            Console.WriteLine(" 1.FlipCoin\n 2.LeapYear\n 3.Fibonacci\n 4:Harmonic Number\n 5:Prime Factor\n 6:Quoitient Remainder\n 7:Swapping\n 8:Even Odd\n 9:Vovels Consonent\n 10:Lagest Of Three Number\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    FlipCoin flip = new FlipCoin();
                    flip.CoinnFlip();
                    break;

                case 2:
                    LeapYear leap = new LeapYear();
                    leap.leapYear();
                    break;

                //case 3:
                    //LeapYear leap = new LeapYear();
                    //leap.leapYear();
                    //break;

                case 4:
                    HarmonicNumber harmonic = new HarmonicNumber();
                    harmonic.harmonicFunction();
                    break;

                case 5:
                    PrimeFactor prime = new PrimeFactor();
                    prime.primeFactor();
                    break;

                case 6:
                    QuoitientRemainder quoitient = new QuoitientRemainder();
                    quoitient.quoitientRemainder();
                    break;

                case 7:
                    Swap s = new Swap();
                    s.swap();
                    break;

                case 8:
                    EvenOdd e = new EvenOdd();
                    e.evenOdd();
                    break;

                case 9:
                    VovelConsonent vocon = new VovelConsonent();
                    vocon.vovelConsonent();
                    break;

                case 10:
                    Largest large = new Largest();
                    large.largest();
                    break;


                default:
                    Console.WriteLine("Invalid Option");
                    break;


            }
        }
    }
}
