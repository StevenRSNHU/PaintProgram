using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint_project
{
    class Painter
    {
        private int rVal { get; set; }//Red value for the RGB of the shape lines
        private int gVal { get; set; }//Green value for the RGB of the shape lines
        private int bVal { get; set; }//Blue value for the RGB of the shape lines

        public Painter()
        {
            this.rVal = GetRed();
            this.bVal = GetBlue();
            this.gVal = GetGreen();
        }

        public void SetRed(string r)
        {
            int red;

            if (!string.IsNullOrEmpty(r))//When input in the TXTBX, Parse input 
            {
                if (int.TryParse(r, out red))
                {
                    if (red >= 0 && red < 256)
                    {
                        this.rVal = red;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Value out of range please try again");
                    }
                }
            }
        }

        public void SetBlue(string b)
        {
            int blue;

            if (!string.IsNullOrEmpty(b))
            {
                if (int.TryParse(b, out blue))
                {
                    if (blue >= 0 && blue < 256)
                    {
                        this.bVal = blue;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Value out of range please try again");
                    }
                }
            }
        }

        public void SetGreen(string g)
        {
            int green;

            if (!string.IsNullOrEmpty(g))
            {
                if (int.TryParse(g, out green))
                {
                    if (green >= 0 && green < 256)
                    {
                        this.gVal = green;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Value out of range please try again");
                    }
                }
            }
        }

        public int GetRed()
        {
            return rVal;
        }

        public int GetGreen()
        {
            return gVal;
        }

        public int GetBlue()
        {
            return bVal;
        }














    }
}
