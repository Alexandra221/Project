﻿using System;
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
                Form1 f1 = new Form1();
                f1.Show();

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            {

                Form2.ActiveForm.Hide();
                Form3 f3 = new Form3();
                f3.Show();

            }
        }
    }
}
