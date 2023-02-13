using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp1
{
    public partial class Form1 : Form
    {
        bool xTurn = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Button senderB = (Button)sender;
                if (xTurn)
                {
                    senderB.Text = "X";
                }
                else
                {
                botStep();
                }
                                
                xTurn = !xTurn;
                senderB.Enabled = false;

             
             CheckWin(senderB);
        }

        void CheckWin(Button pressedButton)
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button3.Enabled == false)
            {
                MessageBox.Show("Победа" + pressedButton.Text);
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Enabled == false)
            {
                MessageBox.Show("Победа" + pressedButton.Text);
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Enabled == false)
            {
                MessageBox.Show("Победа" + pressedButton.Text);
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Enabled == false)
            {
                MessageBox.Show("Победа" + pressedButton.Text);
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Enabled == false)
            {
                MessageBox.Show("Победа" + pressedButton.Text);
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Enabled == false)
            {
                MessageBox.Show("Победа" + pressedButton.Text);
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Enabled == false)
            {
                MessageBox.Show("Победа" + pressedButton.Text);
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button7.Enabled == false)
            {
                MessageBox.Show("Победа" + pressedButton.Text);
            }

        }

        void botStep()
        {
            if (button1.Text == button2.Text && button2.Text == "")
            {
                button3.Text = "O";
            }
            if (button4.Text == button5.Text && button5.Text == "")
            {
                button6.Text = "O";
            }
            if (button7.Text == button8.Text && button8.Text == "")
            {
                button9.Text = "O";
            }
            if (button1.Text == button4.Text && button4.Text == "")
            {
                button7.Text = "O";
            }
            if (button2.Text == button5.Text && button5.Text == "")
            {
                button8.Text = "O";
            }
            if (button3.Text == button6.Text && button6.Text == "")
            {
                button9.Text = "O";
            }
            if (button1.Text == button5.Text && button5.Text == "")
            {
                button9.Text = "O";
            }
            if (button3.Text == button5.Text && button5.Text == "")
            {
                button7.Text = "O";
            }
            else
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
