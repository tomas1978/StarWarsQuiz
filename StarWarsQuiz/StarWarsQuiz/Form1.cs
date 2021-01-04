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
        QuestionManager questionManager;
        public Form1()
        {
            questionManager = new QuestionManager();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Question question = questionManager.GetNextQuestion();
            testBox.Text = question.ToString();
        }
    }
}
