using System;
using System.Windows.Forms;
using Functions;

namespace HourTracker
{
    public partial class settingsForm : Form       
    {
        string requirelogin;

        /// <summary>
        /// Makes registry keys if this is the first run. If it isnt it will populate the data file location
        /// and fill listbox with services from registry key
        /// </summary>
        /// <param name="firstrun">yes for never being run, and no if called from main dialog</param>
        /// <returns></returns>
        public settingsForm(string firstrun)
        {
            InitializeComponent();

            if (firstrun == "no")
            {
                string tmpa = HoursFile.Location;
                Microsoft.Win32.RegistryKey root = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\hourtracker\\services");

                dataFilePath.Text = tmpa;
                applybutton.Enabled = false;
                restartbutton.Enabled = false;
                databutton.Enabled = false;
                requireLoginBox.Enabled = false;
                cancelbutton.Text = "Ok";

                foreach (string keyname in root.GetValueNames())
                {
                    string tmp = Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\Software\\HourTracker\\services", keyname, null).ToString();
                    string tableData = String.Join("  ", keyname, tmp);

                    servicesList.Items.Add(tableData);
                }
            }
            else
            {
                Microsoft.Win32.RegistryKey tempkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("hourtracker");
                Microsoft.Win32.RegistryKey servicekey = tempkey.CreateSubKey("services");
            }
        }

        /// <summary>
        /// Called from save file dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void SaveDataFile(object sender, EventArgs e)
        {
            SaveFileDialog datafiledlg = new SaveFileDialog();

            datafiledlg.Filter = "Hour Tracker datafile (*.hthf)|*.hthf";
            datafiledlg.FileName = "hours.hthf";
            datafiledlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            datafiledlg.RestoreDirectory = true;
            DialogResult result;

            result = datafiledlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                dataFilePath.Text = datafiledlg.FileName;
            }
        }

        /// <summary>
        /// Called from add service button. grabs text from text boxes and inputs into listbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void AddService(object sender, EventArgs e)
        {
            if (serviceName.Text.Contains(" ") != true)
            {
                string tableData = String.Join("  ", serviceName.Text, serviceHours.Text);

                servicesList.Items.Add(tableData);

                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Software\\HourTracker\\services", serviceName.Text, serviceHours.Text);

                serviceName.Clear();
                serviceHours.Clear();
            }
            else
            {
                MessageBox.Show("Service names can not contain spaces", "Error");
                serviceName.Clear();
            }
        }

        /// <summary>
        /// Handles the read only attributes for the username and password text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void RequireLogin(object sender, EventArgs e)
        {
            if(userName.ReadOnly == true)
            {
                requirelogin = "true";
                userName.ReadOnly = false;
                passWord.ReadOnly = false;
            }

            else
            {
                requirelogin = "false";
                userName.ReadOnly = true;
                passWord.ReadOnly = true;
            }
        }

        /// <summary>
        /// Obvious
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void CancelButtonClicked(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Goes through all text boxes and listbox and saves all information to the registry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void ApplyButtonClicked(object sender, EventArgs e)
        {
            if (requireLoginBox.Checked)
            {
                if (userName.Text.Length != 0 && passWord.Text.Length != 0 && dataFilePath.Text.Length != 0)
                {
                    Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Software\\HourTracker", "requirelogin", "true");
                    Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Software\\HourTracker", "username", Credentials.Encrypt(userName.Text));
                    Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Software\\HourTracker", "password", Credentials.Encrypt(passWord.Text));
                    Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Software\\HourTracker", "datafile", dataFilePath.Text.ToString());
                }
                else
                {
                    MessageBox.Show("You must complete all fields before applying changes", "Error");
                }
            }

            else
            {
                if (dataFilePath.Text.Length != 0)
                {
                    Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Software\\HourTracker", "datafile", dataFilePath.Text.ToString());
                }
                else
                {
                    MessageBox.Show("You must complete all fields before applying changes", "Error");
                }
            }
        }

        /// <summary>
        /// Called from restart button. Restarts application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void RestartButtonClicked(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
