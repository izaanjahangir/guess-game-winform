using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame
{
    public partial class GameWindow : Form
    {
        public int totalChances, triesTaken, totalSum, requiredSum;
        public string username, selectedLevel;
        Random random;
        public GameWindow()
        {
            InitializeComponent();
        }

        private void play_again_btn_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        public void decideWin(int randNum) { 
            totalSum += randNum;
            triesTaken++;

            this.point_earned_lb.Text = "Points earned: " + totalSum.ToString();
            this.tries_remaining_lb.Text = "Tries remaining: " + (totalChances - triesTaken).ToString();
            
            if (totalSum >= requiredSum)
            {
                MessageBox.Show(username + ", you won!", "Congratulations");
                disableAllButtons();
                return;
            }

           
            if(triesTaken >= totalChances)
            {
                MessageBox.Show("You Lost, all chances are over", "Better luck next time");
                disableAllButtons();
                return;
            }
        }

        private int getRandNumber() { 
            return random.Next(0, 15);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randNum = getRandNumber();
            this.button1.Text = randNum.ToString();
            decideWin(randNum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int randNum = getRandNumber();
            this.button2.Text = randNum.ToString();
            decideWin(randNum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int randNum = getRandNumber();
            this.button3.Text = randNum.ToString();
            decideWin(randNum);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int randNum = getRandNumber();
            this.button6.Text = randNum.ToString();
            decideWin(randNum);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int randNum = getRandNumber();
            this.button4.Text = randNum.ToString();
            decideWin(randNum);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int randNum = getRandNumber();
            this.button5.Text = randNum.ToString();
            decideWin(randNum);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int randNum = getRandNumber();
            this.button7.Text = randNum.ToString();
            decideWin(randNum);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int randNum = getRandNumber();
            this.button8.Text = randNum.ToString();
            decideWin(randNum);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int randNum = getRandNumber();
            this.button9.Text = randNum.ToString();
            decideWin(randNum);
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            resetGame();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void go_back_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void resetGame() {
            if(selectedLevel == "primary")
            {
                totalChances = 5;
                requiredSum = 30;
            }
            if (selectedLevel == "secondary")
            {
                totalChances = 2;
                requiredSum = 12;
            }

            enableAllButtons();

            triesTaken = 0;
            totalSum = 0;

            random = new Random();

            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
            this.button7.Text = "";
            this.button8.Text = "";
            this.button9.Text = "";

            this.tries_remaining_lb.Text = "Tries remaining: " + (totalChances - triesTaken).ToString();
            this.selected_level_lb.Text = "Selected level: " + selectedLevel.ToString();
            this.point_earned_lb.Text = "Points earned: " + totalSum.ToString();
            this.point_required_lb.Text = "Points required to win: " + requiredSum.ToString();
        }

        private void disableAllButtons() {
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
            this.button7.Enabled = false;
            this.button8.Enabled = false;
            this.button9.Enabled = false;
        }

        private void enableAllButtons()
        {
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.button9.Enabled = true;
        }
    }
}
