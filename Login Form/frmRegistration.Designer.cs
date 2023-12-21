namespace Davis_FinalProject_Cs.Login_Form
{
    partial class frmRegistration
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            groupBox2 = new GroupBox();
            label10 = new Label();
            cmbTitle = new ComboBox();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            label9 = new Label();
            label8 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtInitials = new TextBox();
            txtIdentityNumber = new TextBox();
            btnRegister = new Button();
            label14 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(471, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtConfirmPassword);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 160);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Details";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(25, 106);
            label13.Name = "label13";
            label13.Size = new Size(12, 15);
            label13.TabIndex = 8;
            label13.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(63, 76);
            label12.Name = "label12";
            label12.Size = new Size(12, 15);
            label12.TabIndex = 7;
            label12.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(63, 48);
            label11.Name = "label11";
            label11.Size = new Size(12, 15);
            label11.TabIndex = 6;
            label11.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 108);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 5;
            label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 79);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 50);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(148, 105);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(167, 23);
            txtConfirmPassword.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(148, 76);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(167, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(148, 47);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(167, 23);
            txtUsername.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cmbTitle);
            groupBox2.Controls.Add(rdoFemale);
            groupBox2.Controls.Add(rdoMale);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dtpDateOfBirth);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtFirstName);
            groupBox2.Controls.Add(txtLastName);
            groupBox2.Controls.Add(txtInitials);
            groupBox2.Controls.Add(txtIdentityNumber);
            groupBox2.Location = new Point(12, 241);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(447, 200);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personal Details";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(321, 54);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 16;
            label10.Text = "Initials:";
            // 
            // cmbTitle
            // 
            cmbTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTitle.FormattingEnabled = true;
            cmbTitle.Items.AddRange(new object[] { "Mr", "Mrs", "Ms" });
            cmbTitle.Location = new Point(148, 51);
            cmbTitle.Name = "cmbTitle";
            cmbTitle.Size = new Size(167, 23);
            cmbTitle.TabIndex = 4;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(252, 167);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(63, 19);
            rdoFemale.TabIndex = 10;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(164, 167);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(51, 19);
            rdoMale.TabIndex = 9;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(94, 169);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 12;
            label9.Text = "Gender:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 144);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 11;
            label8.Text = "Date of Birth:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(148, 138);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(105, 23);
            dtpDateOfBirth.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 112);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 9;
            label7.Text = "First Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 83);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 8;
            label6.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 54);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 7;
            label5.Text = "Title:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 25);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 6;
            label4.Text = "Identity Number:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(148, 109);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(167, 23);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(148, 80);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(167, 23);
            txtLastName.TabIndex = 6;
            // 
            // txtInitials
            // 
            txtInitials.Location = new Point(371, 51);
            txtInitials.Name = "txtInitials";
            txtInitials.Size = new Size(67, 23);
            txtInitials.TabIndex = 5;
            // 
            // txtIdentityNumber
            // 
            txtIdentityNumber.Location = new Point(148, 22);
            txtIdentityNumber.Name = "txtIdentityNumber";
            txtIdentityNumber.Size = new Size(244, 23);
            txtIdentityNumber.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(192, 452);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(88, 23);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "&Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(12, 31);
            label14.Name = "label14";
            label14.Size = new Size(93, 15);
            label14.TabIndex = 9;
            label14.Text = "* Required fields";
            // 
            // frmRegistration
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 487);
            Controls.Add(label14);
            Controls.Add(btnRegister);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmRegistration";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registration Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox groupBox1;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private GroupBox groupBox2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtInitials;
        private TextBox txtIdentityNumber;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label10;
        private ComboBox cmbTitle;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private Label label9;
        private Label label8;
        private DateTimePicker dtpDateOfBirth;
        private Button btnRegister;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label14;
    }
}