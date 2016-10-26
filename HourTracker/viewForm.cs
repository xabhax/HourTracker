using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using Functions;

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
        /// iterate through datafile and fill listbox with services for given repair order
        /// </summary>
        /// <param name="ro"></param>
        /// <returns></returns>
        private void FillListBox(string ro)
        {
            string arrayData;
            char[] splitChar = { '|' };

            var file = new StreamReader(HoursFile.Location);

            while ((arrayData = file.ReadLine()) != null)
            {
                string[] parsedData = arrayData.Split(splitChar);

                if (parsedData[1] == ro)
                {
                    for (int i = 2; i < parsedData.Length; i++)
                    {
                        servicesList.Items.Add(parsedData[i].ToString());
                        string tmp = Registry.GetValue("HKEY_CURRENT_USER\\Software\\HourTracker\\services", parsedData[i], null).ToString();
                        decimal d = decimal.Parse(tmp);

                        flag = flag + d;
                    }
                }
            }
            flaggedHoursDisplay.Text = flag.ToString();
            file.Close();
        }
    }
}
