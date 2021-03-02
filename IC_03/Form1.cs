using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IC_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_enterWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            double ew = 0;
            ew = double.Parse(tb_enterWeight.Text);
            //Conversion to mars weight

            ew *= 0.377;

            tb_newWeight.Text = ew + "";

        }

        private void tb_newWeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
