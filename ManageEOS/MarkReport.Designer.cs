namespace ManageEOS
{
    partial class MarkReport
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
            cbTypeName = new ComboBox();
            dgvMark = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnImport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMark).BeginInit();
            SuspendLayout();
            // 
            // cbTypeName
            // 
            cbTypeName.FormattingEnabled = true;
            cbTypeName.Location = new Point(310, 119);
            cbTypeName.Name = "cbTypeName";
            cbTypeName.Size = new Size(174, 28);
            cbTypeName.TabIndex = 0;
            cbTypeName.SelectedIndexChanged += cbTypeName_SelectedIndexChanged;
            // 
            // dgvMark
            // 
            dgvMark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMark.Location = new Point(155, 164);
            dgvMark.Name = "dgvMark";
            dgvMark.RowHeadersWidth = 51;
            dgvMark.RowTemplate.Height = 29;
            dgvMark.Size = new Size(329, 351);
            dgvMark.TabIndex = 1;
            dgvMark.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(155, 119);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 2;
            label1.Text = "Subject Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(182, 41);
            label2.Name = "label2";
            label2.Size = new Size(268, 39);
            label2.TabIndex = 3;
            label2.Text = "MARK REPORT";
            // 
            // btnImport
            // 
            btnImport.Location = new Point(252, 550);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(94, 29);
            btnImport.TabIndex = 4;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // MarkReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 600);
            Controls.Add(btnImport);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMark);
            Controls.Add(cbTypeName);
            Name = "MarkReport";
            Text = "MarkReport";
            Load += MarkReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTypeName;
        private DataGridView dgvMark;
        private Label label1;
        private Label label2;
        private Button btnImport;
    }
}