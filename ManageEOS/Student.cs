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
using System.Linq;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ManageEOS
{
    public partial class Student : Form
    {
        public EosFinalProjectContext context = new EosFinalProjectContext();
        public Student()
        {
            InitializeComponent();
        }
        public Student(String id, String userName)
        {
            InitializeComponent();
            txtNameStudent.Text = userName;
        }
        public void loadData()
        {
            var user = context.Users.FirstOrDefault(u => u.Username == txtNameStudent.Text);
            var query = from results in context.Results
                        join type in context.Types on results.TypeId equals type.Id
                        where results.UserId == user.Id
                        select new { type.Name, results.Grade };
            dgvResult.DataSource = query.ToList();
        }
        private void Student_Load(object sender, EventArgs e)
        {
            loadData();
        }


    }
}
