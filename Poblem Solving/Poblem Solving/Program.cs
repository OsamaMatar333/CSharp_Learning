using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poblem_Solving
{
    internal class Program
    {

        static void CheckMethod()
        {
            Console.WriteLine("works fine");
            return;
        }

        static void PalindromeGame()
        {
            Console.WriteLine("Type a number and I'm gonna check if it is palindrome or not");

            string userNumber = Console.ReadLine();
            int stringLength = userNumber.Length;

            Boolean isPalindrome = false;

            for (int i = 0; i < stringLength; i++)
            {
                if (userNumber[i] == userNumber[stringLength - i - 1])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
                

            }

            if (isPalindrome)
            {
                Console.WriteLine("You entered a palindrome number & Salah loves programming");
            }

            else
            {
                Console.WriteLine("You entered a non-palindrome number & Salah loves problem solving");
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            /*
            Random rnd = new Random();
            int myGuess = rnd.Next(0, 100);

            Console.WriteLine("Guess the number I picked");

            int userGuess = int.Parse(Console.ReadLine());


            while (userGuess != myGuess)
            {
                if (userGuess < myGuess)
                {
                    Console.WriteLine("Go higher");
                }

                else if (userGuess > myGuess)
                {
                    Console.WriteLine("Go lower");
                }

                userGuess = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("You win");

           
            */


            CheckMethod();
            
            Console.WriteLine("Type a number and I'm gonna check if it is palindrome or not");

            string userNumber = Console.ReadLine();
            int stringLength = userNumber.Length;
           
            Boolean isPalindrome = false;

            for (int i = 0; i < stringLength; i++)
            {
                if (userNumber[i] == userNumber[stringLength-i-1])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }

                  
            }

            if (isPalindrome)
            {
                Console.WriteLine("You entered a palindrome number & Salah loves programming");
            }

            else
            {
                Console.WriteLine("You entered a non-palindrome number & Salah loves problem solving");
            }
            Console.ReadKey();
        }

       
    }
}
