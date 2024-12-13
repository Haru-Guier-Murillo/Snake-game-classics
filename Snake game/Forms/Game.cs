using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Snake_game.Classes;
using Snake_game.Forms;

namespace Snake_game.Forms
{
    public partial class Game : Form
    {
        #region Variables
        Random ranFood = new Random();
        Graphics paper;
        Snake snakes = new Snake();
        Apple apple;
        bool up = false;
        bool down = false;
        bool right = false;
        bool left = false;
        int Score = 0;
        #endregion
        public Game()
        {
            InitializeComponent();
            apple = new Apple(ranFood);
        }

        #region Metods
        public void Game_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            if (paper != null)
            {
                snakes.DrawSnake(paper);
                apple.DrawApple(paper);
            }
        }
        public void End()
        {
            tmrMove.Enabled = false;
            snakes = new Snake();
            lblScore.Text = "0";
            MessageBox.Show("GAME OVER\n your score: " + Score.ToString(), "Game Over");
            Score = 0;
        }
        public void Colision()
        {
            for (int i = 1; i < snakes.SnakeRec.Length; i++)
            {
                //Colición con sigo mismo
                if (snakes.SnakeRec[0].IntersectsWith(snakes.SnakeRec[i]))
                {
                    End();
                }
            }
            //Colición con una pared izquierda o derecha
            if (snakes.SnakeRec[0].X < 0 || snakes.SnakeRec[0].X > 600)
            {
                End();
            }
            //Colición con una pared arriba o abajo
            if (snakes.SnakeRec[0].Y < 0 || snakes.SnakeRec[0].Y > 600)
            {
                End();
            }
        }
        #endregion

        #region Events
        private void Game_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                tmrMove.Enabled = true;
                up = false;
                down = false;
                right = true;
                left = false;
            }

            if (e.KeyCode == Keys.Down && up == false)
            {
                up = false;
                down = true;
                right = false;
                left = false;
            }
            if (e.KeyCode == Keys.Up && down == false)
            {
                up = true;
                down = false;
                right = false;
                left = false;
            }
            if (e.KeyCode == Keys.Right && left == false)
            {
                up = false;
                down = false;
                right = true;
                left = false;
            }
            if (e.KeyCode == Keys.Left && right == false)
            {
                up = false;
                down = false;
                right = false;
                left = true;
            }
        }
        private void tmrMove_Tick(object sender, EventArgs e)
        {
            lblScore.Text = Convert.ToString(Score);
            if (up)
            {
                snakes.Up();
            }
            if (down)
            {
                snakes.Down();
            }
            if (right)
            {
                snakes.Right();
            }
            if (left)
            {
                snakes.Left();
            }
            this.Invalidate();
            Colision();

            for (int i = 0; i < snakes.SnakeRec.Length; i++)
            {
                if (snakes.SnakeRec[i].IntersectsWith(apple.appleRec))
                {
                    snakes.GrowUp();
                    apple.ApplePosition(ranFood);
                    Score += 1;
                }
            }
        }
        #endregion


    }
}
