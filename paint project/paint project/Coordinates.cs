using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint_project
{
    class Coordinates
    {
        private int X_Coor { get; set; }
        private int Y_Coor { get; set; }

        public Coordinates()
        {
            this.X_Coor = XCoordinate();
            this.Y_Coor = YCoordinate();
        }

        public void SetX(string x)
        {
            int x_coor;

            if (int.TryParse(x, out x_coor))
            {
                if (x_coor >= 1 && x_coor < 490)
                {
                    this.X_Coor = x_coor;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Value out of range, please try again");
                }
            }
        }
        public void SetY(string y)
        {
            int y_coor;

            if (int.TryParse(y, out y_coor))
            {
                if (y_coor >= 1 && y_coor < 490)
                {
                    this.Y_Coor = y_coor;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Value out of range, please try again");
                }
            }
        }
        public int XCoordinate()
        {
            return X_Coor;
        }
        public int YCoordinate()
        {
            return Y_Coor;
        }
    }
}
