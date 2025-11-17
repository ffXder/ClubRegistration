namespace ClubRegistration
{
    partial class FrmUpdateMember
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
            cbStudentId = new ComboBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label4 = new Label();
            txtMiddleName = new TextBox();
            label5 = new Label();
            txtAge = new TextBox();
            label6 = new Label();
            cbGender = new ComboBox();
            label7 = new Label();
            cbProgram = new ComboBox();
            btnComfirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11.25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "Student ID:";
            // 
            // cbStudentId
            // 
            cbStudentId.Enabled = false;
            cbStudentId.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStudentId.FormattingEnabled = true;
            cbStudentId.Location = new Point(25, 32);
            cbStudentId.Name = "cbStudentId";
            cbStudentId.Size = new Size(209, 23);
            cbStudentId.TabIndex = 2;
            cbStudentId.SelectedIndexChanged += cbStudentId_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 11.25F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(25, 73);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "LastName:";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(25, 96);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(173, 23);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 11.25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 136);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 5;
            label3.Text = "FirstName:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(25, 159);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(173, 23);
            txtFirstName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 11.25F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(25, 200);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 7;
            label4.Text = "MiddleName:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.Location = new Point(25, 223);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(173, 23);
            txtMiddleName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 11.25F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(25, 264);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 9;
            label5.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(25, 287);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(99, 23);
            txtAge.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 11.25F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(25, 332);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 11;
            label6.Text = "Gender:";
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(25, 355);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(143, 23);
            cbGender.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 11.25F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(25, 401);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 13;
            label7.Text = "Program:";
            // 
            // cbProgram
            // 
            cbProgram.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(25, 424);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(225, 23);
            cbProgram.TabIndex = 14;
            // 
            // btnComfirm
            // 
            btnComfirm.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComfirm.Location = new Point(103, 464);
            btnComfirm.Name = "btnComfirm";
            btnComfirm.Size = new Size(95, 37);
            btnComfirm.TabIndex = 15;
            btnComfirm.Text = "Confirm";
            btnComfirm.UseVisualStyleBackColor = true;
            btnComfirm.Click += btnComfirm_Click;
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 513);
            Controls.Add(btnComfirm);
            Controls.Add(cbProgram);
            Controls.Add(label7);
            Controls.Add(cbGender);
            Controls.Add(label6);
            Controls.Add(txtAge);
            Controls.Add(label5);
            Controls.Add(txtMiddleName);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(cbStudentId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmUpdateMember";
            Text = "FrmUpdateMember";
            Load += FrmUpdateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbStudentId;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private Label label4;
        private TextBox txtMiddleName;
        private Label label5;
        private TextBox txtAge;
        private Label label6;
        private ComboBox cbGender;
        private Label label7;
        private ComboBox cbProgram;
        private Button btnComfirm;
    }
}