using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StarWarsQuiz
{
    class QuestionManager
    {
        private List<Question> questionList;
        private int currentQuestion;
        public QuestionManager()
        {
            questionList = new List<Question>();
            currentQuestion = -1;

            StreamReader sr = new StreamReader("../../questions.txt");

            string fileRow;
            int rowCounter = 0;
            string text = "";
            string[] choices = new string[4];
            int correctChoice;

            while ((fileRow = sr.ReadLine()) != null)
            {
                if (rowCounter % 6 == 0)
                    text = fileRow;
                else if (rowCounter % 6 == 1 || rowCounter % 6 == 2 || rowCounter % 6 == 3 || rowCounter % 6 == 4)
                    choices[rowCounter % 6-1] = fileRow;
                else
                {
                    correctChoice = int.Parse(fileRow);
                    questionList.Add(new Question(text, choices, correctChoice));
                    choices = new string[4];
                }
                rowCounter++;
            }
        }

        public Question GetNextQuestion()
        {
            currentQuestion++;
            if(currentQuestion<questionList.Count)
            {
                return questionList[currentQuestion];
            }
            else
            {
                return null;
            }
        }

        public void Restart()
        {
            currentQuestion = -1;
        }
    }
}
