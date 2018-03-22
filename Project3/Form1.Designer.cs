namespace Project3
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.dunLabel1 = new System.Windows.Forms.Label();
            this.dunLab2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resSearchTab = new System.Windows.Forms.TabPage();
            this.idLabel = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.newResTab = new System.Windows.Forms.TabPage();
            this.returnButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.athlete = new System.Windows.Forms.RadioButton();
            this.worker = new System.Windows.Forms.RadioButton();
            this.scholarship = new System.Windows.Forms.RadioButton();
            this.selectionTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.findRes = new System.Windows.Forms.Button();
            this.newRes = new System.Windows.Forms.Button();
            this.menuTab = new System.Windows.Forms.TabPage();
            this.welcome = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.scholarshipTab = new System.Windows.Forms.TabPage();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.athleteTab = new System.Windows.Forms.TabPage();
            this.workerTab = new System.Windows.Forms.TabPage();
            this.return2 = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.resSearchTab.SuspendLayout();
            this.newResTab.SuspendLayout();
            this.selectionTab.SuspendLayout();
            this.menuTab.SuspendLayout();
            this.tabs.SuspendLayout();
            this.scholarshipTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // dunLabel1
            // 
            this.dunLabel1.AutoSize = true;
            this.dunLabel1.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dunLabel1.Location = new System.Drawing.Point(4, 30);
            this.dunLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dunLabel1.Name = "dunLabel1";
            this.dunLabel1.Size = new System.Drawing.Size(184, 29);
            this.dunLabel1.TabIndex = 3;
            this.dunLabel1.Text = "DUNWOODY";
            // 
            // dunLab2
            // 
            this.dunLab2.AutoSize = true;
            this.dunLab2.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dunLab2.Location = new System.Drawing.Point(18, 58);
            this.dunLab2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dunLab2.Name = "dunLab2";
            this.dunLab2.Size = new System.Drawing.Size(149, 16);
            this.dunLab2.TabIndex = 4;
            this.dunLab2.Text = "College of Technology";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Residence Form";
            // 
            // resSearchTab
            // 
            this.resSearchTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resSearchTab.BackgroundImage")));
            this.resSearchTab.Controls.Add(this.return2);
            this.resSearchTab.Controls.Add(this.idLabel);
            this.resSearchTab.Controls.Add(this.idText);
            this.resSearchTab.Location = new System.Drawing.Point(4, 22);
            this.resSearchTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resSearchTab.Name = "resSearchTab";
            this.resSearchTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resSearchTab.Size = new System.Drawing.Size(706, 431);
            this.resSearchTab.TabIndex = 3;
            this.resSearchTab.Text = "Residence Search";
            this.resSearchTab.UseVisualStyleBackColor = true;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(273, 52);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(208, 20);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Enter student ID number";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(332, 115);
            this.idText.MaxLength = 6;
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 20);
            this.idText.TabIndex = 0;
            this.idText.Text = "ID Number";
            // 
            // newResTab
            // 
            this.newResTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newResTab.BackgroundImage")));
            this.newResTab.Controls.Add(this.returnButton);
            this.newResTab.Controls.Add(this.goButton);
            this.newResTab.Controls.Add(this.label4);
            this.newResTab.Controls.Add(this.athlete);
            this.newResTab.Controls.Add(this.worker);
            this.newResTab.Controls.Add(this.scholarship);
            this.newResTab.Location = new System.Drawing.Point(4, 22);
            this.newResTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newResTab.Name = "newResTab";
            this.newResTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newResTab.Size = new System.Drawing.Size(706, 431);
            this.newResTab.TabIndex = 2;
            this.newResTab.Text = "New Residence";
            this.newResTab.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(479, 370);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(196, 43);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Return to Selection";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(341, 174);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.go_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select the type of residence:";
            // 
            // athlete
            // 
            this.athlete.AutoSize = true;
            this.athlete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.athlete.Location = new System.Drawing.Point(298, 89);
            this.athlete.Name = "athlete";
            this.athlete.Size = new System.Drawing.Size(130, 20);
            this.athlete.TabIndex = 2;
            this.athlete.Text = "Student Athlete";
            this.athlete.UseVisualStyleBackColor = true;
            // 
            // worker
            // 
            this.worker.AutoSize = true;
            this.worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worker.Location = new System.Drawing.Point(444, 89);
            this.worker.Name = "worker";
            this.worker.Size = new System.Drawing.Size(132, 20);
            this.worker.TabIndex = 1;
            this.worker.Text = "Student Worker";
            this.worker.UseVisualStyleBackColor = true;
            // 
            // scholarship
            // 
            this.scholarship.AutoSize = true;
            this.scholarship.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scholarship.Location = new System.Drawing.Point(114, 89);
            this.scholarship.Name = "scholarship";
            this.scholarship.Size = new System.Drawing.Size(178, 20);
            this.scholarship.TabIndex = 0;
            this.scholarship.Text = "Scholarship Reciptent";
            this.scholarship.UseVisualStyleBackColor = true;
            // 
            // selectionTab
            // 
            this.selectionTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectionTab.BackgroundImage")));
            this.selectionTab.Controls.Add(this.label5);
            this.selectionTab.Controls.Add(this.findRes);
            this.selectionTab.Controls.Add(this.newRes);
            this.selectionTab.Location = new System.Drawing.Point(4, 22);
            this.selectionTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectionTab.Name = "selectionTab";
            this.selectionTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectionTab.Size = new System.Drawing.Size(706, 431);
            this.selectionTab.TabIndex = 1;
            this.selectionTab.Text = "Selection";
            this.selectionTab.UseVisualStyleBackColor = true;
            this.selectionTab.Click += new System.EventHandler(this.newRes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "What would you like to do?";
            // 
            // findRes
            // 
            this.findRes.Location = new System.Drawing.Point(406, 137);
            this.findRes.Name = "findRes";
            this.findRes.Size = new System.Drawing.Size(95, 23);
            this.findRes.TabIndex = 1;
            this.findRes.Text = "Find Resident";
            this.findRes.UseVisualStyleBackColor = true;
            this.findRes.Click += new System.EventHandler(this.findRes_Click);
            // 
            // newRes
            // 
            this.newRes.Location = new System.Drawing.Point(191, 137);
            this.newRes.Name = "newRes";
            this.newRes.Size = new System.Drawing.Size(104, 23);
            this.newRes.TabIndex = 0;
            this.newRes.Text = "New Resident";
            this.newRes.UseVisualStyleBackColor = true;
            this.newRes.Click += new System.EventHandler(this.newRes_Click);
            // 
            // menuTab
            // 
            this.menuTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuTab.BackgroundImage")));
            this.menuTab.Controls.Add(this.login);
            this.menuTab.Controls.Add(this.titleLabel);
            this.menuTab.Controls.Add(this.password);
            this.menuTab.Controls.Add(this.username);
            this.menuTab.Controls.Add(this.label3);
            this.menuTab.Controls.Add(this.label2);
            this.menuTab.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTab.Location = new System.Drawing.Point(4, 22);
            this.menuTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menuTab.Name = "menuTab";
            this.menuTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menuTab.Size = new System.Drawing.Size(706, 431);
            this.menuTab.TabIndex = 0;
            this.menuTab.Text = "Main Menu";
            this.menuTab.UseVisualStyleBackColor = true;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(18, 145);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(133, 32);
            this.welcome.TabIndex = 6;
            this.welcome.Text = "Welcome \r\nResident Director!";
            this.welcome.Visible = false;
            // 
            // login
            // 
            this.login.Enabled = false;
            this.login.Location = new System.Drawing.Point(370, 258);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(226, 72);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(298, 30);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Resident Director Login";
            // 
            // password
            // 
            this.password.Enabled = false;
            this.password.Location = new System.Drawing.Point(370, 202);
            this.password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(76, 23);
            this.password.TabIndex = 0;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(370, 169);
            this.username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(76, 23);
            this.username.TabIndex = 0;
            this.username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // tabs
            // 
            this.tabs.AccessibleName = "";
            this.tabs.Controls.Add(this.menuTab);
            this.tabs.Controls.Add(this.selectionTab);
            this.tabs.Controls.Add(this.newResTab);
            this.tabs.Controls.Add(this.resSearchTab);
            this.tabs.Controls.Add(this.scholarshipTab);
            this.tabs.Controls.Add(this.athleteTab);
            this.tabs.Controls.Add(this.workerTab);
            this.tabs.Location = new System.Drawing.Point(192, 11);
            this.tabs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(714, 457);
            this.tabs.TabIndex = 2;
            this.tabs.Tag = "";
            // 
            // scholarshipTab
            // 
            this.scholarshipTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scholarshipTab.BackgroundImage")));
            this.scholarshipTab.Controls.Add(this.radioButton3);
            this.scholarshipTab.Controls.Add(this.radioButton1);
            this.scholarshipTab.Controls.Add(this.label7);
            this.scholarshipTab.Controls.Add(this.label6);
            this.scholarshipTab.Location = new System.Drawing.Point(4, 22);
            this.scholarshipTab.Name = "scholarshipTab";
            this.scholarshipTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.scholarshipTab.Size = new System.Drawing.Size(706, 431);
            this.scholarshipTab.TabIndex = 4;
            this.scholarshipTab.Text = "New Scholarship";
            this.scholarshipTab.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(322, 158);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Floor 8";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(322, 119);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Floor 7";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(126, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Please select a floor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Monthly Boarding Fee: $100";
            // 
            // athleteTab
            // 
            this.athleteTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("athleteTab.BackgroundImage")));
            this.athleteTab.Location = new System.Drawing.Point(4, 22);
            this.athleteTab.Name = "athleteTab";
            this.athleteTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.athleteTab.Size = new System.Drawing.Size(706, 431);
            this.athleteTab.TabIndex = 5;
            this.athleteTab.Text = "New Student Athlete";
            this.athleteTab.UseVisualStyleBackColor = true;
            // 
            // workerTab
            // 
            this.workerTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("workerTab.BackgroundImage")));
            this.workerTab.Location = new System.Drawing.Point(4, 22);
            this.workerTab.Name = "workerTab";
            this.workerTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.workerTab.Size = new System.Drawing.Size(706, 431);
            this.workerTab.TabIndex = 6;
            this.workerTab.Text = "New Student Worker";
            this.workerTab.UseVisualStyleBackColor = true;
            // 
            // return2
            // 
            this.return2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return2.Location = new System.Drawing.Point(486, 362);
            this.return2.Name = "return2";
            this.return2.Size = new System.Drawing.Size(196, 43);
            this.return2.TabIndex = 6;
            this.return2.Text = "Return to Selection";
            this.return2.UseVisualStyleBackColor = true;
            this.return2.Click += new System.EventHandler(this.return2_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(48, 441);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(917, 477);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dunLab2);
            this.Controls.Add(this.dunLabel1);
            this.Controls.Add(this.tabs);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dunwoody Residence Hall";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.resSearchTab.ResumeLayout(false);
            this.resSearchTab.PerformLayout();
            this.newResTab.ResumeLayout(false);
            this.newResTab.PerformLayout();
            this.selectionTab.ResumeLayout(false);
            this.selectionTab.PerformLayout();
            this.menuTab.ResumeLayout(false);
            this.menuTab.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.scholarshipTab.ResumeLayout(false);
            this.scholarshipTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dunLabel1;
        private System.Windows.Forms.Label dunLab2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage resSearchTab;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TabPage newResTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton athlete;
        private System.Windows.Forms.RadioButton worker;
        private System.Windows.Forms.RadioButton scholarship;
        private System.Windows.Forms.TabPage selectionTab;
        private System.Windows.Forms.Button findRes;
        private System.Windows.Forms.Button newRes;
        private System.Windows.Forms.TabPage menuTab;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TabPage scholarshipTab;
        private System.Windows.Forms.TabPage athleteTab;
        private System.Windows.Forms.TabPage workerTab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button return2;
        private System.Windows.Forms.Button logoutButton;
    }
}

