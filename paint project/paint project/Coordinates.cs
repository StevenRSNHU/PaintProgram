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
            int start_X;
            if (int.TryParse(x, out start_X))
            {
                if (start_X >= 0 && start_X <= 667)
                {
                    this.X_Coor = start_X;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Value out of range, please try again");
                }
            }
            //requires error handling TryParse
        }
        public void SetY(string y)
        {
            int start_Y;
            if (int.TryParse(y, out start_Y))
            {
                if (start_Y >= 0 && start_Y <= 492)
                {
                    this.Y_Coor = start_Y;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Value out of range, please try again");
                }
            }
            //requires erro handling TryParse
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
