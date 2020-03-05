using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint_project
{
    class Paint
    {
        private int R, G, B;
        
        public Paint()
        {

        }

        public void SetColor(string R, string G, string B )
        {
            int r, g, b;
            if (!int.TryParse(R, out r))
            {
                throw new System.ArgumentException("Red is not an integer", "R");
            }
            if (!int.TryParse(G, out g))
            {
                throw new System.ArgumentException("Green is not an integer", "G");
            }
            if (!int.TryParse(B, out b))
            {
                throw new System.ArgumentException("Blue is not an integer", "B");
            }

            if (r >= 0 && r <= 255)
            {
                this.R = r;
                if ( g >= 0  && g <= 255)
                {
                    this.G = g;
                    if (b >= 0 && b <= 255)
                    {
                        this.B = b;
                        

                    }
                    else {
                        throw new System.ArgumentException("Blue is not within range of 0 - 255", "B");
                    }
                }
                else
                {
                    throw new System.ArgumentException("Green is not within range of 0 - 255", "G");
                }
            }
            else
            {
                throw new System.ArgumentException("Red is not within range of 0 - 255", "R");
            }
        }













    }
}
