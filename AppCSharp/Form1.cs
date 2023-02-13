using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Security;
namespace AppCSharp
{
    public partial class Form1 : Form
    {
        bool xTurn = true;

        private int x = 12, y = 12;
        private Button[,] buttons = new Button[3, 3];
        private int player;

        public Form1()
        {
            InitializeComponent();
            this.Height = 700;
            this.Width = 900;
            player = 1;

            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Enabled = false;
                    buttons[i, j].TabStop= false;
                    buttons[i, j].Size = new Size(200, 200);
                    buttons[i, j].Location = new Point(12 + 206 * j, 12 + 206 * i);
                    buttons[i, j].Click += button1_Click;
                    buttons[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 138);
                    buttons[i, j].Text = "";
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }


        private void checkWin()
        {

            if (buttons[0, 0].Text == buttons[0, 1].Text && buttons[0, 1].Text == buttons[0, 2].Text)
            {

                if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show("ЕЕЕЕЕЕ Победа,Время обеда!");
                    Application.Restart();
                    return;
                }
            }
            if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[1, 2].Text)
            {
                if (buttons[1, 0].Text != "")
                {
                    MessageBox.Show("ЕЕЕЕЕЕ Победа,Время обеда!");
                    Application.Restart();
                    return;
                }
            }
            if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                {
                    MessageBox.Show("ЕЕЕЕЕЕ Победа,Время обеда!");
                    Application.Restart();
                    return;
                }
            }
            if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1, 0].Text == buttons[2, 0].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show("ЕЕЕЕЕЕ Победа,Время обеда!");
                    Application.Restart();
                    return;
                }
            }
            if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 1].Text)
            {
                if (buttons[0, 1].Text != "")
                {
                    MessageBox.Show("ЕЕЕЕЕЕ Победа,Время обеда!");
                    Application.Restart();
                    return;
                }
            }
            if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 2].Text != "")
                {

                    MessageBox.Show("ЕЕЕЕЕЕ Победа,Время обеда!");
                    Application.Restart();
                    return;
                }
            }
            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show("ЕЕЕЕЕЕ Победа, Время обеда!");
                    Application.Restart();
                    return;
                }
            }
            if (buttons[2, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                {
                    MessageBox.Show("ЕЕЕЕЕЕ Победа,Время обеда!");
                    Application.Restart();
                    return;
                }
            }
        }
        private void ckeckDraw()
        {
            bool Draw = true;
            for (int i = 0; i < buttons.Length / 3; i++)
                for (int j = 0; j < buttons.Length / 3; j++)
                    if (buttons[i, j].Text == "")
                        Draw = false;
            
            if (Draw == true) 
           
            {
                MessageBox.Show("Ничья!");
                Application.Restart();
            }


        }

        private void botZero()
        {


            if (buttons[0, 0].Text == buttons[0, 1].Text)
            {

                if (buttons[0, 0].Text != "" || buttons[0, 0].Text == "o")
                {
                    player = 0;
                    MessageBox.Show("ЕЕЕЕЕЕ Победа,Время обеда!");
                    return;
                }
            }
            if (buttons[1, 0].Text == buttons[1, 1].Text)
            {
                if (buttons[1, 0].Text != "" || buttons[1, 0].Text == "o")
                    player = 0;
                MessageBox.Show("ЕЕЕЕЕЕ Победа,Время обеда!");
                return;
            }
            if (buttons[2, 0].Text == buttons[2, 1].Text)
            {
                if (buttons[2, 0].Text != "" || buttons[2, 0].Text == "o")
                    player = 0;
                MessageBox.Show("ЕЕЕЕЕЕ Победа,Время обеда!");
                return;
            }
            if (buttons[0, 0].Text == buttons[1, 0].Text)
            {
                if (buttons[0, 0].Text != "" || buttons[0, 0].Text == "o")
                    player = 0;
                MessageBox.Show("ЕЕЕЕЕЕ Победа,Время обеда!");
                return;
            }
            if (buttons[0, 1].Text == buttons[1, 1].Text)
            {
                if (buttons[0, 1].Text != "" || buttons[0, 1].Text == "o")
                    player = 0;
                MessageBox.Show("ЕЕЕЕЕЕ Победа,Время обеда!");
                return;
            }
            if (buttons[0, 2].Text == buttons[1, 2].Text)
            {
                if (buttons[0, 2].Text != "" || buttons[0, 2].Text == "o")
                    player = 0;
                MessageBox.Show("ЕЕЕЕЕЕ Победа,Время обеда!");
                return;
            }
            if (buttons[0, 0].Text == buttons[1, 1].Text)
            {
                if (buttons[0, 0].Text != "" || buttons[0, 0].Text == "o")
                    player = 0;
                MessageBox.Show("ЕЕЕЕЕЕ Победа, Время обеда!");
                return;
            }
            if (buttons[2, 0].Text == buttons[1, 1].Text)
            {
                if (buttons[2, 0].Text != "" || buttons[2, 0].Text == "o")
                    player = 0;
                MessageBox.Show("ЕЕЕЕЕЕ Победа,Время обеда!");
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button senderB = (Button)sender;
            senderB.Text = "x";
            senderB.Enabled = false;

            ckeckDraw();


            Random rnd = new Random();
            int GG = 0;
            int WP = 0;

            GG = rnd.Next(0, 3); //случайные числа от [0..2]
            WP = rnd.Next(0, 3);

            while (buttons[GG, WP].Text!="")
            { 
                GG = rnd.Next(0, 3); //случайные числа от [0..2]
                WP = rnd.Next(0, 3);
            }

            buttons[GG, WP].Text = "O";
            ckeckDraw();

            checkWin();
        }







        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                }
            }
        }
    }

}