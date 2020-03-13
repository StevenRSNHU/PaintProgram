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
        private readonly Painter _painter = new Painter();

        public DrawingProgram()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }

        private void ShapeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ShapeBox.SelectedIndex)
            {
                case 0: //rectangle
                    RedTextBox.Select();
                    Clear();
                    WidthLabel.Show();
                    HeightLabel.Show();
                    WidthTextBox_Rectangle.Show();
                    HeightTextBox_Rectangle.Show();
                    break;
                case 1: //square
                    RedTextBox.Select();
                    Clear();
                    WidthLabel.Show();
                    WidthTextBox_Square.Show();
                    break;
                case 2: //circle
                    RedTextBox.Select();
                    Clear();
                    RadiusLabel.Show();
                    RadiusTextBox_Circle.Show();
                    break;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
            DrawingPanel.Invalidate();
        }

        private void DrawingProgram_Load(object sender, EventArgs e)
        {
            RedTextBox.TextChanged += new System.EventHandler(this.RTextBox_TextChanged);
            GreenTextBox.TextChanged += new System.EventHandler(this.GTextBox_TextChanged);
            BlueTextBox.TextChanged += new System.EventHandler(this.BTextBox_TextChanged);
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


                    _painter.SetGreen(GreenTextBox.Text);
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


                    _painter.SetBlue(BlueTextBox.Text);
                }
            }
            catch (Exception)
            {
                //make popo up box and set value back to 0

            }
        }

        private void Clear()
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
    }
}
