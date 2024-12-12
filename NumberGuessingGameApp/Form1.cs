using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGameApp
{
    public partial class Form1 : Form
    {

        Random randomNumber = new Random();

        int number = 0;
        int guesses = 0;

        public Form1()
        {
            InitializeComponent();

            loadQuestions();
        }

        private void checkNumber(object sender, EventArgs e)
        {
       
            int i = Convert.ToInt32(txtEnterNum.Text);

            guesses += 1;
            lblGuessed.Text = "You guessed " + guesses + " times."; 

            if (i == number)
            {
                MessageBox.Show("Nice, you guessed it! Try another?");
                loadQuestions();
                txtEnterNum.Text = "";
                guesses = 0;
                lblGuessed.Text = "You guessed " + guesses + " times.";
            }
            else if (i < number)
            {
                MessageBox.Show("Go higher");
                txtEnterNum.Text = "";
            }
            else
            {
                MessageBox.Show("Go lower");
                txtEnterNum.Text = "";
            }



        }

        private void loadQuestions()
        {
            number = randomNumber.Next(0, 100);

            lblQuestion.Text = "I am thinking of a number between 0 and 100 ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtEnterNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void lblGuessed_Click(object sender, EventArgs e)
        {

        }
    }
}
