using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        int[] array = new int[35];
        double sr = 0, count = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void Random_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 35; // The number of columns displayed in the DataGridView object.
            Random rnd = new Random(); // Random array
            for (int i = 0; i < array.Length; i++)

            {
                array[i] = rnd.Next(-50, 50); // Borders of a random array
                dataGridView1.Rows[0].Cells[i].Value = array[i];
            }


        }


        private void Сlearing_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = " ";
                label2.Text = " ";
                label3.Text = " ";
            }
        }

        private void Graph_Click(object sender, EventArgs e)
        {
            int[] x = array;
            int[] y = new int[35];
            for (int i = 0; i < 35; i++)

            {

                y[i] = array[i];
                x[i] = i;
                chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 1;
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 2;
                chart1.Series[0].Points.DataBindXY(x, y);

            }
        }

        private void File_Click(object sender, EventArgs e)
        {
            try

            {
                StreamReader file = new StreamReader(@"C:\\num.txt");
                string[] n = file.ReadToEnd().Split('\n');
                for (int i = 0; i < 35; i++)

                {

                    dataGridView1.Rows[0].Cells[i].Value = n[i];
                    array[i] = Convert.ToInt32(n[i]);

                }

            }

            catch (FileNotFoundException)

            {

                MessageBox.Show("File not found!");

            }
            catch (FormatException)


            {

                MessageBox.Show("Incorrect format!");

            }
            catch (Exception)
            {

                MessageBox.Show("The file is empty");

            }
        }

        private void Transition_Click(object sender, EventArgs e)
        {

            Form1.ActiveForm.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialog = MessageBox.Show
               (
                 "Вы действительно хотите выйти из программы?",
                 "Завершение программы",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning
                );
                if (dialog == DialogResult.Yes) // Return value of the dialog box
                {
                    this.Close(); // Exit application

                }
            }
        }

        private void Task_Click(object sender, EventArgs e)
        {
            int temp = 0;
            for (int i = 0; i < 35; i++)
            {

                if (array[i] < 0)
                {
                    sr += array[i];
                    count++;
                }

            }
            for (int j = 0; j < 20; j++)
            {
                if (array[j] > 0)
                    temp++;
            }

            label3.Text = "Количество положительных элементов:" + temp;
            label2.Text = "Среднее арифметическое отрицательных элементов :" + Math.Round(sr / count, 3);
        }


        private void Sort1_Click(object sender, EventArgs e)
        {
            // Descending sort
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)

                dataGridView1.Rows[0].Cells[i].Value = array[i];

        }


        private void Sort2_Click(object sender, EventArgs e)
        {

            //Ascending sort
            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)

                dataGridView1.Rows[0].Cells[i].Value = array[i];

          }

        }
    }
        


    

     

