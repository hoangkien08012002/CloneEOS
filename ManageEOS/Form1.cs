using DataAccess.Models;
using OfficeOpenXml.Packaging.Ionic.Zip;

namespace ManageEOS
{
    public partial class Form1 : Form
    {
        public EosFinalProjectContext context = new EosFinalProjectContext();
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            User user = new User();
            user = context.Users.SingleOrDefault(x => x.Username == txtUsername.Text && x.Password == txtPassword.Text);
            if (user != null)
            {
                if (user.RoldId == 1)
                {
                    AdminSite site = new AdminSite();
                    site.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Must be admin!");
                }
            }
            else
            {
                MessageBox.Show("UserName or Password invalid!!");
            }
        }
    }
}