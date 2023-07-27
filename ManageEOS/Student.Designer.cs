namespace ManageEOS
{
    partial class Student
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
            label1 = new Label();
            txtNameStudent = new TextBox();
            dgvResult = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 94);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // txtNameStudent
            // 
            txtNameStudent.Location = new Point(212, 91);
            txtNameStudent.Name = "txtNameStudent";
            txtNameStudent.ReadOnly = true;
            txtNameStudent.Size = new Size(222, 27);
            txtNameStudent.TabIndex = 1;
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(82, 145);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.RowTemplate.Height = 29;
            dgvResult.Size = new Size(352, 258);
            dgvResult.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(143, 26);
            label2.Name = "label2";
            label2.Size = new Size(221, 35);
            label2.TabIndex = 3;
            label2.Text = "Grade Student";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 460);
            Controls.Add(label2);
            Controls.Add(dgvResult);
            Controls.Add(txtNameStudent);
            Controls.Add(label1);
            Name = "Student";
            Text = "Student";
            Load += Student_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNameStudent;
        private DataGridView dgvResult;
        private Label label2;
    }
}