// CST-150 Activity 3 - Read File and Display Data
// Name: Eric Gathinji
// Date: June 29, 2025
// This code reads a structured text file and formats the content for display in a label


using System;
using System.IO;
using System.Windows.Forms;

namespace CST_150_Activity_3 
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            lblResults.Visible = false;
            lblSelectedFile.Visible = false;
        }

        /// <summary>
        /// Event handler for the "Read File" button click.
        /// Reads Topic3.txt from Data folder and displays results.
        /// </summary>
        private void BtnReadFileClickEvent(object sender, EventArgs e)
        {
            try
            {
                // Get path to Topic3.txt in the /Data folder
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Topic3.txt");

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("The file Topic3.txt was not found.");
                    return;
                }

                lblSelectedFile.Text = $"Selected File: {filePath}";
                lblSelectedFile.Visible = true;

                string[] lines = File.ReadAllLines(filePath);
                string results = "";

                // Add headers
                results += "Item Name         Quantity\tPrice\n";
                results += "------------------------------------------\n";

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 3)
                    {
                        string name = parts[0];
                        int quantity = int.Parse(parts[1]);
                        decimal price = decimal.Parse(parts[2]);

                        results += string.Format("{0,-16}\t{1,5}\t${2,7:F2}\n", name, quantity, price);
                    }
                }

                lblResults.Text = results;
                lblResults.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading the file:\n" + ex.Message);
            }
        }
    }
}
