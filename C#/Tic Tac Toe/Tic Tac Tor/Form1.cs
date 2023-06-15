using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Tor
{
    public partial class TicTacToe : Form
    {
        bool turn = true; // true = A turn  if false then B turn
        int turn_count = 0;
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nitish Mathur", "Developed By");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else { b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;

            turn_count++;

            checkForWinner();
        }
        private void checkForWinner()
        {
           
            bool Iswinner = false;

            // Checking Horizontally
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                Iswinner = true;
            }
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                Iswinner = true;
            }
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                Iswinner = true;
            }


            // Checking Vertically
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                Iswinner = true;
            }
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                Iswinner = true;
            }
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                Iswinner = true;
            }


            // Checking Diagonally
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                Iswinner = true;
            }
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                Iswinner = true;
            }

            // Checking who is Winner
            if (Iswinner)
            {
                disabledButtons();
                String winner = "";
                if (turn)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }
                MessageBox.Show("Winner " + winner, "Congratulations!");
            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!", "Result");
                }
            }
        }

        private void disabledButtons()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
        }
    }
}
