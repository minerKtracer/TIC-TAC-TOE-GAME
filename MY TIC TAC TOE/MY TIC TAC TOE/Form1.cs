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
                if (FB1.Text == SB1.Text)
                {
                    if (SB1.Text == TB1.Text)
                    {
                        MessageBox.Show("The winner is " + FB1.Text);
                    }
               }
                if (FB1.Text == FB2.Text)
                {
                    if (FB2.Text == FB3.Text)
                    {
                        MessageBox.Show("The winner is " + FB1.Text);
                    }
                }
                if (FB1.Text == SB2.Text)
                {
                    if (SB2.Text == TB3.Text)
                    {
                        MessageBox.Show("The winner is " + FB1.Text);
                    }
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
                if (FB2.Text == SB2.Text)
                {
                    if (SB2.Text == TB2.Text)
                    {
                        MessageBox.Show("The winner is " + FB2.Text);
                    }
                }
                if (FB2.Text == FB1.Text)
                {
                    if (FB1.Text == FB3.Text)
                    {
                        MessageBox.Show("The winner is " + FB2.Text);
                    }
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
                if (FB3.Text == SB3.Text)
                {
                    if (SB3.Text == TB3.Text)
                    {
                        MessageBox.Show("The winner is " + FB3.Text);
                    }
                }
                if (FB3.Text == FB2.Text)
                {
                    if (FB2.Text == FB1.Text)
                    {
                        MessageBox.Show("The winner is " + FB3.Text);
                    }
                }
                if (FB3.Text == SB2.Text)
                {
                    if (SB2.Text == TB1.Text)
                    {
                        MessageBox.Show("The winner is " + FB3.Text);
                    }
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
                if (SB1.Text == SB2.Text)
                {
                    if (SB2.Text == SB3.Text)
                    {
                        MessageBox.Show("The winner is " + SB1.Text);
                    }
                }
                if (SB1.Text == FB1.Text)
                {
                    if (FB1.Text == TB1.Text)
                    {
                        MessageBox.Show("The winner is " + SB1.Text);
                    }
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
                if (SB2.Text == SB1.Text)
                {
                    if (SB1.Text == SB3.Text)
                    {
                        MessageBox.Show("The winner is " + SB2.Text);
                    }
                }
                if (SB2.Text == FB2.Text)
                {
                    if (FB2.Text == TB2.Text)
                    {
                        MessageBox.Show("The winner is " + SB2.Text);
                    }
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
                if (SB3.Text == SB2.Text)
                {
                    if (SB2.Text == SB1.Text)
                    {
                        MessageBox.Show("The winner is " + SB3.Text);
                    }
                }
                if (SB3.Text == FB3.Text)
                {
                    if (FB3.Text == TB3.Text)
                    {
                        MessageBox.Show("The winner is " + SB3.Text);
                    }
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
                if (TB1.Text == SB1.Text)
                {
                    if (SB1.Text == FB1.Text)
                    {
                        MessageBox.Show("The winner is " + TB1.Text);
                    }
                }
                if (TB1.Text == SB2.Text)
                {
                    if (SB2.Text == FB3.Text)
                    {
                        MessageBox.Show("The winner is " + TB1.Text);
                    }
                }
                if (TB1.Text == TB2.Text)
                {
                    if (TB2.Text == TB3.Text)
                    {
                        MessageBox.Show("The winner is " + TB1.Text);
                    }
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
                if (TB2.Text == SB2.Text)
                {
                    if (SB2.Text == FB2.Text)
                    {
                        MessageBox.Show("The winner is " + TB2.Text);
                    }
                }
                if (TB2.Text == TB1.Text)
                {
                    if (TB1.Text == TB3.Text)
                    {
                        MessageBox.Show("The winner is " + TB2.Text);
                    }
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
            if (TB3.Text == SB3.Text)
            {
                if (SB3.Text == FB3.Text)
                {
                    MessageBox.Show("The winner is " + TB3.Text);
                }
            }
            if (TB3.Text == SB2.Text)
            {
                if (SB2.Text == FB1.Text)
                {
                    MessageBox.Show("The winner is " + TB3.Text);
                }
            }
            if (TB3.Text == TB2.Text)
            {
                if (TB2.Text == TB1.Text)
                {
                    MessageBox.Show("The winner is " + TB3.Text);
                }
            }
        }
    }
}
