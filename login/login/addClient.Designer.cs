namespace login
{
    partial class addClient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CompleteAddress = new System.Windows.Forms.TextBox();
            this.ContactNumber = new System.Windows.Forms.TextBox();
            this.EmailAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CivilStatus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.AccountStatus = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 92);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // FirstName
            // 
            this.FirstName.BackColor = System.Drawing.SystemColors.Window;
            this.FirstName.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName.ForeColor = System.Drawing.Color.Silver;
            this.FirstName.Location = new System.Drawing.Point(17, 163);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstName.Multiline = true;
            this.FirstName.Name = "FirstName";
            this.FirstName.PasswordChar = '•';
            this.FirstName.Size = new System.Drawing.Size(268, 36);
            this.FirstName.TabIndex = 200;
            this.FirstName.Text = "First Name";
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstName.UseSystemPasswordChar = true;
            this.FirstName.Enter += new System.EventHandler(this.textBox1_Enter);
            this.FirstName.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(336, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Middle Name";
            // 
            // MiddleName
            // 
            this.MiddleName.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MiddleName.ForeColor = System.Drawing.Color.Silver;
            this.MiddleName.Location = new System.Drawing.Point(336, 163);
            this.MiddleName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MiddleName.Multiline = true;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.PasswordChar = '•';
            this.MiddleName.Size = new System.Drawing.Size(268, 36);
            this.MiddleName.TabIndex = 2;
            this.MiddleName.Text = "Middle Name";
            this.MiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MiddleName.UseSystemPasswordChar = true;
            this.MiddleName.Enter += new System.EventHandler(this.textBox2_Enter);
            this.MiddleName.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(660, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName.ForeColor = System.Drawing.Color.Silver;
            this.LastName.Location = new System.Drawing.Point(660, 163);
            this.LastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastName.Multiline = true;
            this.LastName.Name = "LastName";
            this.LastName.PasswordChar = '•';
            this.LastName.Size = new System.Drawing.Size(268, 36);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name";
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastName.UseSystemPasswordChar = true;
            this.LastName.Enter += new System.EventHandler(this.textBox3_Enter);
            this.LastName.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Complete Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(336, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Contact Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(660, 230);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Email Address";
            // 
            // CompleteAddress
            // 
            this.CompleteAddress.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompleteAddress.ForeColor = System.Drawing.Color.Silver;
            this.CompleteAddress.Location = new System.Drawing.Point(17, 270);
            this.CompleteAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CompleteAddress.Multiline = true;
            this.CompleteAddress.Name = "CompleteAddress";
            this.CompleteAddress.PasswordChar = '•';
            this.CompleteAddress.Size = new System.Drawing.Size(268, 36);
            this.CompleteAddress.TabIndex = 2;
            this.CompleteAddress.Text = "Enter Complete Address";
            this.CompleteAddress.UseSystemPasswordChar = true;
            this.CompleteAddress.Enter += new System.EventHandler(this.textBox4_Enter);
            this.CompleteAddress.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // ContactNumber
            // 
            this.ContactNumber.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactNumber.ForeColor = System.Drawing.Color.Silver;
            this.ContactNumber.Location = new System.Drawing.Point(336, 270);
            this.ContactNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContactNumber.Multiline = true;
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.PasswordChar = '•';
            this.ContactNumber.Size = new System.Drawing.Size(268, 36);
            this.ContactNumber.TabIndex = 2;
            this.ContactNumber.Text = "Enter Contact Number";
            this.ContactNumber.UseSystemPasswordChar = true;
            this.ContactNumber.Enter += new System.EventHandler(this.textBox5_Enter);
            this.ContactNumber.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // EmailAddress
            // 
            this.EmailAddress.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailAddress.ForeColor = System.Drawing.Color.Silver;
            this.EmailAddress.Location = new System.Drawing.Point(660, 270);
            this.EmailAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailAddress.Multiline = true;
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.PasswordChar = '•';
            this.EmailAddress.Size = new System.Drawing.Size(268, 36);
            this.EmailAddress.TabIndex = 2;
            this.EmailAddress.Text = "Enter Email Address";
            this.EmailAddress.UseSystemPasswordChar = true;
            this.EmailAddress.Enter += new System.EventHandler(this.textBox6_Enter);
            this.EmailAddress.Leave += new System.EventHandler(this.textBox6_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(17, 333);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Gender";
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gender.ForeColor = System.Drawing.Color.Silver;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(17, 373);
            this.Gender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(205, 33);
            this.Gender.TabIndex = 3;
            this.Gender.Text = "Gender";
            this.Gender.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.Gender.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(269, 333);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Civil Status";
            // 
            // CivilStatus
            // 
            this.CivilStatus.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CivilStatus.ForeColor = System.Drawing.Color.Silver;
            this.CivilStatus.Location = new System.Drawing.Point(269, 373);
            this.CivilStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CivilStatus.Multiline = true;
            this.CivilStatus.Name = "CivilStatus";
            this.CivilStatus.PasswordChar = '•';
            this.CivilStatus.Size = new System.Drawing.Size(221, 36);
            this.CivilStatus.TabIndex = 2;
            this.CivilStatus.Text = "Enter Civil Status";
            this.CivilStatus.UseSystemPasswordChar = true;
            this.CivilStatus.Enter += new System.EventHandler(this.textBox7_Enter);
            this.CivilStatus.Leave += new System.EventHandler(this.textBox7_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(533, 333);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "Birthdate";
            // 
            // Date
            // 
            this.Date.CustomFormat = "yyyy/mm/dd";
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(534, 373);
            this.Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(223, 31);
            this.Date.TabIndex = 24;
            this.Date.Value = new System.DateTime(2023, 1, 21, 12, 32, 30, 0);
            this.Date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(811, 333);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Age";
            // 
            // Age
            // 
            this.Age.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Age.ForeColor = System.Drawing.Color.Silver;
            this.Age.Location = new System.Drawing.Point(807, 373);
            this.Age.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Age.Multiline = true;
            this.Age.Name = "Age";
            this.Age.PasswordChar = '•';
            this.Age.Size = new System.Drawing.Size(121, 36);
            this.Age.TabIndex = 2;
            this.Age.Text = "Enter Age";
            this.Age.UseSystemPasswordChar = true;
            this.Age.Enter += new System.EventHandler(this.textBox8_Enter);
            this.Age.Leave += new System.EventHandler(this.textBox8_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(17, 437);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 32);
            this.label12.TabIndex = 1;
            this.label12.Text = "Username";
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.ForeColor = System.Drawing.Color.Silver;
            this.Username.Location = new System.Drawing.Point(17, 477);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.PasswordChar = '•';
            this.Username.Size = new System.Drawing.Size(268, 36);
            this.Username.TabIndex = 2;
            this.Username.Text = "Enter Username";
            this.Username.UseSystemPasswordChar = true;
            this.Username.Enter += new System.EventHandler(this.textBox9_Enter);
            this.Username.Leave += new System.EventHandler(this.textBox9_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(336, 437);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 32);
            this.label13.TabIndex = 1;
            this.label13.Text = "Password";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.ForeColor = System.Drawing.Color.Silver;
            this.Password.Location = new System.Drawing.Point(336, 477);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '•';
            this.Password.Size = new System.Drawing.Size(268, 36);
            this.Password.TabIndex = 2;
            this.Password.Text = "Enter Password";
            this.Password.UseSystemPasswordChar = true;
            this.Password.Enter += new System.EventHandler(this.textBox10_Enter);
            this.Password.Leave += new System.EventHandler(this.textBox10_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(660, 437);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 32);
            this.label14.TabIndex = 1;
            this.label14.Text = "Account Status";
            // 
            // AccountStatus
            // 
            this.AccountStatus.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountStatus.ForeColor = System.Drawing.Color.Silver;
            this.AccountStatus.Location = new System.Drawing.Point(660, 477);
            this.AccountStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccountStatus.Multiline = true;
            this.AccountStatus.Name = "AccountStatus";
            this.AccountStatus.PasswordChar = '•';
            this.AccountStatus.Size = new System.Drawing.Size(268, 36);
            this.AccountStatus.TabIndex = 2;
            this.AccountStatus.Text = "Enter Account Status";
            this.AccountStatus.UseSystemPasswordChar = true;
            this.AccountStatus.Enter += new System.EventHandler(this.textBox11_Enter);
            this.AccountStatus.Leave += new System.EventHandler(this.textBox11_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 578);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 94);
            this.panel2.TabIndex = 25;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(123)))), ((int)(((byte)(253)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(816, 18);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(114, 53);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Submit";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Red;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(17, 18);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(104, 57);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Close";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // addClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 672);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.AccountStatus);
            this.Controls.Add(this.EmailAddress);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.CivilStatus);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ContactNumber);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.CompleteAddress);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "addClient";
            this.Text = "addClient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox FirstName;
        private Label label3;
        private TextBox MiddleName;
        private Label label4;
        private TextBox LastName;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox CompleteAddress;
        private TextBox ContactNumber;
        private TextBox EmailAddress;
        private Label label8;
        private ComboBox Gender;
        private Label label9;
        private TextBox CivilStatus;
        private Label label10;
        private DateTimePicker Date;
        private Label label11;
        private TextBox Age;
        private Label label12;
        private TextBox Username;
        private Label label13;
        private TextBox Password;
        private Label label14;
        private TextBox AccountStatus;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}