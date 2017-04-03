using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chowhound_Food_Avenue.UI
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        public string CalculateMD5Hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        private void FINDACCOUNT_Click(object sender, EventArgs e)
        {

            ChowhoundInfo info = new ChowhoundInfo()
            {

                Username = USERNAMETEXT.Text,
                SecurityCode = CalculateMD5Hash(SECURITYCODETEXT.Text)
            };
            IChowhound app = new Chowhound();
            var found = app.ForgetPass_RetrieveUser(info);

            if (found)
            {
                label4.Visible = true;
                label6.Visible = true;
                PASSWORDTEXT.Visible = true;
                CONFIRMPASSTEXT.Visible = true;
                FINDACCOUNT.Enabled = false;
                CHANGEPASSWORD.Enabled = true;
            }
            else
            {
                MessageBox.Show("Acces is Denied");
            }
        }


        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void CHANGEPASSWORD_Click(object sender, EventArgs e)
        {
            if (PASSWORDTEXT.Text != CONFIRMPASSTEXT.Text)
            {
                MessageBox.Show("Password is not matched");
            }
            else
            {

                ChowhoundInfo info = new ChowhoundInfo()
                {

                    Password = CalculateMD5Hash(PASSWORDTEXT.Text),
                    Username = USERNAMETEXT.Text,
                    SecurityCode = CalculateMD5Hash(SECURITYCODETEXT.Text)
                };


                IChowhound app = new Chowhound();
                app.ChangePass(info);
                MessageBox.Show("Successfully Change Password");

                LoginForm login = new LoginForm();
                {
                    this.Hide();
                    login.Show();
                }

            }
        }
    }
}

