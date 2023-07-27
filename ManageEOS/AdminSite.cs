using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Models;
using System.Drawing;
using System.Linq;

namespace ManageEOS
{
    public partial class AdminSite : Form
    {
        public EosFinalProjectContext context = new EosFinalProjectContext();
        public AdminSite()
        {

            InitializeComponent();
            this.AcceptButton = btnSearch;
        }

        public void loadData()
        {
            dgvListStudent.DataSource = (from u in context.Users
                                         select new
                                         {
                                             u.Id,
                                             u.Username
                                         }
                ).ToList();
        }
        private void AdminSite_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String searchStudent = txtSearch.Text;
            if (string.IsNullOrEmpty(searchStudent) == false)
            {

                dgvListStudent.DataSource = (from u in context.Users
                                             select new
                                             {
                                                 u.Id,
                                                 u.Username
                                             }
                                 ).Where(x => x.Username.ToLower().Contains(searchStudent.ToLower())).ToList();
                context.SaveChanges();
            }
            else
            {
                loadData();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
            loadData();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            AddType addType = new AddType();
            addType.Show();
        }

        private void dgvListStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = dgvListStudent.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            String userName = dgvListStudent.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();

            // khi click vào data grid View, kết quả học sinh sẽ đưuọc hiển thị
            Student std = new Student(id, userName);
            std.ShowDialog();
        }

        private void btnMarkReport_Click(object sender, EventArgs e)
        {
            MarkReport mark = new MarkReport();
            mark.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            User user = new User();

            if (context.Users.FirstOrDefault(x => x.Username == txtUsername.Text) != null)
            {
                MessageBox.Show("Username is exits!");
            }
            else
            {
                user.Username = txtUsername.Text;
                user.Password = txtpass.Text;
                user.RoldId = 2;
                context.Add(user);
                context.SaveChanges();
                MessageBox.Show("Create student successfully!");


            }
            txtUsername.Text = null;
            txtpass.Text = null;

        }
    }
}
