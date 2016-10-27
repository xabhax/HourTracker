using System;
using System.Windows.Forms;
using Functions;
using System.Windows.Input;

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

        /// <summary>
        /// Called from the login button. Calls Credentials.Check against inputed username and password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
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
        
        /// <summary>
        /// Called from cancel button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void CancelLogin(object sender, EventArgs e)
        {
            Dispose();
        }

        private void KeyPressHandler(object sender, System.Windows.Forms.KeyEventArgs e)
        {

        }
    }
}
