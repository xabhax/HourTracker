namespace HourTracker
{
    partial class viewForm
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
            this.repairOrderDisplay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFinishedDisplay = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.servicesList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flaggedHoursDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repair Order";
            // 
            // repairOrderDisplay
            // 
            this.repairOrderDisplay.AutoSize = true;
            this.repairOrderDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairOrderDisplay.Location = new System.Drawing.Point(91, 35);
            this.repairOrderDisplay.Name = "repairOrderDisplay";
            this.repairOrderDisplay.Size = new System.Drawing.Size(0, 13);
            this.repairOrderDisplay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Finished";
            // 
            // dateFinishedDisplay
            // 
            this.dateFinishedDisplay.AutoSize = true;
            this.dateFinishedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinishedDisplay.Location = new System.Drawing.Point(91, 62);
            this.dateFinishedDisplay.Name = "dateFinishedDisplay";
            this.dateFinishedDisplay.Size = new System.Drawing.Size(0, 13);
            this.dateFinishedDisplay.TabIndex = 3;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(12, 299);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButtonClicked);
            // 
            // servicesList
            // 
            this.servicesList.Enabled = false;
            this.servicesList.FormattingEnabled = true;
            this.servicesList.Location = new System.Drawing.Point(206, 35);
            this.servicesList.Name = "servicesList";
            this.servicesList.Size = new System.Drawing.Size(143, 225);
            this.servicesList.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Flagged Hours";
            // 
            // flaggedHoursDisplay
            // 
            this.flaggedHoursDisplay.AutoSize = true;
            this.flaggedHoursDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flaggedHoursDisplay.Location = new System.Drawing.Point(296, 272);
            this.flaggedHoursDisplay.Name = "flaggedHoursDisplay";
            this.flaggedHoursDisplay.Size = new System.Drawing.Size(0, 13);
            this.flaggedHoursDisplay.TabIndex = 7;
            // 
            // viewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 351);
            this.Controls.Add(this.flaggedHoursDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.servicesList);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.dateFinishedDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.repairOrderDisplay);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "viewForm";
            this.ShowIcon = false;
            this.Text = "Hour Tracker -- View RO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label repairOrderDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dateFinishedDisplay;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListBox servicesList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label flaggedHoursDisplay;
    }
}