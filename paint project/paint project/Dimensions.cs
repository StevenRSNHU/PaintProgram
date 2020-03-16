using System.Windows.Forms;

namespace paint_project
{
    internal class Dimensions
    {
        private int Height { get; set; }
        private int Width { get; set; }
        private int Radius { get; set; }

        public Dimensions()
        {
            Height = GetHeight();
            Width = GetWidth();
            Radius = GetRadius();
        }

        public void SetHeight(string h)
        {
            int height;

            if (int.TryParse(h, out height))
            {
                if (height >= 1 && height < 490)
                    Height = height;
                else
                    MessageBox.Show("Height out of range, please try again");
            }
        }

        public void SetWidth(string w)
        {
            int width;

            if (int.TryParse(w, out width))
            {
                if (width >= 1 && width < 490)
                    Width = width;
                else
                    MessageBox.Show("Width out of range, please try again");
            }
        }

        public void SetRadius(string r)
        {
            int radius;

            if (int.TryParse(r, out radius))
            {
                if (radius >= 1 && radius < 490)
                    Radius = radius;
                else
                    MessageBox.Show("Radius out of range, please try again");
            }
        }

        public int GetHeight() => Height;

        public int GetRadius() => Radius;

        public int GetWidth() => Width;
    }
}