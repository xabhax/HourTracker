using System;
using System.Windows.Forms;
using Functions;

namespace HourTracker
{
    public partial class loginForm : Form
    {
        int Counter = 1;

        public loginForm()
        {
            InitializeComponent();
            AttemptCounter.Text = Counter.ToString();
        }

        // check login credentials
        private void CheckLogin(object sender, EventArgs e)
        {
            if (userName.Text.Length != 0 && passWord.Text.Length != 0)
            {
                if (Credentials.Check(userName.Text, passWord.Text) == true)
                {
                    DialogResult = DialogResult.OK;
                }

                else
                {
                    if (Counter == 5)
                    {
                        this.Close();
                    }

                    else
                    {
                        Counter = Counter + 1;
                        AttemptCounter.Text = Counter.ToString();

                        userName.Clear();
                        passWord.Clear();
                    }
                }
            }

            else
            {
                MessageBox.Show("You did not enter a username or password", "Error");
            }
        }  
        
        // quit if cancel button pressed
        private void CancelLogin(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
