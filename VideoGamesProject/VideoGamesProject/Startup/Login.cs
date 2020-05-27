using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGamesProject
{
    public partial class Login : Form
    {
        public Login()
        {
            Thread t = new Thread(new ThreadStart(startScreenSplash));
            t.Start();
            Thread.Sleep(7000);
            InitializeComponent();
            t.Abort();


        }

        public void startScreenSplash()
        {
            Application.Run(new Splash());
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidateChildren(ValidationConstraints.Enabled))
                {

                    string sql = $"Select Count(*) from Login where EmployeeId = '{Convert.ToInt32(txtUserId.Text)}' and Password = '{txtPassword.Text}'";
                    if (Convert.ToInt32(DataAccess.GetValue(sql)) == 1)
                    {
                        this.Hide();
                        new MainForm().Show();
                    }
                    else
                    {

                        MessageBox.Show("Incorrect Id or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }

                }
                else
                {
                    MessageBox.Show("User ID or password must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtUserId_Validating(object sender, CancelEventArgs e)
        {
            epUserId.Clear();
            epUserId.SetError(txtUserId, "");
            if(txtUserId.Text == string.Empty)
            {
                epUserId.Icon = Properties.Resources.errorIcon;
                epUserId.RightToLeft = true;
                epUserId.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                epUserId.SetError(txtUserId, "User ID cannot be empty");
                e.Cancel = true;
            }
            else if (!int.TryParse(txtUserId.Text, out int age))
            {
                epUserId.Icon = Properties.Resources.errorIcon;
                epUserId.RightToLeft = true;
                epUserId.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                epUserId.SetError(txtUserId, "User ID must be numeric");
                e.Cancel = true;
            }
            else
            {

                epUserId.Icon = Properties.Resources.check_icon;
                epUserId.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                epUserId.RightToLeft = false;
                epUserId.SetError(txtUserId, "Valid");
                e.Cancel = false;
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            epPassword.Clear();
            epPassword.SetError(txtPassword, null);
            if (txtPassword.Text == string.Empty )
            {
                epPassword.Icon = Properties.Resources.errorIcon;
                epPassword.RightToLeft = true;
                epPassword.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                epPassword.SetError(txtPassword, "Password is required");
                e.Cancel = true;
                
            }
            else if(txtPassword.Text.Length < 8 || txtPassword.Text.Length > 15)
            {
                epPassword.Icon = Properties.Resources.errorIcon;
                epPassword.RightToLeft = true;
                epPassword.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                epPassword.SetError(txtPassword, "Password must contain from 8 to 15 characters long");
                e.Cancel = true;
            }
            else
            {

                epPassword.Icon = Properties.Resources.check_icon;
                epPassword.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                epPassword.RightToLeft = false;
                epPassword.SetError(txtPassword, "Valid");
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }



    }
}
