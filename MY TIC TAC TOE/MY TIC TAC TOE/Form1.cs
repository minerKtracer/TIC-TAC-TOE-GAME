using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_TIC_TAC_TOE
{
    public partial class MainFORM1 : Form
    {
        char turn = 'X';
        public MainFORM1()
        {
            InitializeComponent();
        }

        private void FB1_Click(object sender, EventArgs e)
        {
            if (FB1.Text == "")
            {
                FB1.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
        }

        private void FB2_Click(object sender, EventArgs e)
        {
            if (FB2.Text == "")
            {
                FB2.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
        }

        private void FB3_Click(object sender, EventArgs e)
        {
            if (FB3.Text == "")
            {
                FB3.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
        }

        private void SB1_Click(object sender, EventArgs e)
        {
            if (SB1.Text == "")
            {
                SB1.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
        }

        private void SB2_Click(object sender, EventArgs e)
        {
            if (SB2.Text == "")
            {
                SB2.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
        }

        private void SB3_Click(object sender, EventArgs e)
        {
            if (SB3.Text == "")
            {
                SB3.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
        }

        private void TB1_Click(object sender, EventArgs e)
        {
            if (TB1.Text == "")
            {
                TB1.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
        }

        private void TB2_Click(object sender, EventArgs e)
        {
            if (TB2.Text == "")
            {
                TB2.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
        }

        private void TB3_Click(object sender, EventArgs e)
        {
            if (TB3.Text == "")
            {
                TB3.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
        }
    }
}
