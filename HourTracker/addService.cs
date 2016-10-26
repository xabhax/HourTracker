using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace HourTracker
{
    public partial class addService : Form
    {
        public addService()
        {
            InitializeComponent();
            FillComboBox();
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
        }

        // returns selected service to addform
        public string getItem()
        {
            return servicesList.SelectedItem.ToString();
        }

        // Empty function, but it serves a purpose none the less
        private void AddServiceClicked(object sender, EventArgs e)
        {
            
        }

        // obvious 
        private void CancelButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        // populate the combobox with the services added
        private void FillComboBox()
        {
            RegistryKey root = Registry.CurrentUser.OpenSubKey("Software\\hourtracker\\services");

            foreach (string keyname in root.GetValueNames())
            {
                servicesList.Items.Add(keyname);
            }
        }
    }
}
