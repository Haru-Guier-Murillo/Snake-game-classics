using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_game.Classes
{
    public class Snake
    {
        #region Variables
        private Rectangle[] snakeRec;
        private SolidBrush pincel;
        private int x, y, width, height;

        public Rectangle[] SnakeRec
        { 
            get { return snakeRec; } 
        }
        
        public Snake()
        {
            snakeRec = new Rectangle[3];
            pincel = new SolidBrush(Color.Black);
            x = 20;
            y = 0;
            width = 10;
            height = 10;
            for (int i = 0; i < snakeRec.Length; i++)
            {
                snakeRec[i] = new Rectangle(x, y, width,height);
                x -= 10;
            }
        }
        #endregion

        #region Metods
        public void DrawSnake(Graphics paper)//Dibuja a la sepiente en el tablero de juego
        {
            foreach (Rectangle rect in snakeRec) 
            { 
                paper.FillRectangle(pincel, rect);
            }
        }
        public void RepositionSnake()//Resiciona a la serpiente 
        {
            for (int i = snakeRec.Length - 1; i > 0; i--)
            {
                snakeRec[i] = snakeRec[i - 1];
            }
        }

        //Movimientos de la serpiente
        public void Up()
        {
            RepositionSnake();
            SnakeRec[0].Y -= 10;
        }
        public void Down()
        {
            RepositionSnake();
            SnakeRec[0].Y += 10;
        }
        public void Right()
        {
            RepositionSnake();
            SnakeRec[0].X += 10;
        }
        public void Left()
        {
            RepositionSnake();
            SnakeRec[0].X -= 10;
        }
        public void GrowUp()
        {
            List<Rectangle> rects = SnakeRec.ToList();
            rects.Add(new Rectangle(SnakeRec[SnakeRec.Length-1].X, SnakeRec[SnakeRec.Length - 1].Y, width, height));
            snakeRec = rects.ToArray();
        }
        #endregion
    }
}
