using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private String[] tps = { "0","2.3", "5.0", "10", "15", "20", "30", "40", "60", "80", "100" };
        private String[] rpm = { "750", "1000", "1250", "1500", "1750", "2000", "2250", "2500", "2750", "3000", "3500", "4000", "4500", "5000", "5500", "6000", "6500", "7000" };
        private double[,] dataSetVeFront = new double[18, 11];
        private double[,] dataSetVeRear = new double[18, 11];
        private string selectedFile;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string tp in tps)
            {
                table1.Columns.Add(tp, tp);
                table2.Columns.Add(tp, tp);
            }
            table1.Rows.Add(18);
            table2.Rows.Add(18);
            foreach (DataGridViewColumn column in table1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn column in table2.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            int index = 0;
            foreach (string rp in rpm)
            {
                table1.Rows[index].HeaderCell.Value = rp;
                table2.Rows[index].HeaderCell.Value = rp;
                index++;
            }
        }

        private void table1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfile = new OpenFileDialog())
            {
                openfile.InitialDirectory = "c:/";
                openfile.Filter = "Excel Files (*.csv*)|*.csv*";
                DialogResult result = openfile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFile = openfile.FileName;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;
                    radioButton5.Enabled = true;
                }
                else
                {
                    radioButton2.Enabled = false;
                    MessageBox.Show(this,"Invalid file.");
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    table1.Rows[i].Cells[j].Value = dataSetVeFront[i, j];
                    table2.Rows[i].Cells[j].Value = dataSetVeRear[i, j];
                }
            }
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
        }

        private void feedforward_netural_network(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedFile != null && File.Exists(selectedFile)) 
            {
                string[] selectFileLines = File.ReadAllLines(selectedFile);
                foreach (string line in selectFileLines)
                {
                    string[] fields = line.Split(',');
                }
            }
            else
            {
                MessageBox.Show("Please select a valid CSV file."); 
            }
        }

    }
}
