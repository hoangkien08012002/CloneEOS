namespace ManageEOS
{
    partial class AddType
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
            btnSaveType = new Button();
            label2 = new Label();
            label1 = new Label();
            txtTypeCode = new TextBox();
            txtTypeName = new TextBox();
            dgvType = new DataGridView();
            txtId = new TextBox();
            Id = new Label();
            btnUpdate = new Button();
            label3 = new Label();
            btnDelete = new Button();
            btnRefresh = new Button();
            label4 = new Label();
            nudTime = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTime).BeginInit();
            SuspendLayout();
            // 
            // btnSaveType
            // 
            btnSaveType.Location = new Point(59, 275);
            btnSaveType.Name = "btnSaveType";
            btnSaveType.Size = new Size(94, 29);
            btnSaveType.TabIndex = 19;
            btnSaveType.Text = "Add";
            btnSaveType.UseVisualStyleBackColor = true;
            btnSaveType.Click += btnSaveType_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 178);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 18;
            label2.Text = "Type Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 134);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 17;
            label1.Text = "Type Name";
            // 
            // txtTypeCode
            // 
            txtTypeCode.Location = new Point(130, 175);
            txtTypeCode.Name = "txtTypeCode";
            txtTypeCode.Size = new Size(410, 27);
            txtTypeCode.TabIndex = 16;
            // 
            // txtTypeName
            // 
            txtTypeName.Location = new Point(130, 131);
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Size = new Size(410, 27);
            txtTypeName.TabIndex = 15;
            // 
            // dgvType
            // 
            dgvType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvType.Location = new Point(24, 319);
            dgvType.Name = "dgvType";
            dgvType.RowHeadersWidth = 51;
            dgvType.RowTemplate.Height = 29;
            dgvType.Size = new Size(563, 343);
            dgvType.TabIndex = 20;
            dgvType.CellClick += dgvType_CellClick;
            dgvType.CellDoubleClick += dgvType_CellDoubleClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(130, 91);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(410, 27);
            txtId.TabIndex = 21;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(59, 94);
            Id.Name = "Id";
            Id.Size = new Size(22, 20);
            Id.TabIndex = 22;
            Id.Text = "Id";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(179, 275);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(201, 24);
            label3.Name = "label3";
            label3.Size = new Size(213, 42);
            label3.TabIndex = 24;
            label3.Text = "ADD TYPE";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(303, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(432, 275);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 26;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 229);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 27;
            label4.Text = "Time";
            // 
            // nudTime
            // 
            nudTime.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            nudTime.Location = new Point(130, 227);
            nudTime.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudTime.Name = "nudTime";
            nudTime.Size = new Size(143, 27);
            nudTime.TabIndex = 28;
            // 
            // AddType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 674);
            Controls.Add(nudTime);
            Controls.Add(label4);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(label3);
            Controls.Add(btnUpdate);
            Controls.Add(Id);
            Controls.Add(txtId);
            Controls.Add(dgvType);
            Controls.Add(btnSaveType);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTypeCode);
            Controls.Add(txtTypeName);
            Name = "AddType";
            Text = "Form1";
            Load += AddType_Load;
            ((System.ComponentModel.ISupportInitialize)dgvType).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveType;
        private Label label2;
        private Label label1;
        private TextBox txtTypeCode;
        private TextBox txtTypeName;
        private DataGridView dgvType;
        private TextBox txtId;
        private Label Id;
        private Button btnUpdate;
        private Label label3;
        private Button btnDelete;
        private Button btnRefresh;
        private Label label4;
        private NumericUpDown nudTime;
    }
}