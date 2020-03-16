namespace paint_project
{
    class Coordinates
    {
        private int X_Coor { get; set; }
        private int Y_Coor { get; set; }
        public Coordinates()
        {
            this.X_Coor = GetXCoordinate();
            this.Y_Coor = GetYCoordinate();
        }

        public void SetXCoordinate(string x)
        {
            int x_coor;

            if (int.TryParse(x, out x_coor))
            {
                if (x_coor >= 0 && x_coor <= 500)
                {
                    this.X_Coor = x_coor;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(@"Value out of range, please choose a value between 0 - 500.");
                }
            }
        }
        public void SetYCoordinate(string y)
        {
            int y_coor;

            if (int.TryParse(y, out y_coor))
            {
                if (y_coor >= 0 && y_coor <= 400)
                {
                    this.Y_Coor = y_coor;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(@"Value out of range, please choose a value between 0 - 400.");
                }
            }
        }
        public int GetXCoordinate()
        {
            return X_Coor;
        }
        public int GetYCoordinate()
        {
            return Y_Coor;
        }
    }
}
