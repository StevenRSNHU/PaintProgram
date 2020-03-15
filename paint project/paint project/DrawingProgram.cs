using System;
using System.Drawing;
using System.Windows.Forms;

namespace paint_project
{
    public partial class DrawingProgram : Form
    {
        Painter _painter = new Painter();
        Coordinates _coordinates = new Coordinates();
        Dimensions shape = new Dimensions();
        private bool mouseDown = false;

        public DrawingProgram()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            DrawingPanel.Invalidate();
        }

        private void ShapeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ShapeBox.SelectedIndex)
            {
                case 0: //rectangle
                    ClearContext();
                    RedTextBox.Select();
                    WidthLabel.Show();
                    HeightLabel.Show();
                    WidthTextBox_Rectangle.Show();
                    HeightTextBox_Rectangle.Show();
                    break;
                case 1: //square
                    ClearContext();
                    RedTextBox.Select();
                    WidthLabel.Show();
                    WidthTextBox_Square.Show();
                    break;
                case 2: //circle
                    ClearContext();
                    RedTextBox.Select();
                    RadiusLabel.Show();
                    RadiusTextBox_Circle.Show();
                    break;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
            DrawingPanel.Invalidate();
        }

        private void DrawingProgram_Load(object sender, EventArgs e)
        {
            RedTextBox.TextChanged += new System.EventHandler(this.RTextBox_TextChanged);
            GreenTextBox.TextChanged += new System.EventHandler(this.GTextBox_TextChanged);
            BlueTextBox.TextChanged += new System.EventHandler(this.BTextBox_TextChanged);
            MessageBox.Show($@"Tip: Once you have drawn a shape, click and drag to move the shape.");


        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen userPen = new Pen(Color.FromArgb(_painter.GetRed(), _painter.GetGreen(), _painter.GetBlue()));

            switch (ShapeBox.SelectedIndex)
            {
                case 0:
                    g.DrawRectangle(userPen,_coordinates.GetXCoordinate(), _coordinates.GetYCoordinate(),
                        shape.GetWidth(), shape.GetHeight() );
                    break;
                case 1:
                    g.DrawRectangle(userPen, _coordinates.GetXCoordinate(), _coordinates.GetYCoordinate(),
                        shape.GetWidth(), shape.GetWidth());
                    break;
                case 2:
                    g.DrawEllipse(userPen, _coordinates.GetXCoordinate(), _coordinates.GetYCoordinate(),
                        shape.GetRadius() * 2, shape.GetRadius() * 2);
                    break;
            }
        }

        private void ClearAll()
        {
            foreach (Control control in Controls)
            {
                switch (control)
                {
                    case ComboBox comboBox:
                        comboBox.SelectedIndex = -1;
                        comboBox.Text = @"Shape";
                        break;
                    case TextBox textBox:
                        textBox.Text = string.Empty;
                        if (textBox.Name == "RadiusTextBox_Circle") textBox.Hide();
                        if (textBox.Name == "WidthTextBox_Square") textBox.Hide();
                        if (textBox.Name == "WidthTextBox_Rectangle") textBox.Hide();
                        if (textBox.Name == "HeightTextBox_Rectangle") textBox.Hide();
                        break;
                    case Label label:
                        if (label.Name == "RadiusLabel") label.Hide();
                        if (label.Name == "WidthLabel") label.Hide();
                        if (label.Name == "HeightLabel") label.Hide();
                        break;
                }
            }
        }

        private void ClearContext()
        {
            foreach (Control control in Controls)
            {
                switch (control)
                {
                    case TextBox textBox:
                        if (textBox.Name != "RedTextBox" && textBox.Name != "GreenTextBox" && textBox.Name != "BlueTextBox") textBox.Text = string.Empty;
                        if (textBox.Name == "RadiusTextBox_Circle") textBox.Hide();
                        if (textBox.Name == "WidthTextBox_Square") textBox.Hide();
                        if (textBox.Name == "WidthTextBox_Rectangle") textBox.Hide();
                        if (textBox.Name == "HeightTextBox_Rectangle") textBox.Hide();
                        break;
                    case Label label:
                        if (label.Name == "RadiusLabel") label.Hide();
                        if (label.Name == "WidthLabel") label.Hide();
                        if (label.Name == "HeightLabel") label.Hide();
                        break;
                }
            }
        }

        private void RTextBox_TextChanged(object sender, EventArgs e)//Red value for RGB
        {
            try
            {
                if (!string.IsNullOrEmpty(RedTextBox.Text))
                {
                    _painter.SetRed(RedTextBox.Text);
                }
            }
            catch (FormatException)
            {
                //make pop-up box and set value back to 0


            }
        }

        private void GTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(GreenTextBox.Text))
                {
                    _painter.SetGreen(GreenTextBox.Text);
                }
            }
            catch (FormatException)
            {
                //make pop-up box and set value back to 0

            }
        }

        private void BTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(BlueTextBox.Text))
                {
                    _painter.SetBlue(BlueTextBox.Text);
                }
            }
            catch (FormatException)
            {
                //make pop-up box and set value back to 0

            }
        }

        private void XCoordinate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(XCoordinatesTextBox.Text))
                {
                    _coordinates.SetXCoordinate(XCoordinatesTextBox.Text);
                }
            }
            catch (FormatException)
            {
                //make pop-up box and set value back to 0

            }
        }

        private void YCoordinate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(YCoordinatesTextBox.Text))
                {
                    _coordinates.SetYCoordinate(YCoordinatesTextBox.Text);
                }
            }
            catch (FormatException)
            {
                //make pop-up box and set value back to 0

            }
        }

        private void RectangleHeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(HeightTextBox_Rectangle.Text))
                {
                    shape.SetHeight(HeightTextBox_Rectangle.Text);
                }
            }
            catch (FormatException)
            {
                //make pop-up box and set value back to 0

            }
        }

        private void RectangleWidth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(WidthTextBox_Rectangle.Text))
                {
                    shape.SetWidth(WidthTextBox_Rectangle.Text);
                }
            }
            catch (FormatException)
            {
                //make pop-up box and set value back to 0

            }
        }

        private void SquareWidth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(WidthTextBox_Square.Text))
                {
                    shape.SetWidth(WidthTextBox_Square.Text);
                }
            }
            catch (FormatException)
            {
                //make pop-up box and set value back to 0

            }
        }

        private void CircleRadius_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(RadiusTextBox_Circle.Text))
                {
                    shape.SetRadius(RadiusTextBox_Circle.Text);
                }
            }
            catch (FormatException)
            {
                //make pop-up box and set value back to 0

            }
        }

        //Here begins the code to move drawn objects based on clicking and dragging
        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e) => mouseDown = true;
        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e) => mouseDown = false;
        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                _coordinates.SetXCoordinate(e.X.ToString());
                _coordinates.SetYCoordinate(e.Y.ToString());
                DrawingPanel.Invalidate();
            }
        }
    }
}
