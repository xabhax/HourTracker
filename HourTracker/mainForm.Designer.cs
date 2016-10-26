namespace HourTracker
{
    partial class mainForm
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
            this.roDate = new System.Windows.Forms.MonthCalendar();
            this.roList = new System.Windows.Forms.ListBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.addRO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roDate
            // 
            this.roDate.Location = new System.Drawing.Point(36, 56);
            this.roDate.Name = "roDate";
            this.roDate.TabIndex = 0;
            this.roDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.FillROListbox);
            // 
            // roList
            // 
            this.roList.FormattingEnabled = true;
            this.roList.Location = new System.Drawing.Point(364, 12);
            this.roList.Name = "roList";
            this.roList.Size = new System.Drawing.Size(210, 329);
            this.roList.TabIndex = 1;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(12, 348);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(102, 23);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButtonClicked);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(364, 348);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(210, 23);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "View Repair Order";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.ViewButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Use the calender below to view ROs from a specific date.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Or select date and click on the \'Add RO\' button";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(120, 348);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(102, 23);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.QuitButtonClicked);
            // 
            // addRO
            // 
            this.addRO.Location = new System.Drawing.Point(36, 231);
            this.addRO.Name = "addRO";
            this.addRO.Size = new System.Drawing.Size(227, 23);
            this.addRO.TabIndex = 7;
            this.addRO.Text = "Add RO";
            this.addRO.UseVisualStyleBackColor = true;
            this.addRO.Click += new System.EventHandler(this.AddROButtonClicked);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 381);
            this.Controls.Add(this.addRO);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.roList);
            this.Controls.Add(this.roDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Hour Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar roDate;
        private System.Windows.Forms.ListBox roList;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button addRO;
    }
}