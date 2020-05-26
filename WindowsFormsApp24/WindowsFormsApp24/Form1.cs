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
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1; // Количество строк, отображаемых в объекте DataGridView.
            dataGridView1.ColumnCount = 36; // Число столбцов, отображаемых в объекте DataGridView.
            Random rnd = new Random();
            for (int i = 0; i < 36; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = rnd.Next(0, 50);
                dataGridView1.Rows[0].Cells[i].Value = i;
            }



        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
        }

    }
}
