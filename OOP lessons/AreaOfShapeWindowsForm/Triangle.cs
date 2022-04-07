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
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void triSub_Click(object sender, EventArgs e)
        {
            double sideA = double.Parse(txtA.Text);
            double sideB = double.Parse(txtB.Text);
            double sideC = double.Parse(txtC.Text);

            double semiPerim = (sideA + sideB + sideC) / 2;
            double area = Math.Round(Math.Sqrt(semiPerim * (semiPerim - sideA)
                * (semiPerim - sideB) * (semiPerim - sideC)), 4);
            triAns.Text = "The area of the triangle is: " + area.ToString();
        }
    }
}
