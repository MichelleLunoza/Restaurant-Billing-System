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

namespace Chowhound_Food_Avenue
{
    public partial class SignupForm : Form
    {
        public SignupForm()
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


        private void Create_Click(object sender, EventArgs e)
        {
            try
            {
                ChowhoundInfo info = new ChowhoundInfo()
                {
                    FirstName = FIRSTNAMETEXT.Text,
                    LastName = LASTNAMETEXT.Text,
                    Username = USERNAMETEXT.Text,
                    Password = CalculateMD5Hash(PASSWORDTEXT.Text),
                    SecurityCode =  CalculateMD5Hash(SECURITYCODETEXT.Text)
                };


                IChowhound app = new Chowhound();
                app.RegisterUser(info);
                MessageBox.Show("Successfully Saved");

                LoginForm login = new LoginForm();
                {
                    this.Hide();
                    login.Show();
                }
            }
            catch
            {
                MessageBox.Show("This username is already have. Try another one");
            }
        }
    }
}
