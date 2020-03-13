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

                

            }
        }

        private void RTextBox_TextChanged(object sender, EventArgs e)
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

        private void GTextBox_TextChanged(object sender, EventArgs e)
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

        private void BTextBox_TextChanged(object sender, EventArgs e)
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
    }
}
