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

        }

        private void BLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
