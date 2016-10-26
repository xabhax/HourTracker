using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HourTracker
{
    public partial class addForm : Form
    {
        // Main function of addform
        public addForm(string tmpdate)
        {
            InitializeComponent();

            DateTime date = Convert.ToDateTime(tmpdate);
            roDate.SetDate(date);
            roDate.Enabled = false;
        }

        // Return the service to addRO form
        public void Doit(string Value)
        {
            serviceList.Items.Add(Value);
        }

        // Add service to listbox of the addRO form
        public void AddServiceClicked(object sender, EventArgs e)
        {
            addService frm = new addService();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                serviceList.Items.Add(frm.getItem());
            }
            frm.Close();
        }

        // Compile all the ro data and add it to the datafile
        public void AddRoClicked(object sender, EventArgs e)
        {
            if (repairOrder.Text.Length != 0)
            {
                string dataFile = Registry.GetValue("HKEY_CURRENT_USER\\Software\\HourTracker", "DataFile", null).ToString();
                string dateDone = roDate.SelectionRange.Start.ToShortDateString().Replace(@"/", "");

                List<string> filedata = new List<string>();
                filedata.Add(dateDone);
                filedata.Add(repairOrder.Text);

                foreach (var services in serviceList.Items)
                {
                    filedata.Add(services.ToString());
                }

                string writetofile = string.Join("|", filedata.ToArray());
                StreamWriter sw0 = new StreamWriter(dataFile, true);
                sw0.WriteLine(writetofile);
                sw0.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("You have to enter a Repair Order number.", "Error");
            }

        }

        // Go back to the main dialog
        public void CancelButtonClicked(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
