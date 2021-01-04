using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string text = "What is the name of Luke's home planet?";
            string[] choices = new string[4];
            choices[0] = "Dantooine";
            choices[1] = "Coruscant";
            choices[2] = "Tatooine";
            choices[3] = "Alderaan";
            int correctChoice = 2;
            questionList.Add(new Question(text, choices, correctChoice));
            
            text = "Who is Luke's twin sister?";
            choices = new string[4];
            choices[0] = "Leia";
            choices[1] = "Padmé";
            choices[2] = "Rey";
            choices[3] = "Mon Mothma";
            correctChoice = 0;
            questionList.Add(new Question(text, choices, correctChoice));

            text = "Who is Luke's father?";
            choices = new string[4];
            choices[0] = "Obi-Wan";
            choices[1] = "Darth Vader";
            choices[2] = "Tarkin";
            choices[3] = "Yoda";
            correctChoice = 1;
            questionList.Add(new Question(text, choices, correctChoice));

            text = "What species does Chewbacca belong to?";
            choices = new string[4];
            choices[0] = "Ewok";
            choices[1] = "Rancor";
            choices[2] = "Lasat";
            choices[3] = "Wookee";
            correctChoice = 3;
            questionList.Add(new Question(text, choices, correctChoice));
        }

        public Question GetNextQuestion()
        {
            currentQuestion++;
            if(currentQuestion<=questionList.Count)
            {
                return questionList[currentQuestion];
            }
            else
            {
                return null;
            }
        }

    }
}
