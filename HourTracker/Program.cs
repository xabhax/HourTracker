using System.Windows.Forms;
using Microsoft.Win32;
using System;

namespace HourTracker
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult result;

            // check to see if we have been run before
            if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\HourTracker", "datafile", null) == null)
            {
                string firstrun = "yes";

                Registry.CurrentUser.CreateSubKey("hourtracker");
                Application.Run(new settingsForm(firstrun));
                return;
            }

            // check to see if we require a username and password
            if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\HourTracker", "requirelogin", null) == null)
            {
                // we dont
                Application.Run(new mainForm());
                return;
            }
            else
            {
                // we do
                var loginForm = new loginForm();
                result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // login was successful
                    Application.Run(new mainForm());
                    return;
                }
            }
        }
    }
}
