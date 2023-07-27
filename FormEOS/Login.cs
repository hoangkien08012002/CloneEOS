using DataAccess.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEOS
{
    public partial class Login : Form
    {
        public EosFinalProjectContext context = new EosFinalProjectContext();

        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;
            string enteredCodeExam = txtExamCode.Text;
            User user = context.Users.SingleOrDefault(x => x.Username == enteredUsername && x.Password == enteredPassword);
            DataAccess.Models.Type t = new DataAccess.Models.Type();
            t = context.Types.SingleOrDefault(x => x.Code == enteredCodeExam);

            if (user != null)
            {
                Result rls = context.Results.FirstOrDefault(x => x.User == user && x.TypeId == t.Id);

                if (rls != null)
                {
                    MessageBox.Show("Code is expired!");
                }
                else if (t == null)
                {
                    MessageBox.Show("Code invalid!");
                }
                else if (user.RoldId != 2)
                {
                    MessageBox.Show("You must be student!");
                }
                else
                {
                    // Login successful, open Form1
                    Form1 form1 = new Form1();
                    form1.SetLoginInfo(enteredUsername, txtExamCode.Text, t.Time * 60);
                    form1.Show();
                    // Close the current login form if necessary
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {
    }

    private void txtUsername_TextChanged(object sender, EventArgs e)
    {
    }

    private void txtPassword_TextChanged(object sender, EventArgs e)
    {
    }

    private void txtExamCode_TextChanged(object sender, EventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }
}
}
