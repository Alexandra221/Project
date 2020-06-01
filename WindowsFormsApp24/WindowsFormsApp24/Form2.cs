using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Main_form_Click(object sender, EventArgs e)
        {


            {

                Form2.ActiveForm.Hide();
                Form1 f2 = new Form1();
                f2.Show();

            }
        }


        private void Developer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox1.Show();
            else textBox1.Hide();
    
          
        }

        private void Reference_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                textBox2.Show();
            else textBox2.Hide();
        }
    }
}
