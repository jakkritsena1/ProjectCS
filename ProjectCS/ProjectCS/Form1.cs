using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Formats.Asn1;
using System.Globalization;
using CsvHelper;
using System.Reflection;
using System.Xml;

namespace ProjectCS
{
    public partial class Form1 : Form
    {
        private String[] tps = { "3.0", "4.0", "5.0", "7.5", "10.0", "15.0", "20.0", "25.0", "30.0", "40.0", "60.0", "80.0", "90.0", "95.0", "100.0" };
        private String[] rpm = { "700", "850", "1000", "1125", "1250", "1500", "1750", "2000", "2250", "2500", "2750", "3000", "3250", "3500", "3750", "4000", "4500", "5000", "5500", "6000", "6500" };
        private string[,] dataSetVeFront =
                    {
        {"31.0", "31.8", "33.0", "35.0", "44.9", "59.1", "73.8", "84.5", "86.5", "86.5", "86.5", "86.5", "86.5", "86.5", "86.5"},
        {"32.6", "34.5", "37.3", "36.5", "44.9", "59.1", "73.8", "84.0", "87.5", "88.5", "88.5", "88.5", "88.5", "88.5", "88.5"},
        {"33.5", "35.2", "38.2", "38.2", "44.9", "59.1", "73.8", "84.1", "88.5", "90.5", "90.5", "89.5", "89.5", "89.5", "89.5"},
        {"39.4", "37.8", "39.8", "40.6", "44.9", "59.1", "73.8", "84.8", "89.5", "91.0", "91.0", "91.0", "91.0", "91.0", "91.0"},
        {"58.5", "52.0", "42.7", "42.1", "46.7", "59.1", "73.8", "83.3", "86.9", "89.4", "90.4", "90.4", "90.4", "90.4", "90.4"},
        {"62.7", "55.9", "45.7", "43.5", "48.4", "61.0", "73.8", "83.8", "89.3", "90.6", "92.1", "93.1", "93.1", "92.6", "92.6"},
        {"62.7", "56.6", "47.2", "44.3", "48.3", "60.6", "69.9", "79.9", "88.2", "90.8", "92.3", "92.3", "93.3", "92.3", "93.3"},
        {"62.1", "59.7", "49.4", "44.5", "46.7", "58.9", "65.5", "72.9", "86.3", "90.5", "90.0", "89.5", "89.5", "89.5", "89.5"},
        {"64.3", "63.8", "50.2", "43.7", "45.8", "57.1", "63.1", "65.0", "79.2", "83.2", "83.2", "83.2", "83.2", "83.2", "83.2"},
        {"64.7", "64.1", "49.5", "44.4", "46.0", "54.9", "63.6", "66.5", "72.9", "79.1", "80.4", "80.4", "80.4", "80.4", "80.4"},
        {"63.9", "61.5", "50.9", "43.2", "45.7", "59.6", "66.8", "70.7", "75.2", "78.4", "79.4", "79.9", "79.9", "79.4", "79.9"},
        {"67.7", "58.3", "49.7", "42.5", "45.7", "59.8", "69.8", "72.1", "75.4", "76.2", "77.2", "77.2", "77.2", "77.2", "77.2"},
        {"66.7", "60.3", "49.5", "44.5", "45.7", "65.7", "71.4", "74.7", "75.3", "75.0", "76.1", "76.1", "76.1", "76.1", "76.1"},
        {"65.6", "67.3", "60.2", "49.7", "48.6", "68.4", "72.9", "73.5", "71.4", "70.6", "69.2", "69.2", "69.2", "69.2", "69.2"},
        {"67.1", "67.6", "68.3", "65.3", "67.8", "67.9", "80.9", "81.9", "77.8", "71.9", "71.0", "71.0", "71.0", "71.0", "71.0"},
        {"82.4", "83.0", "80.1", "70.9", "72.1", "80.7", "85.2", "85.0", "80.7", "73.7", "74.4", "75.4", "75.4", "75.4", "75.4"},
        {"95.8", "96.3", "95.0", "78.0", "79.9", "84.0", "89.9", "91.3", "86.1", "78.3", "77.8", "77.8", "77.8", "77.8", "77.8"},
        {"98.4", "97.1", "95.7", "84.4", "83.6", "84.1", "88.1", "93.0", "88.6", "80.6", "82.0", "82.0", "82.4", "82.4", "82.9"},
        {"80.5", "80.5", "80.5", "80.9", "80.9", "79.4", "84.0", "89.3", "85.3", "79.1", "79.1", "79.1", "79.1", "79.1", "79.1"},
        {"81.1", "81.1", "81.1", "81.1", "81.1", "79.6", "83.6", "87.6", "80.0", "74.6", "74.6", "74.6", "74.6", "74.6", "74.6"},
        {"81.5", "81.5", "81.5", "81.5", "81.5", "82.0", "82.9", "83.9", "74.9", "70.4", "70.4", "70.4", "70.4", "70.4", "70.4"}
                    };

        private string[,] dataSetVeRear =
            {
        {"33.2", "33.7", "35.7", "37.6", "42.0", "53.3", "67.0", "78.5", "84.5", "84.5", "84.5", "84.5", "84.5", "84.5", "84.5"},
        {"34.7", "35.0", "37.3", "38.1", "42.0", "53.3", "66.7", "79.0", "86.0", "86.0", "86.0", "86.0", "86.0", "86.0", "86.0"},
        {"36.0", "36.2", "37.0", "38.1", "42.0", "53.3", "66.3", "78.7", "85.0", "85.0", "85.0", "85.0", "85.0", "85.0", "85.0"},
        {"38.0", "37.6", "37.4", "38.3", "42.0", "53.3", "64.8", "78.2", "84.5", "86.0", "86.0", "86.0", "86.0", "86.0", "86.0"},
        {"46.4", "46.6", "39.6", "39.1", "41.6", "53.3", "63.3", "76.6", "83.8", "86.8", "86.8", "86.8", "86.8", "86.8", "86.8"},
        {"54.9", "51.7", "40.7", "38.9", "42.7", "53.3", "62.9", "74.1", "82.7", "86.0", "86.5", "86.5", "86.5", "86.5", "86.5"},
        {"57.3", "52.3", "41.5", "38.6", "41.9", "54.1", "61.9", "71.5", "82.3", "86.1", "86.6", "87.1", "87.1", "86.6", "86.6"},
        {"59.6", "54.5", "42.6", "38.0", "40.4", "53.3", "60.3", "68.8", "79.1", "83.6", "84.6", "85.1", "85.1", "85.6", "86.1"},
        {"62.6", "60.2", "44.0", "36.9", "40.3", "52.4", "60.4", "67.3", "75.8", "81.6", "82.1", "82.1", "82.1", "82.1", "82.1"},
        {"63.8", "62.4", "43.5", "38.4", "41.8", "51.9", "61.8", "65.7", "65.6", "74.3", "76.2", "75.2", "75.2", "75.2", "75.2"},
        {"62.8", "61.9", "44.8", "36.9", "38.9", "50.8", "57.3", "60.3", "63.0", "68.9", "69.9", "69.9", "69.9", "69.9", "69.9"},
        {"65.3", "61.1", "49.4", "35.6", "36.8", "46.0", "54.8", "59.0", "64.9", "68.2", "68.8", "68.8", "68.8", "68.8", "68.8"},
        {"68.5", "66.4", "52.8", "35.1", "36.2", "53.1", "58.0", "65.7", "67.4", "68.4", "70.8", "71.3", "71.3", "71.3", "71.3"},
        {"69.1", "67.6", "58.7", "40.5", "40.9", "60.3", "68.7", "73.2", "69.9", "70.6", "74.1", "74.1", "74.1", "74.1", "74.1"},
        {"75.0", "74.8", "67.7", "60.6", "63.1", "64.6", "74.6", "78.3", "79.2", "75.5", "75.5", "75.5", "75.5", "75.5", "75.5"},
        {"82.1", "80.7", "75.2", "68.0", "69.3", "78.2", "84.9", "87.3", "83.3", "76.9", "75.9", "75.4", "75.4", "75.4", "75.4"},
        {"88.3", "88.0", "80.3", "73.0", "74.0", "85.7", "91.0", "89.0", "85.7", "78.0", "76.0", "76.0", "76.0", "76.0", "76.0"},
        {"89.2", "88.1", "81.0", "80.1", "80.1", "86.6", "93.1", "92.3", "86.1", "77.8", "76.0", "76.0", "76.0", "76.0", "76.0"},
        {"83.0", "83.0", "83.2", "83.2", "83.2", "86.5", "91.5", "91.9", "85.6", "75.2", "73.8", "73.8", "73.8", "73.8", "73.8"},
        {"83.0", "83.0", "83.2", "83.2", "83.2", "87.3", "91.7", "92.2", "85.0", "72.8", "71.8", "71.8", "71.8", "71.8", "71.8"},
        {"83.0", "83.0", "83.2", "83.2", "82.2", "85.2", "87.3", "88.4", "79.4", "70.4", "69.5", "69.5", "69.5", "69.5", "69.5"}
            };
        private int index = 0;
        private string[,] NewVEs_Front = new string[21, 15];
        List<float> lambda_value = new List<float>();
        public class HDXRecord
        {
            public string RPM { get; set; }
            public string TPS { get; set; }
            public string LAMBDA { get; set; }
        }
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
            table1.Rows.Add(21);
            table2.Rows.Add(21);
            foreach (string rp in rpm)
            {
                table1.Rows[index].HeaderCell.Value = rp;
                table2.Rows[index].HeaderCell.Value = rp;
                index++;
            }
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

        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfile = new OpenFileDialog())
            {
                openfile.InitialDirectory = "c:/";
                openfile.Filter = "CSV Files (*.csv)|*.csv|HDX Files (*.hdx)|*.hdx";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openfile.FileName;
                    if (filePath.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
                    {
                        List<dynamic> records = ReadCSVFile(filePath);
                        ProcessCsvRecords(records);
                    }
                    else if (filePath.EndsWith(".hdx", StringComparison.OrdinalIgnoreCase))
                    {
                        List<HDXRecord> hdxRecords = ReadHDXFile(filePath);
                        ProcessRecordHDX(hdxRecords);
                    }
                }
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 15; j++)
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (NewVEs_Front[i, j] == "0.0" || string.IsNullOrEmpty(NewVEs_Front[i, j]))
                    {
                        NewVEs_Front[i, j] = dataSetVeFront[i, j];
                    }
                    table1.Rows[i].Cells[j].Value = NewVEs_Front[i, j];
                }
            }
        }
        private List<HDXRecord> ReadHDXFile(string filePath)
        {
            List<HDXRecord> hdxRecords = new List<HDXRecord>();
            string rpm = ""; 
            string tps = ""; 
            string lambda = ""; 

            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found: " + filePath);
                return hdxRecords;
            }
            try
            {
                xmlDoc.Load(filePath);
                XmlNodeList dataItems = xmlDoc.SelectNodes("//dataItem");
                foreach (XmlNode dataItem in dataItems)
                {
                    string name = dataItem.SelectSingleNode("Name").InnerText;
                    string itemValueStr = dataItem.SelectSingleNode("ItemValue").InnerText;
                    float itemValue;
                    float.TryParse(itemValueStr, out itemValue);
                    if (name == "d_eng_speed")
                    {
                        rpm = itemValue.ToString();
                    }
                    else if (name == "d_tps_pct")
                    {
                        tps = itemValue.ToString();
                    }
                    //else if (name == "d_lamda_desired")
                    else if (name == "d_lamfeedback_f")
                    {
                        lambda = itemValue.ToString();
                    }
                        HDXRecord hdxRecord = new HDXRecord
                        {
                            RPM = rpm,
                            TPS = tps,
                            LAMBDA = lambda,
                        };
                        hdxRecords.Add(hdxRecord);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading HDX file: " + ex.Message);
            }

            return hdxRecords;
        }

        private void ProcessRecordHDX(List<HDXRecord> hdxRecords)
        {
            foreach (var hdxRecord in hdxRecords)
            {
                float RPM, TPS, LAMBDA;
                float.TryParse(hdxRecord.RPM, out RPM);
                float.TryParse(hdxRecord.TPS, out TPS);
                float.TryParse(hdxRecord.LAMBDA, out LAMBDA);
                for (int i = 0; i < rpm.Length; i++)
                {
                    if (RPM <= float.Parse(rpm[i]))
                    {
                        for (int j = 0; j < tps.Length; j++)
                        {
                            if (TPS <= float.Parse(tps[j]))
                            {
                                UpdateLambdaValueArray(i, j, LAMBDA);
                            }
                        }
                    }
                }
            }
        }
        private List<dynamic> ReadCSVFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return csv.GetRecords<dynamic>().ToList();
                }
            }
            else
            {
                MessageBox.Show("File not found: " + filePath);
                return null;
            }
        }
        private void ProcessCsvRecords(List<dynamic> records)
        {
            if (records == null) return;

            foreach (var record in records)
            {
                ProcessRecord(record);
            }
        }
        private void ProcessRecord(dynamic record)
        {
            var recordDict = record as IDictionary<string, object>;
            if (recordDict == null ||
                !recordDict.ContainsKey("d_eng_speed") ||
                !recordDict.ContainsKey("d_tps_pct") ||
                !recordDict.ContainsKey("d_lamda_desired"))
            {
                return;
            }
            float engSpeed, TPS, lambda;
            float.TryParse(recordDict["d_eng_speed"].ToString(), out engSpeed);
            float.TryParse(recordDict["d_tps_pct"].ToString(), out TPS);
            float.TryParse(recordDict["d_lamda_desired"].ToString(), out lambda);
            for (int i = 0; i < rpm.Length; i++)
            {
                if (engSpeed <= float.Parse(rpm[i]))
                {
                    for (int j = 0; j < tps.Length; j++)
                    {
                        if (TPS <= float.Parse(tps[j]))
                        {
                            UpdateLambdaValueArray(i, j, lambda);
                        }
                    }
                }
            }
        }

        private void UpdateLambdaValueArray(int i, int j, float lambda)
        {
            lambda_value.Add(lambda);
            //สูตรคำนวณ 
            float New_VEs = float.Parse(dataSetVeFront[i, j]) * lambda;
            string New_VEs_str = New_VEs.ToString("0.0");
            NewVEs_Front[i, j] = New_VEs_str;
            radioButton2.Enabled = true;
        }
    }
}
