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
        string shape;
        Painter _painter = new Painter();

        public DrawingProgram()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            DrawingPanel.Paint += new PaintEventHandler(this.DrawingPanel_Paint);
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

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen userPen = new Pen(Color.FromArgb(_painter.GetRed(), _painter.GetGreen(), _painter.GetBlue()));

            switch (shape)
            {
                case "Rectangle":
                    g.DrawRectangle(userPen,100, 100, 100,100 );// need to add in starting coordinates and dimensions
                    break;
                case "Circle":
                    g.DrawEllipse(userPen,100, 100, 100, 100 );//needs starting coordinates and radius
                    break;
                /*case "Triangle":
                    g.DrawLine(userPen, );
                    break;*/


                default:
                    break;
            }
        }
        private void PickShapeButton_Click(object sender, EventArgs e)
        {
            shape = ShapeBox.SelectedItem.ToString();
        }

        private void BLabel_Click(object sender, EventArgs e)
        {
          
        }

        private void RTextBox_TextChanged(object sender, EventArgs e)
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
                //make popo up box and set value back to 0
              
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
                //make popo up box and set value back to 0

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
                //make popo up box and set value back to 0

            }
        }
    }
}
