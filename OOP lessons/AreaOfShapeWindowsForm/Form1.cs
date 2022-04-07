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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formRec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rectangle recForm = new Rectangle();
            recForm.Show();
        }

        private void formCircle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Circle circleForm = new Circle();
            circleForm.Show();
        }

        private void formTri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Triangle triForm = new Triangle();
            triForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
