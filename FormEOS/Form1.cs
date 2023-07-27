using System.Runtime.InteropServices;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using DataAccess.Models;
using DataAccess;
using System.Diagnostics.Eventing.Reader;
using System.Xml;
using System.IO;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.Logging;

namespace FormEOS
{
    public partial class Form1 : Form
    {
        // Khai báo các thuộc tính để lưu trữ giá trị username và codeexam
        private string loggedInUsername;
        private string loggedInCodeExam;
        public EosFinalProjectContext Context = new EosFinalProjectContext();
        public int indexQuestion = 0;
        public List<Quiz> listQ;
        // quiz now
        Quiz q = new Quiz();
        // ghi lại tiến trình làm bài
        List<DataLog> logs = new List<DataLog>();
        // Data log current
        DataLog dataLog;

        private int countdown; // Giá trị ban đầu của countdown
        private System.Windows.Forms.Timer timer;
        private IKeyboardMouseEvents hookEvents;
        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_CLOSE = 0xF060;


        public Form1()
        {
            InitializeComponent();
            // Bật chế độ toàn màn hình khi khởi tạo form
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            hookEvents = Hook.GlobalEvents();
            hookEvents.KeyDown += HookEvents_KeyDown;
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND && m.WParam.ToInt32() == SC_CLOSE)
            {
                // Ngăn chặn hành động đóng cửa sổ khi sử dụng phím tắt Windows
                return;
            }

            base.WndProc(ref m);
        }

        private void HookEvents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                // Ngăn chặn phím tắt Ctrl + Alt + Delete
            }
            else if (e.Alt && e.KeyCode == Keys.Tab)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                // Ngăn chặn phím tắt Alt + Tab
            }
            else if (e.KeyCode == Keys.LWin || e.KeyCode == Keys.RWin)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                // Ngăn chặn phím tắt Windows
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if ((Control.ModifierKeys & Keys.Alt) != 0 && e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true; // Hủy sự kiện đóng form nếu Alt + F4 được nhấn
                }
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo và cấu hình Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Cập nhật countdown mỗi giây
            timer.Tick += Timer_Tick;
            txtUsername.Text = loggedInUsername;
            txtExamCode.Text = loggedInCodeExam;
            // Khởi động Timer
            timer.Start();
            loadFormUI();


        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Giảm giá trị của countdown
            countdown--;

            // Kiểm tra nếu countdown đạt 0
            if (countdown <= 0)
            {
                // Dừng Timer
                timer.Stop();

                // Thực hiện các hành động khi countdown đạt 0
                lbCountDown.Text = $"00:00";
                Close();
                lastForm lf = new lastForm();
                lf.Show();
            }

            // Tính toán phút và giây từ giá trị countdown
            int minutes = countdown / 60;
            int seconds = countdown % 60;

            // Hiển thị giá trị countdown trên Label
            lbCountDown.Text = $"{minutes:00}:{seconds:00}";
        }

        private void btnFinish_Click_1(object sender, EventArgs e)
        {
            SaveLogsToFile();
            lastForm lf = new lastForm();
            lf.Show();
            if (cbFinish.Checked)
            {
                Close();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Lấy giá trị mới từ numericUpDown1
            int fontSize = (int)numericUpDown1.Value;

            // Đặt kích cỡ chữ cho richTextBox1
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, fontSize);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            indexQuestion++;
            if (indexQuestion > listQ.Count - 1)
            {
                indexQuestion = 0;
            }
            String anwser = "";
            if (cbA.Checked) { anwser += "A"; }
            if (cbB.Checked) { anwser += "B"; }
            if (cbC.Checked) { anwser += "C"; }
            if (cbD.Checked) { anwser += "D"; }
            if (logs.FirstOrDefault(x => x.Question == indexQuestion) == null)
            {
                DataLog log = new DataLog();
                log.Question = indexQuestion;
                log.Answers = anwser;
                log.Results = AreStringsEqualByCharacterSubset(q.Anwser, anwser);

                if (anwser == "")
                {
                    log.Results = false;
                }
                logs.Add(log);
            }
            else
            {
                dataLog.Answers = anwser;
                dataLog.Results = AreStringsEqualByCharacterSubset(q.Anwser, anwser);
                if (anwser == "")
                {
                    dataLog.Results = false;
                }
            }
            resetCheckBox();
            loadFormUI();
            if (dataLog != null)
            {
                if (dataLog.Answers.Contains("A")) { cbA.Checked = true; }
                if (dataLog.Answers.Contains("B")) { cbB.Checked = true; }
                if (dataLog.Answers.Contains("C")) { cbC.Checked = true; }
                if (dataLog.Answers.Contains("D")) { cbD.Checked = true; }
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            indexQuestion--;
            if (indexQuestion < 0)
            {
                indexQuestion = listQ.Count - 1;
            }
            String anwser = "";
            if (cbA.Checked) { anwser += "A"; }
            if (cbB.Checked) { anwser += "B"; }
            if (cbC.Checked) { anwser += "C"; }
            if (cbD.Checked) { anwser += "D"; }
            if (logs.FirstOrDefault(x => x.Question == indexQuestion) == null)
            {
                DataLog log = new DataLog();
                log.Question = indexQuestion;
                log.Answers = anwser;
                log.Results = AreStringsEqualByCharacterSubset(q.Anwser, anwser);
                if (anwser == "")
                {
                    log.Results = false;
                }
                logs.Add(log);
            }
            else
            {
                dataLog.Answers = anwser;
                dataLog.Results = AreStringsEqualByCharacterSubset(q.Anwser, anwser);
                if (anwser == "")
                {
                    dataLog.Results = false;
                }
            }
            resetCheckBox();
            loadFormUI();
            if (dataLog != null)
            {
                if (dataLog.Answers.Contains("A")) { cbA.Checked = true; }
                if (dataLog.Answers.Contains("B")) { cbB.Checked = true; }
                if (dataLog.Answers.Contains("C")) { cbC.Checked = true; }
                if (dataLog.Answers.Contains("D")) { cbD.Checked = true; }
            }
        }
        public void loadFormUI()
        {
            // set font 
            int fontSize = (int)richTextBox1.Font.Size;
            // Set the numericUpDown1's Value to the font size
            numericUpDown1.Value = fontSize;
            DataAccess.Models.Type type = Context.Types.FirstOrDefault(x => x.Code == loggedInCodeExam);
            // Gán văn bản mới cho RichTextBox
            listQ = Context.Quizzes.Where(x => x.TypeId == type.Id).ToList();
            q = listQ[indexQuestion];
            richTextBox1.Text = q.Question;
            int progress = 0;
            foreach (DataLog log in logs)
            {
                if (!log.Answers.IsNullOrEmpty())
                {
                    progress++;
                }
            }
            progressBar1.Minimum = 1;
            progressBar1.Maximum = listQ.Count + 1;
            progressBar1.Value = progress + 1;
            getCurrenDataLog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        public void resetCheckBox()
        {
            cbA.Checked = false;
            cbB.Checked = false;
            cbC.Checked = false;
            cbD.Checked = false;
        }
        public void getCurrenDataLog()
        {
            if (logs.Count != 0)
            {
                if (indexQuestion < logs.Count)
                {
                    dataLog = logs[indexQuestion];
                }
            }
        }
        private void SaveLogsToFile()
        {
            string username = loggedInUsername;
            int count = 0;
            foreach (DataLog i in logs)
            {
                if (i.Results)
                {
                    count++;
                }
            }

            double rls = (double)count / listQ.Count * 10;
            rls = Math.Round(rls, 2);
            // Build the file path relative to the application's executable location
            string logsFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataLog");
            string logsFilePath = Path.Combine(logsFolderPath, loggedInUsername + "_" + loggedInCodeExam + ".json");

            // Create the "DataLog" folder if it doesn't exist
            if (!Directory.Exists(logsFolderPath))
            {
                Directory.CreateDirectory(logsFolderPath);
            }

            // Create a dictionary to hold the log data
            var logData = new Dictionary<string, object>
             {
            { "Username", username },
                { "Rls", rls }
            };
            string logsJson = JsonConvert.SerializeObject(logs, Formatting.Indented);
            // Serialize the logData dictionary to JSON
            logsJson += "\n" + JsonConvert.SerializeObject(logData, Formatting.Indented);

            // Save the JSON string to the log file
            File.WriteAllText(logsFilePath, logsJson);
            saveResult(username, loggedInCodeExam, rls);
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void SetLoginInfo(string username, string codeexam, int input_countdown)
        {
            loggedInUsername = username;
            loggedInCodeExam = codeexam;
            countdown = input_countdown;
        }
        public void saveResult(string username, string codeexam, double rls)
        {
            int userID = Context.Users.FirstOrDefault(x => x.Username == username).Id;
            int typeID = Context.Types.FirstOrDefault(x => x.Code == codeexam).Id;

            Result result = new Result();
            result.UserId = userID;
            result.Grade = rls;
            result.TypeId = typeID;
            Context.Results.Add(result);
            Context.SaveChanges();
        }
        public bool AreStringsEqualByCharacterSubset(string str1, string str2)
        {
            str1 = str1.Trim();
            str2 = str2.Trim();
            if (str1 == null || str2 == null || str1.Length != str2.Length)
                return false;

            char[] charArray1 = str1.ToCharArray();
            char[] charArray2 = str2.ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);

            for (int i = 0; i < charArray1.Length; i++)
            {
                if (charArray1[i] != charArray2[i])
                {
                    return false;
                }
            }

            return true;
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}