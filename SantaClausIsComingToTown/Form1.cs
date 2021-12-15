using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaClausIsComingToTown
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int objectspeed = 6;
        int gameScore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            santa.Top += gravity;
            flake.Left -= objectspeed;
            Tree.Left -= objectspeed;
            scorelabel.Text = $"Score : {gameScore}";   

            if(flake.Left < -120)
            {
                flake.Left = 600;
                 
            }
            if(Tree.Left < -120)
            {
                Tree.Left = 600;
                gameScore++;
            }

            if (santa.Top < -10)
            {
                gameover();
            }

            if(santa.Bounds.IntersectsWith(flake.Bounds) || santa.Bounds.IntersectsWith(Tree.Bounds) || santa.Bounds.IntersectsWith(Ground.Bounds))
            {
                gameover();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -3;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 3;
            }
        }

        private void gameover()
        {
            timer1.Stop();
            scorelabel.Text = $"Game Over!";
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            this.Dispose(false);
        }
    }
}
