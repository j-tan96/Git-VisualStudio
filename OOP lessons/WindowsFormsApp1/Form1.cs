using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            int height = int.Parse(txtHeight.Text);
            int width = int.Parse(txtWidth.Text);
            int area = height * width;
            labelAnswer.Text = "The area of the rectangle is: "+area.ToString();
        }
    }
}
