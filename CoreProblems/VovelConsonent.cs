/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CoreProblems
{ 
  public class VovelConsonent
  {
    public void vovelConsonent()
    {
        char ch;
        Console.Write("\n\n");
        Console.Write("check whether the input alphabet is a vowel or not:\n");
        Console.Write("-----------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input an Alphabet (A-Z or a-z) : ");
        ch = Convert.ToChar(Console.ReadLine().ToLower());
        int i = ch;
        if (i >= 48 && i <= 57)
        {
            Console.Write("You entered a number, Please enter an alpahbet.");
        }
        else
        {
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("The Alphabet is not a vowel");
                    break;
            }
        }
        Console.ReadKey();
    }
  }
}*/

using System;

namespace CoreProblems
{
    public class VovelConsonent
    {
        public void vovelConsonent()
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());


            // Condition for vowel checking
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine(ch + " is Vowel.");

            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is Consonant.");
            }

            Console.ReadLine();
        }
    }
}