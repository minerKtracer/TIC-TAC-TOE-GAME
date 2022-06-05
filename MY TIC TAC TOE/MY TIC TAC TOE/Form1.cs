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
            FB1.Text = turn.ToString();
        }

        private void FB2_Click(object sender, EventArgs e)
        {
            FB2.Text = turn.ToString();
        }

        private void FB3_Click(object sender, EventArgs e)
        {
            FB3.Text = turn.ToString();
        }

        private void SB1_Click(object sender, EventArgs e)
        {
            SB1.Text = turn.ToString();
        }

        private void SB2_Click(object sender, EventArgs e)
        {
            SB2.Text = turn.ToString();
        }

        private void SB3_Click(object sender, EventArgs e)
        {
            SB3.Text = turn.ToString();
        }

        private void TB1_Click(object sender, EventArgs e)
        {
            TB1.Text = turn.ToString();
        }

        private void TB2_Click(object sender, EventArgs e)
        {
            TB2.Text = turn.ToString();
        }

        private void TB3_Click(object sender, EventArgs e)
        {
            TB3.Text = turn.ToString();
        }
    }
}
