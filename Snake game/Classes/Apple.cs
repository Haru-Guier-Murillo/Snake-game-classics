using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_game.Classes
{
    public class Apple
    {
        #region Variables
        public Rectangle appleRec;
        private SolidBrush pincel;
        private int x, y, width, height;

        public Apple (Random ranFood)
        {
            x = ranFood.Next(0, 58) * 10;
            y = ranFood.Next(0, 58) * 10;
            pincel = new SolidBrush(Color.Red);
            width = 10;
            height = 10;
            appleRec = new Rectangle(x, y, width, height);
        }
        #endregion

        #region Metods
        
        public void ApplePosition(Random ranFood)
        {
            x = ranFood.Next(0, 58) * 10;
            y = ranFood.Next(0, 58) * 10;
        }

        public void DrawApple(Graphics paper)
        {
            appleRec.X = x;
            appleRec.Y = y;
            paper.FillRectangle(pincel, appleRec);
        }
        #endregion
    }
}
