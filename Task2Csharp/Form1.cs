using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task2Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            String line;
            table.Text = "";
            rows = new List<string>();
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pathToFile.Text = dialog.FileName;
                }
                else
                {
                    return;
                }
                StreamReader sr = new StreamReader(pathToFile.Text);
                line = sr.ReadLine();
                while (line != null)
                {
                    table.Text += line + "\n";
                    rows.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            table.Text = "";
            if (rows.Count == 0) return;
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    pathToFile.Text = folderBrowserDialog.SelectedPath + "\\output.txt";
                }
                else
                {
                    return;
                }
                StreamWriter sw = new StreamWriter(pathToFile.Text);

                foreach (string row in rows)
                {
                    string[] numbers = row.Split(new char[] { ' ', '|', '/', '&', '%', '$', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    int sum = 0;
                    foreach (string num in numbers)
                    {
                        int number = Int32.Parse(num.Trim());
                        sum += number;
                    }

                    sw.WriteLine(sum);
                }


                sw.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}
