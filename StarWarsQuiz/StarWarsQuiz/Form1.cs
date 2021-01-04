﻿using System;
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
            for(int i=0;i<choiceButtons.Length;i++)
            {
                choiceButtons[i].Text = question.Choices[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (question.CorrectChoice == 0) { 
                questionTextBox.Text = "CORRECT ANSWER!";
                points++;
                pointsLabel.Text = "Points: " + points;
            }
            else
                questionTextBox.Text = "INCORRECT!!!";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (question.CorrectChoice == 1)
            {
                questionTextBox.Text = "CORRECT ANSWER!";
                points++;
                pointsLabel.Text = "Points: " + points;
            }
            else
                questionTextBox.Text = "INCORRECT!!!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (question.CorrectChoice == 2) { 
                questionTextBox.Text = "CORRECT ANSWER!";
                points++;
                pointsLabel.Text = "Points: " + points;
            }

            else
                questionTextBox.Text = "INCORRECT!!!";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (question.CorrectChoice == 3)
            {
                questionTextBox.Text = "CORRECT ANSWER!";
                points++;
                pointsLabel.Text = "Points: " + points;
            }
            else
                questionTextBox.Text = "INCORRECT!!!";
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            question = questionManager.GetNextQuestion();
            if(question!=null)
            {
                questionTextBox.Text = question.QuestionText;
                for (int i = 0; i < choiceButtons.Length; i++)
                {
                    choiceButtons[i].Text = question.Choices[i];
                }
            }

        }
    }
}
