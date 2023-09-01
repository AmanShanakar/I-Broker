using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace LoginClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Name = NameTextBox.Text;
            string Password = PasswordTextBox.Text;

            if (!IsValidName(Name))
            {
                MessageBox.Show("Name should be maximum length of 50 characters.");
                return;
            }

            if (!IsValidPassword(Password))
            {
                MessageBox.Show("Invalid password format.\nPassword should be case-sensitive.\nPlease check the password."); // and have a maximum length of 30 characters
                return;
            }

            UserLoginService.UserLoginServiceClient client = new UserLoginService.UserLoginServiceClient();
            int loginResult = client.GetUser(Name, Password);

            switch (loginResult)
            {
                case 0:
                    MessageBox.Show("User Name does not exist.");
                    break;
                case 1:
                    MessageBox.Show("Password does not match.");
                    break;
                case 2:
                    MessageBox.Show("User is InActive");
                    break;
                case 3:
                    MessageBox.Show("Login successful.");
                    Form3 f3 = new Form3();
                    f3.Show();
                    // Perform actions for successful login
                    break;
                default:
                    MessageBox.Show("An error occurred during login.");
                    break;
            }
        }

        private bool IsValidName(string name)
        {
            return name.Length <= 50;
        }
        private bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", RegexOptions.None);
        }
/*
        private bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
        }*/

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            if(NameTextBox.Text == "Enter User Id")
            {
                NameTextBox.Text = "";
                NameTextBox.ForeColor = Color.Black;
            }
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if(NameTextBox.Text == "")
            {
                NameTextBox.Text = "Enter User Id";
                NameTextBox.ForeColor = Color.Silver;
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Enter Password")
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = Color.Black;
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.Text = "Enter Password";
                PasswordTextBox.ForeColor = Color.Silver;
            }
        }
    }
}
