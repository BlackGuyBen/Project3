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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuTab = new System.Windows.Forms.TabPage();
            this.loginButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.selectionTab = new System.Windows.Forms.TabPage();
            this.newResTab = new System.Windows.Forms.TabPage();
            this.resSearchTab = new System.Windows.Forms.TabPage();
            this.dunLabel1 = new System.Windows.Forms.Label();
            this.dunLab2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newRes = new System.Windows.Forms.Button();
            this.findRes = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.menuTab.SuspendLayout();
            this.selectionTab.SuspendLayout();
            this.newResTab.SuspendLayout();
            this.resSearchTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.menuTab);
            this.tabControl1.Controls.Add(this.selectionTab);
            this.tabControl1.Controls.Add(this.newResTab);
            this.tabControl1.Controls.Add(this.resSearchTab);
            this.tabControl1.Location = new System.Drawing.Point(174, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 457);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Tag = "";
            // 
            // menuTab
            // 
            this.menuTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuTab.BackgroundImage")));
            this.menuTab.Controls.Add(this.loginButton);
            this.menuTab.Controls.Add(this.titleLabel);
            this.menuTab.Controls.Add(this.textBox2);
            this.menuTab.Controls.Add(this.label3);
            this.menuTab.Controls.Add(this.label2);
            this.menuTab.Controls.Add(this.textBox1);
            this.menuTab.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTab.Location = new System.Drawing.Point(4, 22);
            this.menuTab.Margin = new System.Windows.Forms.Padding(2);
            this.menuTab.Name = "menuTab";
            this.menuTab.Padding = new System.Windows.Forms.Padding(2);
            this.menuTab.Size = new System.Drawing.Size(506, 431);
            this.menuTab.TabIndex = 0;
            this.menuTab.Text = "Main Menu";
            this.menuTab.UseVisualStyleBackColor = true;
            this.menuTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(222, 251);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(78, 33);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(100, 106);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(298, 30);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Resident Director Login";
            this.titleLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 208);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 175);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // selectionTab
            // 
            this.selectionTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectionTab.BackgroundImage")));
            this.selectionTab.Controls.Add(this.findRes);
            this.selectionTab.Controls.Add(this.newRes);
            this.selectionTab.Location = new System.Drawing.Point(4, 22);
            this.selectionTab.Margin = new System.Windows.Forms.Padding(2);
            this.selectionTab.Name = "selectionTab";
            this.selectionTab.Padding = new System.Windows.Forms.Padding(2);
            this.selectionTab.Size = new System.Drawing.Size(506, 431);
            this.selectionTab.TabIndex = 1;
            this.selectionTab.Text = "Selection";
            this.selectionTab.UseVisualStyleBackColor = true;
            // 
            // newResTab
            // 
            this.newResTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newResTab.BackgroundImage")));
            this.newResTab.Controls.Add(this.label4);
            this.newResTab.Controls.Add(this.radioButton3);
            this.newResTab.Controls.Add(this.radioButton2);
            this.newResTab.Controls.Add(this.radioButton1);
            this.newResTab.Location = new System.Drawing.Point(4, 22);
            this.newResTab.Margin = new System.Windows.Forms.Padding(2);
            this.newResTab.Name = "newResTab";
            this.newResTab.Padding = new System.Windows.Forms.Padding(2);
            this.newResTab.Size = new System.Drawing.Size(506, 431);
            this.newResTab.TabIndex = 2;
            this.newResTab.Text = "New Residence";
            this.newResTab.UseVisualStyleBackColor = true;
            // 
            // resSearchTab
            // 
            this.resSearchTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resSearchTab.BackgroundImage")));
            this.resSearchTab.Controls.Add(this.label5);
            this.resSearchTab.Controls.Add(this.idText);
            this.resSearchTab.Location = new System.Drawing.Point(4, 22);
            this.resSearchTab.Margin = new System.Windows.Forms.Padding(2);
            this.resSearchTab.Name = "resSearchTab";
            this.resSearchTab.Padding = new System.Windows.Forms.Padding(2);
            this.resSearchTab.Size = new System.Drawing.Size(506, 431);
            this.resSearchTab.TabIndex = 3;
            this.resSearchTab.Text = "Residence Search";
            this.resSearchTab.UseVisualStyleBackColor = true;
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
            // newRes
            // 
            this.newRes.Location = new System.Drawing.Point(91, 123);
            this.newRes.Name = "newRes";
            this.newRes.Size = new System.Drawing.Size(104, 23);
            this.newRes.TabIndex = 0;
            this.newRes.Text = "New Resident";
            this.newRes.UseVisualStyleBackColor = true;
            // 
            // findRes
            // 
            this.findRes.Location = new System.Drawing.Point(306, 123);
            this.findRes.Name = "findRes";
            this.findRes.Size = new System.Drawing.Size(95, 23);
            this.findRes.TabIndex = 1;
            this.findRes.Text = "Find Resident";
            this.findRes.UseVisualStyleBackColor = true;
            this.findRes.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(27, 86);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(178, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Scholarship Reciptent";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(357, 86);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Student Worker";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(211, 86);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(130, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Student Athlete";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select the type of residence:";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(202, 96);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 20);
            this.idText.TabIndex = 0;
            this.idText.Text = "ID Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Enter student ID number";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(698, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dunLab2);
            this.Controls.Add(this.dunLabel1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dunwoody Residence Hall";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.menuTab.ResumeLayout(false);
            this.menuTab.PerformLayout();
            this.selectionTab.ResumeLayout(false);
            this.newResTab.ResumeLayout(false);
            this.newResTab.PerformLayout();
            this.resSearchTab.ResumeLayout(false);
            this.resSearchTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage menuTab;
        private System.Windows.Forms.TabPage selectionTab;
        private System.Windows.Forms.TabPage newResTab;
        private System.Windows.Forms.TabPage resSearchTab;
        private System.Windows.Forms.Label dunLabel1;
        private System.Windows.Forms.Label dunLab2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button findRes;
        private System.Windows.Forms.Button newRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idText;
    }
}

