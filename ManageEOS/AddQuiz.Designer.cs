namespace ManageEOS
{
    partial class AddQuiz
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
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtTypeID = new TextBox();
            label6 = new Label();
            txtTypeCode = new TextBox();
            tbAdd = new Button();
            txtId = new TextBox();
            label5 = new Label();
            AnsD = new CheckBox();
            AnsC = new CheckBox();
            label1 = new Label();
            AnsB = new CheckBox();
            label2 = new Label();
            AnsA = new CheckBox();
            label3 = new Label();
            txtQues = new RichTextBox();
            label4 = new Label();
            dgvQuiz = new DataGridView();
            label7 = new Label();
            btnRefresh = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuiz).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(txtTypeID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTypeCode);
            groupBox1.Controls.Add(tbAdd);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(AnsD);
            groupBox1.Controls.Add(AnsC);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(AnsB);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(AnsA);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtQues);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(122, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(757, 307);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(377, 276);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(231, 276);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtTypeID
            // 
            txtTypeID.Location = new Point(426, 29);
            txtTypeID.Name = "txtTypeID";
            txtTypeID.ReadOnly = true;
            txtTypeID.Size = new Size(184, 27);
            txtTypeID.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 29);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 27;
            label6.Text = "Type ID";
            // 
            // txtTypeCode
            // 
            txtTypeCode.Location = new Point(118, 22);
            txtTypeCode.Name = "txtTypeCode";
            txtTypeCode.ReadOnly = true;
            txtTypeCode.Size = new Size(151, 27);
            txtTypeCode.TabIndex = 25;
            // 
            // tbAdd
            // 
            tbAdd.Location = new Point(86, 276);
            tbAdd.Name = "tbAdd";
            tbAdd.Size = new Size(94, 29);
            tbAdd.TabIndex = 24;
            tbAdd.Text = "Add";
            tbAdd.UseVisualStyleBackColor = true;
            tbAdd.Click += tbAdd_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(118, 75);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(151, 27);
            txtId.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 75);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 22;
            // 
            // AnsD
            // 
            AnsD.AutoSize = true;
            AnsD.Location = new Point(532, 234);
            AnsD.Name = "AnsD";
            AnsD.Size = new Size(42, 24);
            AnsD.TabIndex = 21;
            AnsD.Text = "D";
            AnsD.UseVisualStyleBackColor = true;
            // 
            // AnsC
            // 
            AnsC.AutoSize = true;
            AnsC.Location = new Point(406, 234);
            AnsC.Name = "AnsC";
            AnsC.Size = new Size(40, 24);
            AnsC.TabIndex = 20;
            AnsC.Text = "C";
            AnsC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 12;
            label1.Text = "TypeCode";
            // 
            // AnsB
            // 
            AnsB.AutoSize = true;
            AnsB.Location = new Point(273, 234);
            AnsB.Name = "AnsB";
            AnsB.Size = new Size(40, 24);
            AnsB.TabIndex = 19;
            AnsB.Text = "B";
            AnsB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 71);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 14;
            label2.Text = "Quiz ID";
            // 
            // AnsA
            // 
            AnsA.AutoSize = true;
            AnsA.Location = new Point(127, 234);
            AnsA.Name = "AnsA";
            AnsA.Size = new Size(41, 24);
            AnsA.TabIndex = 18;
            AnsA.Text = "A";
            AnsA.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 135);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 15;
            label3.Text = "Question";
            // 
            // txtQues
            // 
            txtQues.Location = new Point(118, 135);
            txtQues.Name = "txtQues";
            txtQues.Size = new Size(492, 82);
            txtQues.TabIndex = 17;
            txtQues.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 234);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 16;
            label4.Text = "Answer";
            // 
            // dgvQuiz
            // 
            dgvQuiz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuiz.Location = new Point(122, 369);
            dgvQuiz.Name = "dgvQuiz";
            dgvQuiz.RowHeadersWidth = 51;
            dgvQuiz.RowTemplate.Height = 29;
            dgvQuiz.Size = new Size(757, 292);
            dgvQuiz.TabIndex = 16;
            dgvQuiz.CellClick += dgvQuiz_CellClick;
            dgvQuiz.CellContentClick += dgvQuiz_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(395, 9);
            label7.Name = "label7";
            label7.Size = new Size(181, 46);
            label7.TabIndex = 18;
            label7.Text = "ADD QUIZ";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(532, 276);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 31;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // AddQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 655);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(dgvQuiz);
            Name = "AddQuiz";
            Text = "AddQuiz";
            Load += AddQuiz_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuiz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button tbAdd;
        private TextBox txtId;
        private Label label5;
        private CheckBox AnsD;
        private CheckBox AnsC;
        private Label label1;
        private CheckBox AnsB;
        private Label label2;
        private CheckBox AnsA;
        private Label label3;
        private RichTextBox txtQues;
        private Label label4;
        private DataGridView dgvQuiz;
        private TextBox txtTypeCode;
        private TextBox txtTypeID;
        private Label label6;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label7;
        private Button btnRefresh;
    }
}