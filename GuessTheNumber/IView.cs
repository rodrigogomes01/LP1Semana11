using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public interface IView
    {
        void Start();
        int GetInput();
        void CorrectGuess(int attempts);
        void IncorrectGuess(int guess, int targetNumber);
        void End();
    }
}