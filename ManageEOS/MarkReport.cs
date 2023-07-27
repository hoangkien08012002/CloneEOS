using DataAccess.Models;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using OfficeOpenXml;
using System.IO;

namespace ManageEOS
{
    public partial class MarkReport : Form
    {
        public EosFinalProjectContext context = new EosFinalProjectContext();
        public MarkReport()
        {
            InitializeComponent();
        }

        private void MarkReport_Load(object sender, EventArgs e)
        {
            var types = context.Types.ToList();
            cbTypeName.DataSource = types;
            cbTypeName.DisplayMember = "Name"; 
            cbTypeName.ValueMember = "Id";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected Type object
            DataAccess.Models.Type selectedType = (DataAccess.Models.Type)cbTypeName.SelectedItem;

            // Get the ID (an int value) of the selected Type object
            int typeId = selectedType.Id;
            var results = (from result in context.Results
                           join type in context.Types on result.TypeId equals type.Id
                           join user in context.Users on result.UserId equals user.Id
                           where type.Id == typeId
                           select new
                           {
                               Username = user.Username,
                               Grade = result.Grade
                           }).ToList();
            dgvMark.DataSource = results;
        }

        public void ExportToExcel(string filePath)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("MarkReport");

               
                var types = context.Types.ToList(); // get data

                
                worksheet.Cells[1, 1].Value = "Username";
                int column = 2;
                foreach (var type in types)
                {
                    worksheet.Cells[1, column].Value = type.Name;
                    column++;
                }

                var results = context.Results.ToList(); // get dataa

                int row = 2;
                foreach (var user in context.Users)
                {
                    
                    worksheet.Cells[row, 1].Value = user.Username;

                    // Điền điểm
                    column = 2;
                    foreach (var type in types)
                    {
                        var result = results.FirstOrDefault(r => r.UserId == user.Id && r.TypeId == type.Id);
                        if (result != null)
                        {
                            worksheet.Cells[row, column].Value = result.Grade;
                        }
                        column++;
                    }

                    row++;
                }

                // Save workbook vào file
                FileInfo fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\Marks_Report.xlsx"; // Đường dẫn tệp Excel bạn muốn tạo
            ExportToExcel(filePath);
            MessageBox.Show("Import seccessfully!!");
        }
    }
}
