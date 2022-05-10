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
    public partial class Form1 : Form
    {
        GameWindow gameWindow;
        public Form1()
        {
            InitializeComponent();
            gameWindow = new GameWindow();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.username_tb.Text;
            string password = this.password_tb.Text;
            bool isPrimarySelected = this.primary_rb.Checked;
            bool isSecondarySelected = this.secondary_rb.Checked;

            if(username.Trim().Length == 0 || password.Trim().Length == 0)
            {
                MessageBox.Show("Please enter your credentials", "Error");
                return;
            }

            if(username != "izaan" || password != "12345678")
            {
                MessageBox.Show("Wrong credentials", "Error");
                return;
            }

            if(!isPrimarySelected && !isSecondarySelected)
            {
                MessageBox.Show( "Please select a level", "Error");
                return;
            }

            gameWindow.Show();
            this.Hide();
        }
    }
}
