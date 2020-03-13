using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint_project
{
    public partial class DrawingProgram : Form
    {
        Painter _painter = new Painter();
        Coordinates coor = new Coordinates();
        Dimensions shape = new Dimensions();

        public DrawingProgram()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void DrawingProgram_Load(object sender, EventArgs e)
        {
            RedTextBox.TextChanged += new System.EventHandler(this.RTextBox_TextChanged);
            GreenTextBox.TextChanged += new System.EventHandler(this.GTextBox_TextChanged);
            BlueTextBox.TextChanged += new System.EventHandler(this.BTextBox_TextChanged);
        }

        private void BLabel_Click(object sender, EventArgs e)
        {
            if ( radioButton1.Checked == true)
            {
<<<<<<< Updated upstream
=======
                case 0://Rectangle
                    g.DrawRectangle(userPen,coor.XCoordinate(), coor.YCoordinate(),
                        shape.GetWidth(),shape.GetHeight() );
                    break;
                case 1://Square
                    g.DrawRectangle(userPen, coor.XCoordinate() , coor.YCoordinate(), 
                        shape.GetWidth(), shape.GetWidth());
                    break;
                case 2://Circle
                    g.DrawEllipse(userPen, coor.XCoordinate(), coor.YCoordinate(),
                        shape.GetRadius(), shape.GetRadius());
                    break;
                
            }
        }
>>>>>>> Stashed changes

                

<<<<<<< Updated upstream
=======
        private void ClearContext()//Hides vlaues within textboxes
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
>>>>>>> Stashed changes
            }
        }

        private void RTextBox_TextChanged(object sender, EventArgs e)//Red value for RGB
        {
            try
            {
                if (!string.IsNullOrEmpty(RedTextBox.Text))
                {


                    _painter.SetColor(RedTextBox.Text, GreenTextBox.Text, BlueTextBox.Text);
                }
            }
            catch (Exception)
            {
                //make popo up box and set value back to 0
              
            }
        }

        private void GTextBox_TextChanged(object sender, EventArgs e)//Green value for RGB
        {
            try
            {
                if (!string.IsNullOrEmpty(GreenTextBox.Text))
                {


                    _painter.SetColor(RedTextBox.Text, GreenTextBox.Text, BlueTextBox.Text);
                }
            }
            catch (Exception)
            {
                //make popo up box and set value back to 0

            }
        }

        private void BTextBox_TextChanged(object sender, EventArgs e)//Blue value for RGB
        {
            try
            {
                if (!string.IsNullOrEmpty(BlueTextBox.Text))
                {


                    _painter.SetColor(RedTextBox.Text, GreenTextBox.Text, BlueTextBox.Text);
                }
            }
            catch (Exception)
            {
                //make popo up box and set value back to 0

            }
        }

        private void XCoordinate_TextChanged(object sender, EventArgs e)//Sets starting position on the x-axis
        {
            try
            {
                if (!string.IsNullOrEmpty(XCoordinatesTextBox.Text))
                {
                    coor.SetX(XCoordinatesTextBox.Text);
                }
            }
            catch (FormatException)
            {

                throw;
            }
        }

        private void YCoordinate_TextChanged(object sender, EventArgs e)//Sets starting position on the y-axis
        {
            try
            {
                if (!string.IsNullOrEmpty(YCoordinatesTextBox.Text))
                {
                    coor.SetY(YCoordinatesTextBox.Text);
                }
            }
            catch (FormatException)
            {

                throw;
            }
        }

        private void WidthRectangle_TextChanged(object sender, EventArgs e)//Sets width for rectangle shape
        {
            try
            {
                if (!string.IsNullOrEmpty(WidthTextBox_Rectangle.Text))
                {
                    shape.ShapeWidth(WidthTextBox_Rectangle.Text);
                }
            }
            catch (FormatException)
            {

                throw;
            }
        }

        private void HeightRectangle_TextChanged(object sender, EventArgs e)//Sets height for the rectangle shape
        {
            try
            {
                if (!string.IsNullOrEmpty(HeightTextBox_Rectangle.Text))
                {
                    shape.ShapeHeight(HeightTextBox_Rectangle.Text);
                }
            }
            catch (FormatException)
            {

                throw;
            }
        }

        private void WidthSquare_TextChanged(object sender, EventArgs e)//Sets side length for square shape
        {
            try
            {
                if (!string.IsNullOrEmpty(WidthTextBox_Square.Text))
                {
                    shape.ShapeWidth(WidthTextBox_Square.Text);
                }
            }
            catch (FormatException)
            {

                throw;
            }
        }

        private void RadiusCircle_TextChanged(object sender, EventArgs e)//Sets the radius for circle shape
        {
            try
            {
                if (!string.IsNullOrEmpty(RadiusTextBox_Circle.Text))
                {
                    shape.ShapeRadius(RadiusTextBox_Circle.Text);
                }
            }
            catch (FormatException)
            {

                throw;
            }
        }
    }
}
