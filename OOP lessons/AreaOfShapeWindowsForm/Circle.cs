using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaOfShapeWindowsForm
{
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            double rad = double.Parse(txtRadius.Text);
            double area = Math.Round(Math.PI * Math.Pow(rad, 2), 4);
            cirAns.Text = "The area of the circle is: " + area.ToString();
        }
    }
}
