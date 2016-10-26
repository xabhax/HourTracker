namespace HourTracker
{
    partial class settingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.requireLoginBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.passWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataFilePath = new System.Windows.Forms.TextBox();
            this.databutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.serviceName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.serviceHours = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.applybutton = new System.Windows.Forms.Button();
            this.restartbutton = new System.Windows.Forms.Button();
            this.servicesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Require Login";
            // 
            // requireLoginBox
            // 
            this.requireLoginBox.AutoSize = true;
            this.requireLoginBox.Location = new System.Drawing.Point(106, 32);
            this.requireLoginBox.Name = "requireLoginBox";
            this.requireLoginBox.Size = new System.Drawing.Size(15, 14);
            this.requireLoginBox.TabIndex = 1;
            this.requireLoginBox.UseVisualStyleBackColor = true;
            this.requireLoginBox.CheckedChanged += new System.EventHandler(this.RequireLogin);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(116, 55);
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Size = new System.Drawing.Size(130, 20);
            this.userName.TabIndex = 4;
            // 
            // passWord
            // 
            this.passWord.Location = new System.Drawing.Point(116, 89);
            this.passWord.Name = "passWord";
            this.passWord.PasswordChar = '.';
            this.passWord.ReadOnly = true;
            this.passWord.Size = new System.Drawing.Size(130, 20);
            this.passWord.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "File to store RO data in";
            // 
            // dataFilePath
            // 
            this.dataFilePath.Location = new System.Drawing.Point(55, 162);
            this.dataFilePath.Name = "dataFilePath";
            this.dataFilePath.ReadOnly = true;
            this.dataFilePath.Size = new System.Drawing.Size(149, 20);
            this.dataFilePath.TabIndex = 7;
            // 
            // databutton
            // 
            this.databutton.Location = new System.Drawing.Point(210, 160);
            this.databutton.Name = "databutton";
            this.databutton.Size = new System.Drawing.Size(36, 23);
            this.databutton.TabIndex = 8;
            this.databutton.Text = "...";
            this.databutton.UseVisualStyleBackColor = true;
            this.databutton.Click += new System.EventHandler(this.SaveDataFile);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Services";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Service Name";
            // 
            // serviceName
            // 
            this.serviceName.Location = new System.Drawing.Point(55, 278);
            this.serviceName.Name = "serviceName";
            this.serviceName.Size = new System.Drawing.Size(149, 20);
            this.serviceName.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Flat Rate Time for Service";
            // 
            // serviceHours
            // 
            this.serviceHours.Location = new System.Drawing.Point(55, 327);
            this.serviceHours.Name = "serviceHours";
            this.serviceHours.Size = new System.Drawing.Size(86, 20);
            this.serviceHours.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add Service";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddService);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(433, 378);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 19;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.CancelButtonClicked);
            // 
            // applybutton
            // 
            this.applybutton.Location = new System.Drawing.Point(51, 202);
            this.applybutton.Name = "applybutton";
            this.applybutton.Size = new System.Drawing.Size(114, 23);
            this.applybutton.TabIndex = 20;
            this.applybutton.Text = "Apply Changes";
            this.applybutton.UseVisualStyleBackColor = true;
            this.applybutton.Click += new System.EventHandler(this.ApplyButtonClicked);
            // 
            // restartbutton
            // 
            this.restartbutton.Location = new System.Drawing.Point(171, 202);
            this.restartbutton.Name = "restartbutton";
            this.restartbutton.Size = new System.Drawing.Size(75, 23);
            this.restartbutton.TabIndex = 21;
            this.restartbutton.Text = "Restart";
            this.restartbutton.UseVisualStyleBackColor = true;
            this.restartbutton.Click += new System.EventHandler(this.RestartButtonClicked);
            // 
            // servicesList
            // 
            this.servicesList.FormattingEnabled = true;
            this.servicesList.Location = new System.Drawing.Point(300, 55);
            this.servicesList.Name = "servicesList";
            this.servicesList.Size = new System.Drawing.Size(208, 303);
            this.servicesList.TabIndex = 22;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 413);
            this.Controls.Add(this.servicesList);
            this.Controls.Add(this.restartbutton);
            this.Controls.Add(this.applybutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.serviceHours);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.serviceName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.databutton);
            this.Controls.Add(this.dataFilePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.requireLoginBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "settingsForm";
            this.ShowIcon = false;
            this.Text = "Hour Tracker -- Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox requireLoginBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dataFilePath;
        private System.Windows.Forms.Button databutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox serviceName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox serviceHours;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button applybutton;
        private System.Windows.Forms.Button restartbutton;
        private System.Windows.Forms.ListBox servicesList;
    }
}