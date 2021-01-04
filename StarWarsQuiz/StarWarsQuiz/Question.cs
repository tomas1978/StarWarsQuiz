using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsQuiz
{
    class Question
    {
        private string questionText;
        private string[] choices;
        private int correctChoice;

        public Question(string newQuestionText, string[] newChoices, int newCorrectChoice)
        {
            questionText = newQuestionText;
            choices = newChoices;
            correctChoice = newCorrectChoice;
        }

        public string QuestionText {
            get { return questionText; }
            set { questionText = value; }
        }

        public string[] Choices
        {
            get { return choices; }
            set { choices = value; }
        }

        public int CorrectChoice
        {
            get { return correctChoice; }
            set { correctChoice = value; }
        }

        public override string ToString()
        {
            string output = this.QuestionText + "\n";
            foreach(string s in this.Choices)
            {
                output += s+" ";
            }
            output += "\n Correct answer: " + this.CorrectChoice + ": " + this.Choices[correctChoice];
            return output;
        }
    }
}
