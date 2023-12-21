using Davis_FinalProject_Cs.Login_Form;
using Davis_FinalProject_Cs.PCHR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
namespace Davis_FinalProject_Cs
{
    public partial class LoginForm : Form
    {
        private readonly LoginController _controller;

        public LoginForm()
        {
            InitializeComponent();
            _controller = new LoginController();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutPCHR about = new frmAboutPCHR();
            about.ShowDialog();
        }

        private void showCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowCredentials showCredentials = new frmShowCredentials();
            showCredentials.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegistration registration = new frmRegistration();
            registration.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _controller.PerformLogin(txtUsername.Text, txtPassword.Text, this);
        }
    }
}
