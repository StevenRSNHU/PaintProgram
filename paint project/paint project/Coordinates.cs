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

        public void SetX()
        {
            //requires error handling TryParse
        }
        public void SetY()
        {
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
