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
        Button[,] dokmeha;
        int ply;
        public Form1()
        {
            InitializeComponent();

             dokmeha = new Button[3, 3] ;
             s();

             new_game();
    
        }

        private void s()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dokmeha[i, j] = new Button();
                    dokmeha[i, j].Click += new EventHandler(button1_Click);
                    dokmeha[i, j].Font = new Font("",40);
                    dokmeha[i, j].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left;
                    tableLayoutPanel1.Controls.Add(dokmeha[i, j], i, j);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button this_button = (sender as Button);
            if (this_button.Text == "")
            {
                if (ply == 1)
                {
                    this_button.Text = "X";
                    this_button.BackColor = Color.HotPink;
                    this_button.ForeColor = Color.Pink;
                    ply = 2;
                }
                else if (ply == 2)
                {
                    this_button.Text = "O";
                    this_button.BackColor = Color.DarkGray;
                    this_button.ForeColor = Color.Gray;
                    ply = 1;
                }

                check_game();
            }
        }
        private void button9_MouseHover(object sender, EventArgs e)
        {
            //Button this_button = (sender as Button);
            //this_button.BackColor = Color.DarkBlue;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
           // Button this_button = (sender as Button);
           // this_button.BackColor = Color.SkyBlue;
        }

        private void new_game()
        {
            ply = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dokmeha[i, j].Text = "";
                    dokmeha[i, j].BackColor = Color.SkyBlue;
                }
            }
        }

        private void check_game()
        {
            if(dokmeha[0,0].Text=="X" && dokmeha[0, 1].Text == "X" && dokmeha[0, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                new_game();
            }
            if (dokmeha[1, 0].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[1, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                new_game();
            }
            if (dokmeha[2, 0].Text == "X" && dokmeha[2, 1].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "X" && dokmeha[1, 0].Text == "X" && dokmeha[2, 0].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                new_game();
            }
            if (dokmeha[0, 1].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 1].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "X" && dokmeha[1, 2].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 0].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                new_game();
            }


            if (dokmeha[0, 0].Text == "O" && dokmeha[0, 1].Text == "O" && dokmeha[0, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                new_game();
            }
            if (dokmeha[1, 0].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[1, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                new_game();
            }
            if (dokmeha[2, 0].Text == "O" && dokmeha[2, 1].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "O" && dokmeha[1, 0].Text == "O" && dokmeha[2, 0].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                new_game();
            }
            if (dokmeha[0, 1].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 1].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "O" && dokmeha[1, 2].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 0].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                new_game();
            }
            else if (dokmeha[0, 0].Text != "" && dokmeha[0, 1].Text != "" && dokmeha[0, 2].Text != "" && dokmeha[1, 0].Text != "" && dokmeha[1, 1].Text != "" && dokmeha[1, 2].Text != "" && dokmeha[2, 0].Text != "" && dokmeha[2, 1].Text != "" && dokmeha[2, 2].Text != "")
            {
                MessageBox.Show("مساوی شد");
                new_game();
            }
        }

        private void Btn_Restart_Click_1(object sender, EventArgs e)
        {
            new_game();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

