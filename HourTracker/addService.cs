using Microsoft.Win32;
using System;
using System.Windows.Forms;
using Functions;

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

        /// <summary>
        /// Called from add form to get the selected service in combobox
        /// </summary>
        /// <returns>Selected service in combobox</returns>
        public string getItem()
        {
            return servicesList.SelectedItem.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void AddServiceClicked(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Called from close button. Closes dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void CancelButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Fills the combo box with services stored in registry key "Hourtracker\Services"
        /// </summary>
        /// <returns></returns>
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
