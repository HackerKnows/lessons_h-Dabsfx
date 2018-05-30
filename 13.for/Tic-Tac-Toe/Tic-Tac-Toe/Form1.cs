using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public static bool Turn=false;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (Turn==false)
            {
                btn_1.Text = "X";
                Turn = true;
            }
            else
            {
                btn_1.Text = "O";
                Turn = false;
            }
            btn_1.Enabled = false;
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            if (Turn == false)
            {
                btn_2.Text = "X";
                Turn = true;
            }
            else
            {
                btn_2.Text = "O";
                Turn = false;
            }
            btn_2.Enabled = false;
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            if (Turn == false)
            {
                btn_3.Text = "X";
                Turn = true;
            }
            else
            {
                btn_3.Text = "O";
                Turn = false;
            }
            btn_3.Enabled = false;
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            if (Turn == false)
            {
                btn_4.Text = "X";
                Turn = true;
            }
            else
            {
                btn_4.Text = "O";
                Turn = false;
            }
            btn_4.Enabled = false;
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            if (Turn == false)
            {
                btn_5.Text = "X";
                Turn = true;
            }
            else
            {
                btn_5.Text = "O";
                Turn = false;
            }
            btn_5.Enabled = false;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (Turn == false)
            {
                btn_6.Text = "X";
                Turn = true;
            }
            else
            {
                btn_6.Text = "O";
                Turn = false;
            }
            btn_6.Enabled = false;
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            if (Turn == false)
            {
                btn_7.Text = "X";
                Turn = true;
            }
            else
            {
                btn_7.Text = "O";
                Turn = false;
            }
            btn_7.Enabled = false;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (Turn == false)
            {
                btn_8.Text = "X";
                Turn = true;
            }
            else
            {
                btn_8.Text = "O";
                Turn = false;
            }
            btn_8.Enabled = false;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (Turn == false)
            {
                btn_9.Text = "X";
                Turn = true;
            }
            else
            {
                btn_9.Text = "O";
                Turn = false;
            }
            btn_9.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Win();
        }
        private void Win()
        {
            if (btn_1.Text=="X" & btn_2.Text=="X" & btn_3.Text=="X")
            {
                timer1.Stop();
                MessageBox.Show("LOL");
            }
        }
    }
}
