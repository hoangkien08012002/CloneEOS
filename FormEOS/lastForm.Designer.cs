namespace FormEOS
{
    partial class lastForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lastForm));
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            lbCountDown = new Label();
            txtExamCode = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            btnFinish = new Button();
            cbFinish = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            numericUpDown1.Enabled = false;
            numericUpDown1.Location = new Point(429, 50);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(35, 27);
            numericUpDown1.TabIndex = 36;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(367, 54);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 35;
            label3.Text = "Font size:";
            // 
            // lbCountDown
            // 
            lbCountDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbCountDown.AutoSize = true;
            lbCountDown.BackColor = SystemColors.Control;
            lbCountDown.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbCountDown.ForeColor = Color.Red;
            lbCountDown.ImageAlign = ContentAlignment.TopCenter;
            lbCountDown.Location = new Point(501, 9);
            lbCountDown.Name = "lbCountDown";
            lbCountDown.Size = new Size(137, 60);
            lbCountDown.TabIndex = 34;
            lbCountDown.Text = "00:00";
            // 
            // txtExamCode
            // 
            txtExamCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtExamCode.Enabled = false;
            txtExamCode.Location = new Point(252, 46);
            txtExamCode.Name = "txtExamCode";
            txtExamCode.ReadOnly = true;
            txtExamCode.Size = new Size(109, 27);
            txtExamCode.TabIndex = 33;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(252, 9);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(112, 27);
            txtUsername.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(138, 44);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 31;
            label2.Text = "ExamCode:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(138, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 32);
            label1.TabIndex = 30;
            label1.Text = "Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(138, 131);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(739, 296);
            richTextBox1.TabIndex = 40;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // btnFinish
            // 
            btnFinish.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFinish.AutoSize = true;
            btnFinish.BackColor = Color.Khaki;
            btnFinish.Enabled = false;
            btnFinish.Location = new Point(36, 463);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(75, 30);
            btnFinish.TabIndex = 39;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = false;
            // 
            // cbFinish
            // 
            cbFinish.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbFinish.AutoSize = true;
            cbFinish.Checked = true;
            cbFinish.CheckState = CheckState.Checked;
            cbFinish.Enabled = false;
            cbFinish.ForeColor = Color.FromArgb(0, 0, 192);
            cbFinish.Location = new Point(36, 433);
            cbFinish.Name = "cbFinish";
            cbFinish.Size = new Size(196, 24);
            cbFinish.TabIndex = 38;
            cbFinish.Text = "I want to finish the exam.";
            cbFinish.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(117, 542);
            label5.Name = "label5";
            label5.Size = new Size(225, 21);
            label5.TabIndex = 41;
            label5.Text = "Save at server successfull!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(117, 469);
            label4.Name = "label4";
            label4.Size = new Size(214, 19);
            label4.TabIndex = 42;
            label4.Text = "Save at server successffuly!";
            // 
            // lastForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 510);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            Controls.Add(btnFinish);
            Controls.Add(cbFinish);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(lbCountDown);
            Controls.Add(txtExamCode);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "lastForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label lbCountDown;
        private TextBox txtExamCode;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private Button btnFinish;
        private CheckBox cbFinish;
        private Label label5;
        private Label label4;
    }
}