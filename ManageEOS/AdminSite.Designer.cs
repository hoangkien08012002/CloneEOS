namespace ManageEOS
{
    partial class AdminSite
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
            dgvListStudent = new DataGridView();
            txtSearch = new TextBox();
            Search = new Label();
            btnSearch = new Button();
            btnLoad = new Button();
            label1 = new Label();
            btnAddType = new Button();
            btnMarkReport = new Button();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtpass = new TextBox();
            btnCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListStudent).BeginInit();
            SuspendLayout();
            // 
            // dgvListStudent
            // 
            dgvListStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListStudent.Location = new Point(113, 205);
            dgvListStudent.Name = "dgvListStudent";
            dgvListStudent.RowHeadersWidth = 51;
            dgvListStudent.RowTemplate.Height = 29;
            dgvListStudent.Size = new Size(435, 319);
            dgvListStudent.TabIndex = 2;
            dgvListStudent.CellDoubleClick += dgvListStudent_CellDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(113, 170);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(247, 27);
            txtSearch.TabIndex = 3;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Location = new Point(166, 238);
            Search.Name = "Search";
            Search.Size = new Size(0, 20);
            Search.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(401, 168);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(147, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search Student";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(113, 547);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Refresh";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(474, 24);
            label1.Name = "label1";
            label1.Size = new Size(151, 50);
            label1.TabIndex = 7;
            label1.Text = "ADMIN";
            // 
            // btnAddType
            // 
            btnAddType.Location = new Point(266, 547);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(94, 29);
            btnAddType.TabIndex = 8;
            btnAddType.Text = "Add Type";
            btnAddType.UseVisualStyleBackColor = true;
            btnAddType.Click += btnAddType_Click;
            // 
            // btnMarkReport
            // 
            btnMarkReport.Location = new Point(410, 547);
            btnMarkReport.Name = "btnMarkReport";
            btnMarkReport.Size = new Size(105, 29);
            btnMarkReport.TabIndex = 9;
            btnMarkReport.Text = "Mark report";
            btnMarkReport.UseVisualStyleBackColor = true;
            btnMarkReport.Click += btnMarkReport_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(617, 247);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 10;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(617, 310);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(753, 240);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(183, 27);
            txtUsername.TabIndex = 12;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(753, 303);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(183, 27);
            txtpass.TabIndex = 13;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(729, 410);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // AdminSite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(998, 602);
            Controls.Add(btnCreate);
            Controls.Add(txtpass);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnMarkReport);
            Controls.Add(btnAddType);
            Controls.Add(label1);
            Controls.Add(btnLoad);
            Controls.Add(btnSearch);
            Controls.Add(Search);
            Controls.Add(txtSearch);
            Controls.Add(dgvListStudent);
            Name = "AdminSite";
            Text = "AdminSite";
            Load += AdminSite_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvListStudent;
        private TextBox txtSearch;
        private Label Search;
        private Button btnSearch;
        private Button btnLoad;
        private Label label1;
        private Button btnAddType;
        private Button btnMarkReport;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtpass;
        private Button btnCreate;
    }
}