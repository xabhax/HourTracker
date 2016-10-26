namespace HourTracker
{
    partial class addForm
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
            this.serviceList = new System.Windows.Forms.ListBox();
            this.roDate = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.addservicebutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalHours = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.repairOrder = new System.Windows.Forms.TextBox();
            this.addrobutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serviceList
            // 
            this.serviceList.FormattingEnabled = true;
            this.serviceList.Location = new System.Drawing.Point(292, 26);
            this.serviceList.Name = "serviceList";
            this.serviceList.Size = new System.Drawing.Size(176, 277);
            this.serviceList.TabIndex = 0;
            // 
            // roDate
            // 
            this.roDate.Location = new System.Drawing.Point(31, 48);
            this.roDate.Name = "roDate";
            this.roDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "RO Date";
            // 
            // addservicebutton
            // 
            this.addservicebutton.Location = new System.Drawing.Point(292, 322);
            this.addservicebutton.Name = "addservicebutton";
            this.addservicebutton.Size = new System.Drawing.Size(176, 23);
            this.addservicebutton.TabIndex = 3;
            this.addservicebutton.Text = "Add Service to RO";
            this.addservicebutton.UseVisualStyleBackColor = true;
            this.addservicebutton.Click += new System.EventHandler(this.AddServiceClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Hours";
            // 
            // totalHours
            // 
            this.totalHours.AutoSize = true;
            this.totalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHours.Location = new System.Drawing.Point(357, 306);
            this.totalHours.Name = "totalHours";
            this.totalHours.Size = new System.Drawing.Size(0, 13);
            this.totalHours.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Repair Order Number";
            // 
            // repairOrder
            // 
            this.repairOrder.Location = new System.Drawing.Point(31, 261);
            this.repairOrder.Name = "repairOrder";
            this.repairOrder.Size = new System.Drawing.Size(139, 20);
            this.repairOrder.TabIndex = 7;
            // 
            // addrobutton
            // 
            this.addrobutton.Location = new System.Drawing.Point(13, 352);
            this.addrobutton.Name = "addrobutton";
            this.addrobutton.Size = new System.Drawing.Size(75, 23);
            this.addrobutton.TabIndex = 8;
            this.addrobutton.Text = "Add RO";
            this.addrobutton.UseVisualStyleBackColor = true;
            this.addrobutton.Click += new System.EventHandler(this.AddRoClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CancelButtonClicked);
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addrobutton);
            this.Controls.Add(this.repairOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addservicebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roDate);
            this.Controls.Add(this.serviceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "addForm";
            this.ShowIcon = false;
            this.Text = "Hour Tracker -- Add RO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox serviceList;
        private System.Windows.Forms.MonthCalendar roDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addservicebutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox repairOrder;
        private System.Windows.Forms.Button addrobutton;
        private System.Windows.Forms.Button button1;
    }
}