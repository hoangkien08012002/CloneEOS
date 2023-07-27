using System.Runtime.InteropServices;
using System.Windows.Forms;
using DataAccess.Models;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ManageEOS
{
    public partial class AddType : Form
    {
        public EosFinalProjectContext context;

        public AddType()
        {
            context = new EosFinalProjectContext();
            InitializeComponent();
            this.AcceptButton = btnSaveType;
        }
        public void refresh()
        {
            txtTypeCode.Text = null;
            txtId.Text = null;
            txtTypeName.Text = null;
            nudTime.Value = 10;
        }
        public void loadData() // load lại dữ liệu 
        {
            dgvType.DataSource = (from t in context.Types
                                  select new
                                  {
                                      t.Id,
                                      t.Name,
                                      t.Code,
                                      t.Time
                                  }
               ).ToList();
            
        }

        public DataAccess.Models.Type getType()
        {
            DataAccess.Models.Type myType = new DataAccess.Models.Type();
            myType.Name = txtTypeName.Text;
            myType.Code = txtTypeCode.Text;
            myType.Time = (int)nudTime.Value;
            return myType;
        }
        private void AddType_Load(object sender, EventArgs e)
        {
            loadData();
            context.SaveChanges();

        }

        private void btnSaveType_Click(object sender, EventArgs e)
        {
            DataAccess.Models.Type myType = new DataAccess.Models.Type();

            myType.Name = txtTypeName.Text;
            myType.Code = txtTypeCode.Text;
            myType.Time =(int)nudTime.Value;

            if (context.Types.FirstOrDefault(x => x.Code == txtTypeCode.Text) != null)
            {
                MessageBox.Show("Code existed!!");
            }
            else
            {
                context.Types.Add(myType);
                context.SaveChanges();
                loadData();

            }

            refresh();
        }

        private void dgvType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            txtId.Text = dgvType.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtTypeName.Text = dgvType.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtTypeCode.Text = dgvType.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            nudTime.Value = int.Parse(dgvType.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataAccess.Models.Type newType = getType();
            newType.Id = int.Parse(txtId.Text);
            if (string.IsNullOrEmpty(newType.Name) == false && string.IsNullOrEmpty(newType.Code) == false)
            {
                DataAccess.Models.Type oldType = context.Types.FirstOrDefault(x => x.Id == newType.Id);
                oldType.Name = newType.Name;
                oldType.Code = newType.Code;
                oldType.Time = newType.Time;
                context.SaveChanges();
                loadData();
            }
            else
            {
                MessageBox.Show("Name or Code not null");
                loadData();
            }
            refresh();
        }

        private void dgvType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = dgvType.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            String code = dgvType.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            AddQuiz addQuiz = new AddQuiz(id, code);
            addQuiz.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtId.Text);

            context.Database.ExecuteSqlRaw($"update Results set TypeID = null where TypeID = {id}");
            context.Database.ExecuteSqlRaw($"update Quiz set Type_Id = null where Type_Id = {id}");
            context.Database.ExecuteSqlRaw($"delete from Type where Id = {id} ");
            context.SaveChanges();
            loadData();
            refresh();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}