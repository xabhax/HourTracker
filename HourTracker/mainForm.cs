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

        // goto settings form
        private void SettingsButtonClicked(object sender, EventArgs e)
        {
            string firstrun = "no";

            settingsForm frm = new settingsForm(firstrun);
            frm.ShowDialog();
        }

        // ViewRO button was clicked, open up the viewform
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

        // close program
        private void QuitButtonClicked(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // grabs the date and opens up the addro form
        private void AddROButtonClicked(object sender, EventArgs e)
        {
            string dateSelected = roDate.SelectionRange.Start.ToShortDateString();
            addForm frm = new addForm(dateSelected);
            frm.ShowDialog();
        }

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
