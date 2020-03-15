namespace paint_project
{
    class Dimensions
    {
        private int Height { get; set; }
        private int Width { get; set; }
        private int Radius { get; set;}

        public Dimensions()
        {
            this.Height = GetHeight();
            this.Width = GetWidth();
            this.Radius = GetRadius();
        }

        public void SetHeight(string h)
        {
            int height;

            if (int.TryParse(h, out height))
            {
                if (height >= 1 && height < 490)
                {
                    this.Height = height;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Height out of range, please try again");
                }
            }
        }

        public void SetWidth(string w)
        {
            int width;

            if (int.TryParse(w, out width))
            {
                if (width >= 1 && width < 490)
                {
                    this.Width = width;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Width out of range, please try again");
                }
            }
        }
        public void SetRadius(string r)
        {
            int radius;

            if (int.TryParse(r, out radius))
            {
                if (radius >= 1 && radius < 490)
                {
                    this.Radius = radius;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Radius out of range, please try again");
                }
            }
        }

        public int GetHeight()
        {
            return Height;
        }

        public int GetRadius()
        {
            return Radius;
        }

        public int GetWidth()
        {
            return Width;
        }

    }
}
