namespace ClubRegistration
{
    partial class FrmClubRegistration
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtStudentId = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtAge = new TextBox();
            cbGender = new ComboBox();
            cbProgram = new ComboBox();
            btnRegister = new Button();
            btnUpdate = new Button();
            label8 = new Label();
            gridViewMembers = new DataGridView();
            btnRefresh = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)gridViewMembers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11.25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 11.25F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 11.25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 11.25F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(227, 77);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "First Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 11.25F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(444, 77);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 4;
            label5.Text = "Middle Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 11.25F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(444, 14);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Program:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 11.25F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(227, 139);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 6;
            label7.Text = "Gender:";
            // 
            // txtStudentId
            // 
            txtStudentId.BorderStyle = BorderStyle.FixedSingle;
            txtStudentId.Cursor = Cursors.Hand;
            txtStudentId.Font = new Font("Yu Gothic UI", 9F);
            txtStudentId.Location = new Point(12, 37);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(164, 23);
            txtStudentId.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Cursor = Cursors.Hand;
            txtLastName.Font = new Font("Yu Gothic UI", 9F);
            txtLastName.Location = new Point(12, 100);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(188, 23);
            txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Cursor = Cursors.Hand;
            txtFirstName.Font = new Font("Yu Gothic UI", 9F);
            txtFirstName.Location = new Point(227, 100);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(188, 23);
            txtFirstName.TabIndex = 9;
            // 
            // txtMiddleName
            // 
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.Cursor = Cursors.Hand;
            txtMiddleName.Font = new Font("Yu Gothic UI", 9F);
            txtMiddleName.Location = new Point(444, 100);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(188, 23);
            txtMiddleName.TabIndex = 10;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Cursor = Cursors.Hand;
            txtAge.Font = new Font("Yu Gothic UI", 9F);
            txtAge.Location = new Point(12, 162);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(110, 23);
            txtAge.TabIndex = 11;
            // 
            // cbGender
            // 
            cbGender.Cursor = Cursors.Hand;
            cbGender.Font = new Font("Yu Gothic UI", 9F);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(227, 162);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(135, 23);
            cbGender.TabIndex = 12;
            // 
            // cbProgram
            // 
            cbProgram.Cursor = Cursors.Hand;
            cbProgram.Font = new Font("Yu Gothic UI", 9F);
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(444, 37);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(211, 23);
            cbProgram.TabIndex = 13;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.YellowGreen;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Yu Gothic UI", 11.25F);
            btnRegister.Location = new Point(724, 23);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(93, 42);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Yu Gothic UI", 11.25F);
            btnUpdate.Location = new Point(724, 71);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(93, 42);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 258);
            label8.Name = "label8";
            label8.Size = new Size(154, 20);
            label8.TabIndex = 16;
            label8.Text = "List Of Club Members:";
            // 
            // gridViewMembers
            // 
            gridViewMembers.AllowUserToAddRows = false;
            gridViewMembers.AllowUserToDeleteRows = false;
            gridViewMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewMembers.Location = new Point(12, 281);
            gridViewMembers.Name = "gridViewMembers";
            gridViewMembers.ReadOnly = true;
            gridViewMembers.Size = new Size(692, 214);
            gridViewMembers.TabIndex = 17;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ControlLight;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(724, 281);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(93, 40);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbProgram);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbGender);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtMiddleName);
            panel1.Controls.Add(txtStudentId);
            panel1.Controls.Add(txtFirstName);
            panel1.ForeColor = SystemColors.ControlDark;
            panel1.Location = new Point(12, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 221);
            panel1.TabIndex = 19;
            // 
            // FrmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 513);
            Controls.Add(btnRefresh);
            Controls.Add(gridViewMembers);
            Controls.Add(label8);
            Controls.Add(btnUpdate);
            Controls.Add(btnRegister);
            Controls.Add(panel1);
            Name = "FrmClubRegistration";
            Text = "FrmClubRegistration";
            Load += FrmClubRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewMembers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtStudentId;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtAge;
        private ComboBox cbGender;
        private ComboBox cbProgram;
        private Button btnRegister;
        private Button btnUpdate;
        private Label label8;
        private DataGridView gridViewMembers;
        private Button btnRefresh;
        private Panel panel1;
    }
}