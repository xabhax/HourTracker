using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Functions;

namespace HourTracker
{
    public partial class addForm : Form
    {
        /// <summary>
        /// Called from mail dialog
        /// </summary>
        /// <param name="tmpdate">Passed date from main form with date selected from calendar</param>
        /// <returns></returns>
        public addForm(string tmpdate)
        {
            InitializeComponent();

            DateTime date = Convert.ToDateTime(tmpdate);
            roDate.SetDate(date);
            roDate.Enabled = false;
        }

        /// <summary>
        /// Called from the add service form. Passed the service name
        /// </summary>
        /// <param name="Value">Service name</param>
        /// <returns></returns>
        public void Doit(string Value)
        {
            serviceList.Items.Add(Value);
        }

        /// <summary>
        /// Called by the ADDSERVICE button. Opens add the add service form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public void AddServiceClicked(object sender, EventArgs e)
        {
            addService frm = new addService();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                serviceList.Items.Add(frm.getItem());
            }
            frm.Close();
        }

        /// <summary>
        /// Called by ADDRO button iterates through service list listbox, adds to list, then calls RepairOrder.Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Called by Cancel button. Its pretty obvious what this does.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public void CancelButtonClicked(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
