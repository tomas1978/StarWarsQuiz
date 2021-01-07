using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsQuiz
{
    public partial class Form1 : Form
    {
        Question question;
        QuestionManager questionManager;
        Button[] choiceButtons;
        int points = 0;
        int questionCounter;
        public Form1()
        {
            InitializeComponent();
            choiceButtons = new Button[4];
            choiceButtons[0] = button1;
            choiceButtons[1] = button2;
            choiceButtons[2] = button3;
            choiceButtons[3] = button4;
            
            questionManager = new QuestionManager();
            question = questionManager.GetNextQuestion();
            questionTextBox.Text = question.QuestionText;

            for (int i=0;i<choiceButtons.Length;i++)
            {
                choiceButtons[i].Text = question.Choices[i];
            }
            questionTextBox.ReadOnly = true;
            questionCounter = 1;
            questionNumberLabel.Text = questionCounter+"/" + questionManager.GetNumberOfQuestions();
            WriteRank();
        }

        public void EnableAllButtons()
        {
            foreach (Button b in choiceButtons)
                b.Enabled = true;
        }

        public void DisableAllButtons()
        {
            foreach (Button b in choiceButtons)
                b.Enabled = false;
        }

        public void WriteRank()
        {
            if (points > 0.9 * questionManager.GetNumberOfQuestions())
                rankLabel.Text = "Rank: Jedi Master";
            else if (points > 0.7 * questionManager.GetNumberOfQuestions())
                rankLabel.Text = "Rank: Jedi";
            else if (points > 0.5 * questionManager.GetNumberOfQuestions())
                rankLabel.Text = "Rank: Padawan";
            else if (points > 0.25 * questionManager.GetNumberOfQuestions())
                rankLabel.Text = "Rank: Nerf Herder";
            else
                rankLabel.Text = "Rank: Moof Milker";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (question.CorrectChoice == 0) { 
                questionTextBox.Text = "CORRECT ANSWER!";
                points++;
                pointsLabel.Text = "Points: " + points;
                WriteRank();
            }
            else
                questionTextBox.Text = "INCORRECT!!!";
            DisableAllButtons();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (question.CorrectChoice == 1)
            {
                questionTextBox.Text = "CORRECT ANSWER!";
                points++;
                pointsLabel.Text = "Points: " + points;
                WriteRank();
            }
            else
                questionTextBox.Text = "INCORRECT!!!";
            DisableAllButtons();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (question.CorrectChoice == 2) { 
                questionTextBox.Text = "CORRECT ANSWER!";
                points++;
                pointsLabel.Text = "Points: " + points;
                WriteRank();
            }

            else
                questionTextBox.Text = "INCORRECT!!!";
            DisableAllButtons();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (question.CorrectChoice == 3)
            {
                questionTextBox.Text = "CORRECT ANSWER!";
                points++;
                pointsLabel.Text = "Points: " + points;
                WriteRank();
            }
            else
                questionTextBox.Text = "INCORRECT!!!";
            DisableAllButtons();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            question = questionManager.GetNextQuestion();
            if(question!=null)
            {
                EnableAllButtons();
                questionTextBox.Text = question.QuestionText;
                for (int i = 0; i < choiceButtons.Length; i++)
                {
                    choiceButtons[i].Text = question.Choices[i];
                }
            }
            if (questionCounter < questionManager.GetNumberOfQuestions())
            {
                questionCounter++;
                questionNumberLabel.Text = questionCounter + "/" + questionManager.GetNumberOfQuestions();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            EnableAllButtons();
            points = 0;
            pointsLabel.Text = "Points: " + points;
            questionManager.Restart();
            question = questionManager.GetNextQuestion();
            questionTextBox.Text = question.QuestionText;
            for (int i = 0; i < choiceButtons.Length; i++)
            {
                choiceButtons[i].Text = question.Choices[i];
            }
            questionCounter = 1;
            questionNumberLabel.Text = questionCounter + "/" + questionManager.GetNumberOfQuestions();
            WriteRank();
        }
    }
}
