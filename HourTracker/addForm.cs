using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Functions;

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
                List<string> ROServices = new List<string>();
                string RODate = roDate.SelectionRange.Start.ToShortDateString().Replace(@"/", "");

                foreach (var services in serviceList.Items)
                {
                    ROServices.Add(services.ToString());
                }

                RepairOrder.Add(RODate, repairOrder.Text, ROServices);
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
