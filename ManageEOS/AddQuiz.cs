using Microsoft.EntityFrameworkCore;
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

namespace ManageEOS
{
    public partial class AddQuiz : Form
    {
        public EosFinalProjectContext context = new EosFinalProjectContext();

        public AddQuiz()
        {
            InitializeComponent();

        }
        public AddQuiz(String id, String Code)
        {
            InitializeComponent();
            txtTypeCode.Text = Code;
            txtTypeID.Text = id;
        }
        public Quiz GetQuiz()
        {
            Quiz quiz = new Quiz();
            String anwser = "";
            if (AnsA.Checked) { anwser += "A"; }
            if (AnsB.Checked) { anwser += "B"; }
            if (AnsC.Checked) { anwser += "C"; }
            if (AnsD.Checked) { anwser += "D"; }
            quiz.Question = txtQues.Text;
            quiz.TypeId = int.Parse(txtTypeID.Text);
            quiz.Anwser = anwser;
            return quiz;
        }
        public void loadData()
        {
            dgvQuiz.DataSource = (from q in context.Quizzes
                                  select new
                                  {
                                      q.Id,
                                      q.Question,
                                      q.Anwser,
                                      q.TypeId
                                  }
                ).Where(x => x.TypeId == int.Parse(txtTypeID.Text)).ToList();
        }

        // form
        private void AddQuiz_Load(object sender, EventArgs e)
        {

            loadData();
            context.SaveChanges();

        }
        public void refresh()
        {
            txtId.Text = null;
            txtQues.Text = null;
            AnsA.Checked = false;
            AnsB.Checked = false;
            AnsC.Checked = false;
            AnsD.Checked = false;
        }

        private void tbAdd_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.TypeId = int.Parse(txtTypeID.Text);
            quiz.Question = txtQues.Text;
            //txtId.Text = context.Quizzes.FirstOrDefault(x => x.Id == quiz.Id).Id.ToString();
            String a = "";
            String b = "";
            String c = "";
            String d = "";
            if (AnsA.Checked == true)
            {
                a = "A";
            }
            if (AnsB.Checked == true)
            {
                b = "B";
            }

            if (AnsC.Checked == true)
            {
                c = "C";
            }
            if (AnsD.Checked == true)
            {
                d = "D";
            }
            quiz.Anwser = a + b + c + d;
            context.Quizzes.Add(quiz);
            context.SaveChanges();
            loadData();
            refresh();
        }

        private void dgvQuiz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Visible = true;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            txtId.Text = dgvQuiz.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtQues.Text = dgvQuiz.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            String AnswerCheck = dgvQuiz.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            AnsA.Checked = false;
            AnsB.Checked = false;
            AnsC.Checked = false;
            AnsD.Checked = false;
            for (int i = 0; i < AnswerCheck.Length; i++)
            {
                Char c = AnswerCheck[i];

                if (c == 'A')
                {
                    groupBox1.Visible = true;
                    AnsA.Checked = true;
                }
                if (c == 'B')
                {
                    groupBox1.Visible = true;
                    AnsB.Checked = true;
                }
                if (c == 'C')
                {
                    groupBox1.Visible = true;
                    AnsC.Checked = true;
                }

                if (c == 'D')
                {
                    groupBox1.Visible = true;
                    AnsD.Checked = true;
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Quiz newQuiz = GetQuiz();
                newQuiz.Id = int.Parse(txtId.Text);
                if (string.IsNullOrEmpty(newQuiz.Question) == false && !newQuiz.Anwser.Equals(""))
                {
                    Quiz oldQuiz = context.Quizzes.FirstOrDefault(x => x.Id == newQuiz.Id);
                    oldQuiz.Question = newQuiz.Question;
                    oldQuiz.Anwser = newQuiz.Anwser;
                    context.SaveChanges();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Question or anwwer not null!!!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            context.Database.ExecuteSqlRaw($"DELETE FROM [dbo].[Quiz] WHERE id = {id}");
            context.SaveChanges();
            loadData();

        }
        private void dgvQuiz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
