using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Controller
    {
        private int targetNumber;
        private int attempts;

        public Controller(int targetNumber)
        {
            this.targetNumber = targetNumber;
        }

        public void Run(IView view)
        {
            view.Start();

            int guess = view.GetInput();
            while (guess != targetNumber)
            {
                attempts++;
                view.IncorrectGuess(guess, targetNumber);
                guess = view.GetInput();
            }

            view.CorrectGuess(attempts);
            view.End();
        }
    }
}