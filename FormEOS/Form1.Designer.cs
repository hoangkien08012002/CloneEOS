namespace FormEOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label5 = new Label();
            btnFinish = new Button();
            cbFinish = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            splitter2 = new Splitter();
            splitter1 = new Splitter();
            groupBox1 = new GroupBox();
            cbD = new CheckBox();
            cbC = new CheckBox();
            cbB = new CheckBox();
            label4 = new Label();
            btnPre = new Button();
            btnNext = new Button();
            cbA = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            lbCountDown = new Label();
            txtExamCode = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(200, 107);
            label5.Name = "label5";
            label5.Size = new Size(414, 20);
            label5.TabIndex = 31;
            label5.Text = "There are 40 questions, and your progress of answering is";
            // 
            // btnFinish
            // 
            btnFinish.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFinish.AutoSize = true;
            btnFinish.BackColor = Color.Khaki;
            btnFinish.Location = new Point(35, 506);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(75, 30);
            btnFinish.TabIndex = 30;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = false;
            btnFinish.Click += btnFinish_Click_1;
            // 
            // cbFinish
            // 
            cbFinish.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbFinish.AutoSize = true;
            cbFinish.ForeColor = Color.FromArgb(0, 0, 192);
            cbFinish.Location = new Point(35, 476);
            cbFinish.Name = "cbFinish";
            cbFinish.Size = new Size(196, 24);
            cbFinish.TabIndex = 29;
            cbFinish.Text = "I want to finish the exam.";
            cbFinish.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            numericUpDown1.Location = new Point(440, 53);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(35, 27);
            numericUpDown1.TabIndex = 28;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(378, 57);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 27;
            label3.Text = "Font size:";
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.ForeColor = Color.Lime;
            progressBar1.Location = new Point(530, 99);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(490, 23);
            progressBar1.TabIndex = 26;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(3, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 541);
            splitter2.TabIndex = 25;
            splitter2.TabStop = false;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 541);
            splitter1.TabIndex = 24;
            splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbD);
            groupBox1.Controls.Add(cbC);
            groupBox1.Controls.Add(cbB);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnPre);
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(cbA);
            groupBox1.Location = new Point(58, 177);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(91, 233);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cbD
            // 
            cbD.AutoSize = true;
            cbD.Location = new Point(6, 135);
            cbD.Name = "cbD";
            cbD.Size = new Size(42, 24);
            cbD.TabIndex = 32;
            cbD.Text = "D";
            cbD.UseVisualStyleBackColor = true;
            // 
            // cbC
            // 
            cbC.AutoSize = true;
            cbC.Location = new Point(6, 105);
            cbC.Name = "cbC";
            cbC.Size = new Size(40, 24);
            cbC.TabIndex = 32;
            cbC.Text = "C";
            cbC.UseVisualStyleBackColor = true;
            // 
            // cbB
            // 
            cbB.AutoSize = true;
            cbB.Location = new Point(6, 75);
            cbB.Name = "cbB";
            cbB.Size = new Size(40, 24);
            cbB.TabIndex = 4;
            cbB.Text = "B";
            cbB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 3;
            label4.Text = "Answer";
            // 
            // btnPre
            // 
            btnPre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPre.Location = new Point(0, 199);
            btnPre.Name = "btnPre";
            btnPre.Size = new Size(40, 28);
            btnPre.TabIndex = 2;
            btnPre.Text = "back";
            btnPre.UseVisualStyleBackColor = true;
            btnPre.Click += btnPre_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNext.Location = new Point(46, 199);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(42, 28);
            btnNext.TabIndex = 1;
            btnNext.Text = "next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // cbA
            // 
            cbA.AutoSize = true;
            cbA.Location = new Point(6, 45);
            cbA.Name = "cbA";
            cbA.Size = new Size(41, 24);
            cbA.TabIndex = 0;
            cbA.Text = "A";
            cbA.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lbCountDown
            // 
            lbCountDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbCountDown.AutoSize = true;
            lbCountDown.BackColor = SystemColors.Control;
            lbCountDown.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbCountDown.ForeColor = Color.Red;
            lbCountDown.ImageAlign = ContentAlignment.TopCenter;
            lbCountDown.Location = new Point(495, 12);
            lbCountDown.Name = "lbCountDown";
            lbCountDown.Size = new Size(137, 60);
            lbCountDown.TabIndex = 21;
            lbCountDown.Text = "00:00";
            // 
            // txtExamCode
            // 
            txtExamCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtExamCode.Enabled = false;
            txtExamCode.Location = new Point(263, 49);
            txtExamCode.Name = "txtExamCode";
            txtExamCode.ReadOnly = true;
            txtExamCode.Size = new Size(109, 27);
            txtExamCode.TabIndex = 20;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(263, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(112, 27);
            txtUsername.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(149, 47);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 18;
            label2.Text = "ExamCode:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(149, 12);
            label1.Name = "label1";
            label1.Size = new Size(130, 32);
            label1.TabIndex = 17;
            label1.Text = "Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(200, 142);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(820, 328);
            richTextBox1.TabIndex = 32;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1059, 541);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(btnFinish);
            Controls.Add(cbFinish);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(splitter2);
            Controls.Add(splitter1);
            Controls.Add(groupBox1);
            Controls.Add(lbCountDown);
            Controls.Add(txtExamCode);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Form1";
            Text = "EOS";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button btnFinish;
        private CheckBox cbFinish;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private ProgressBar progressBar1;
        private Splitter splitter2;
        private Splitter splitter1;
        private GroupBox groupBox1;
        private Label label4;
        private Button btnPre;
        private Button btnNext;
        private CheckBox cbA;
        private ErrorProvider errorProvider1;
        private Label lbCountDown;
        private TextBox txtExamCode;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private CheckBox cbD;
        private CheckBox cbC;
        private CheckBox cbB;
        private RichTextBox richTextBox1;
    }
}