using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Chowhound_Food_Avenue.UI;
using System.Security.Cryptography;

namespace Chowhound_Food_Avenue
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public int counter = 0;

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

        private void button1_Click(object sender, EventArgs e)
        {
            SignupForm signup = new SignupForm();
            {
                this.Hide();
                signup.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Billing_System obj = new Billing_System();
            obj.user = UserText.Text;


            ChowhoundInfo info = new ChowhoundInfo()
            {

                Username = UserText.Text,
                Password = CalculateMD5Hash(PassText.Text)

            };


            IChowhound app = new Chowhound();
            app.GetUser(info);

            var found = app.GetUser(info);
            if (found)
            {
                UserText.Clear();
                PassText.Clear();
                obj.Show();
            }
            else
            {
                counter += 0;
                counter++;
                MessageBox.Show("Acces is Denied. Attempt to login " + counter);
            }

            if (counter == 3)
            {
                MessageBox.Show("3 times to attempt to login. This program will close");
                Application.Exit();
            }
        }
            
       

          private void UserText_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void PassText_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserText.Clear();
            PassText.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangePasswordForm forgetpass = new ChangePasswordForm();
            {
                this.Hide();
                forgetpass.Show();
            }
        }
    }
}





