using System;
using System.Windows.Forms;
using Functions;

namespace HourTracker
{
    public partial class settingsForm : Form       
    {
        string requirelogin;

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

        // Get the path of the datafile and show it in the textbox
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

        // add service to listbox
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

        // handles the read only attributes of the uname and pword textboxs
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

        // kind of clear what this does
        private void CancelButtonClicked(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // write everything needed to registry
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

        // Restart program after settings are written to registry
        private void RestartButtonClicked(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
