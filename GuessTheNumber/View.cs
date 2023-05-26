using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class View : IView
    {
        private Controller controller;

        public View(Controller controller)
        {
            this.controller = controller;
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("\nI have chosen a number between 1 and 100.");
        }

        public int GetInput()
        {
            Console.Write("\nTake a guess: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void CorrectGuess(int attempts)
        {
            Console.WriteLine(
                "\nCongratulations! You guessed the number correctly!");
            Console.WriteLine("Number of attempts: " + attempts);
        }

        public void IncorrectGuess(int guess, int targetNumber)
        {
            if (guess < targetNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else
            {
                Console.WriteLine("Too high! Try again.");
            }
        }

        public void End()
        {
            Console.WriteLine("\nThank you for playing Guess the Number!");
        }
    }
}