namespace StudentRecords
{
    partial class AddStudentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBoxFirst = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxMiddle = new System.Windows.Forms.TextBox();
            this.txtBoxLast = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvAcademicRecords = new System.Windows.Forms.DataGridView();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxFirst
            // 
            this.txtBoxFirst.Location = new System.Drawing.Point(100, 76);
            this.txtBoxFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxFirst.Name = "txtBoxFirst";
            this.txtBoxFirst.Size = new System.Drawing.Size(178, 22);
            this.txtBoxFirst.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(18, 81);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(76, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "First Name";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Middle Name";
            // 
            // txtBoxMiddle
            // 
            this.txtBoxMiddle.Location = new System.Drawing.Point(100, 112);
            this.txtBoxMiddle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxMiddle.Name = "txtBoxMiddle";
            this.txtBoxMiddle.Size = new System.Drawing.Size(178, 22);
            this.txtBoxMiddle.TabIndex = 1;
            // 
            // txtBoxLast
            // 
            this.txtBoxLast.Location = new System.Drawing.Point(100, 151);
            this.txtBoxLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxLast.Name = "txtBoxLast";
            this.txtBoxLast.Size = new System.Drawing.Size(178, 22);
            this.txtBoxLast.TabIndex = 2;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(100, 192);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(178, 22);
            this.txtBoxEmail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status In Canada";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(448, 74);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(178, 22);
            this.dtpDateOfBirth.TabIndex = 3;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Citizen",
            "Permanent Resident",
            "International Student",
            "Work permit"});
            this.cmbStatus.Location = new System.Drawing.Point(479, 109);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(147, 24);
            this.cmbStatus.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Phone Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address:";
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(100, 266);
            this.txtBoxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(178, 22);
            this.txtBoxPhone.TabIndex = 7;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(100, 234);
            this.txtBoxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(178, 22);
            this.txtBoxAddress.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(50, 384);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(201, 134);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvAcademicRecords
            // 
            this.dgvAcademicRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAcademicRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAcademicRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcademicRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.Mark,
            this.Credit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcademicRecords.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAcademicRecords.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAcademicRecords.Location = new System.Drawing.Point(357, 174);
            this.dgvAcademicRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAcademicRecords.Name = "dgvAcademicRecords";
            this.dgvAcademicRecords.RowHeadersWidth = 62;
            this.dgvAcademicRecords.RowTemplate.Height = 28;
            this.dgvAcademicRecords.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvAcademicRecords.Size = new System.Drawing.Size(427, 330);
            this.dgvAcademicRecords.TabIndex = 16;
            this.dgvAcademicRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcademicRecords_CellContentClick);
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 8;
            this.Course.Name = "Course";
            // 
            // Mark
            // 
            this.Mark.HeaderText = "Mark";
            this.Mark.MinimumWidth = 8;
            this.Mark.Name = "Mark";
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit";
            this.Credit.MinimumWidth = 8;
            this.Credit.Name = "Credit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(269, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Add student information below";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 550);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvAcademicRecords);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxLast);
            this.Controls.Add(this.txtBoxMiddle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtBoxFirst);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddStudentForm";
            this.Text = "Add Student Information";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxFirst;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxMiddle;
        private System.Windows.Forms.TextBox txtBoxLast;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvAcademicRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.Label label8;
    }
}