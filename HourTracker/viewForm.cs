using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using Functions;
using System.Collections.Generic;

namespace HourTracker
{
    public partial class viewForm : Form
    {
        decimal flag;

        public viewForm(string repairOrder, string roDate)
        {
            InitializeComponent();
            repairOrderDisplay.Text = repairOrder;
            dateFinishedDisplay.Text = roDate;
            FillListBox(repairOrder);
        }

        /// <summary>
        /// Returns us to the main dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void CloseButtonClicked(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// gets the services associated with an ro, fills listbox with said services and adds up
        /// flat rate time and displays it
        /// </summary>
        /// <param name="ro">Repair order to get services for</param>
        /// <returns></returns>
        private void FillListBox(string ro)
        {
            char[] splitChar = { '|' };
            var tmpService = RepairOrder.Services(ro).Split(splitChar);
            decimal flag = 0;

            foreach (var Services in tmpService)
            {
                servicesList.Items.Add(Services);
                string tmp = Registry.GetValue("HKEY_CURRENT_USER\\Software\\HourTracker\\services", Services, null).ToString();
                decimal d = decimal.Parse(tmp);
                flag = flag + d;
            }

            flaggedHoursDisplay.Text = flag.ToString();
        }
    }
}
