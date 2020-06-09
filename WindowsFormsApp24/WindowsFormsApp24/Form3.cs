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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            {

                Form3.ActiveForm.Hide();
                Form1 f3 = new Form1();
                f3.Show();

            }
        }

       
    }
}
