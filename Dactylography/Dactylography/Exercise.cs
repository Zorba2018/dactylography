using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dactylography
{
        public class Exercise
        {
            public string text;

            public Statistics highScore;

            public Statistics lastScore;

            public void updateBest()
            {
                
                {
                    if (highScore.correct < lastScore.correct) highScore.correct = lastScore.correct;
                    if (highScore.wpm < lastScore.wpm) highScore.wpm = lastScore.wpm;
                    if (highScore.wrong == -1 || highScore.wrong > lastScore.wrong) highScore.wrong = lastScore.wrong;
                    //checking if number of wrongly pressed letters is -1, because that means the exercise was never finished
                }
            }

            public string printFormatted()
            {

                StringBuilder sb = new StringBuilder("Najbolji rezultat:\n");
                sb.Append(highScore.printFormatted());
                sb.Append("\nTrenutni rezultat:\n");
                sb.Append(lastScore.printFormatted());
                return sb.ToString();
            }

        }


}
