using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;
using Functions;

namespace HourTracker
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Passes setting form an argument to show we are not running for the first time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void SettingsButtonClicked(object sender, EventArgs e)
        {
            string firstrun = "no";

            settingsForm frm = new settingsForm(firstrun);
            frm.ShowDialog();
        }

        /// <summary>
        /// Called from View ro button. opens view ro button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void ViewButtonClicked(object sender, EventArgs e)
        {
            if (roList.SelectedItem == null)
            {
                MessageBox.Show("You have to select a repair order.", "Error");
            }
            else
            {
                string roSelected = roList.SelectedItem.ToString();
                string dateSelected = roDate.SelectionRange.Start.ToShortDateString();

                viewForm frm = new viewForm(roSelected, dateSelected);
                frm.ShowDialog();
            }
        }

        /// <summary>
        /// Called from quit button. Closes program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void QuitButtonClicked(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Grabs selected date passes that as an argument to the add ro form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void AddROButtonClicked(object sender, EventArgs e)
        {
            string dateSelected = roDate.SelectionRange.Start.ToShortDateString();
            addForm frm = new addForm(dateSelected);
            frm.ShowDialog();
        }

        /// <summary>
        /// Called from view ro button. Grabs selected date from the calendar and reads data file
        /// and shows ros with matching date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void FillROListbox(object sender, DateRangeEventArgs e)
        {
            string arrayData;
            string dateSelected = roDate.SelectionRange.Start.ToShortDateString().Replace(@"/", "");
            char[] splitChar = { '|' };
            var file = new StreamReader(HoursFile.Location);

            roList.Items.Clear();

            while ((arrayData = file.ReadLine()) != null)
            {
                string[] parsedData = arrayData.Split(splitChar);

                if (parsedData[0] == dateSelected)
                {
                    roList.Items.Add(parsedData[1]);
                }
            }
            file.Close();
        }
    }
}
