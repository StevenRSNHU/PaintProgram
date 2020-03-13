using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint_project
{
    class Dimensions
    {
        private int Width { get; set; }
        private int Height { get; set; }
        private int Radius { get; set; }

        public Dimensions()
        {
            this.Height = GetHeight();
            this.Width = GetWidth();
            this.Radius = GetRadius();
        }

        public void ShapeHeight(string h)
        {
            int rectangleHeight;

            if (int.TryParse(h, out rectangleHeight))
            {
                if (rectangleHeight > 1 && rectangleHeight < 490)
                {
                    this.Height = rectangleHeight;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Height is out of range, please try again");
                }
            }
        }

        public void ShapeWidth(string w)
        {
            int rectangleWidth;

            if (int.TryParse(w, out rectangleWidth))
            {
                if (rectangleWidth > 1 && rectangleWidth < 660)
                {
                    this.Width = rectangleWidth;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Width is out of range, please try again");
                }
            }
        }

        public void ShapeRadius(string r)
        {
            int circleRadius;

            if (int.TryParse(r, out circleRadius))
            {
                if (circleRadius > 1 && circleRadius < 490)
                {
                    this.Radius = circleRadius;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Radius is out of range, please try again");
                }
               
            }
           
        }

        public int GetHeight()
        {
            return Height;
        }

        public int GetWidth()
        {
            return Width;
        }

        public int GetRadius()
        {
            return Radius;
        }
    }
}
