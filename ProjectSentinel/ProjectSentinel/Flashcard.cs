using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSentinel
{
    public class Flashcard
    {

        private string flashcardTitle, flashcardDescription;
        private bool correct = false;

        public Flashcard()
        {
        }

        public void isCorrect()
        {
            this.correct = true;
        }
    }
}
