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
    public partial class Form1 : Form
    {
        Paint paint = new Paint();

        public Form1()
        {
            InitializeComponent();
        }

        private void ShapeCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShapeCBox.Items.Add("Rectangle");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RTextBox.TextChanged += new System.EventHandler(this.RTextBox_TextChanged);
            GTextBox.TextChanged += new System.EventHandler(this.GTextBox_TextChanged);
            BTextBox.TextChanged += new System.EventHandler(this.BTextBox_TextChanged);
        }

        private void BLabel_Click(object sender, EventArgs e)
        {
            if ( radioButton1.Checked == true)
            {

                

            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void RTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(RTextBox.Text))
                {


                    paint.SetColor(RTextBox.Text, GTextBox.Text, BTextBox.Text);
                }
            }
            catch (Exception)
            {
                //make popo up box and set value back to 0
              
            }
        }

        private void GTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(GTextBox.Text))
            {


                paint.SetColor(RTextBox.Text, GTextBox.Text, BTextBox.Text);
            }
        }

        private void BTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BTextBox.Text))
            {


                paint.SetColor(RTextBox.Text, GTextBox.Text, BTextBox.Text);
            }
        }
    }
}
