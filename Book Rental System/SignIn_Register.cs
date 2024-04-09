using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Book_Rental_System
{
    public partial class SignIn_Register : MaterialForm
    {
        public SignIn_Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
