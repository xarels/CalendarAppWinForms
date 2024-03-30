namespace Calendar
{
    partial class RecurringAppointmentForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subjectInput = new System.Windows.Forms.TextBox();
            this.locationInput = new System.Windows.Forms.TextBox();
            this.lengthMenu = new System.Windows.Forms.ComboBox();
            this.startTimeMenu = new System.Windows.Forms.ComboBox();
            this.frequencyMenu = new System.Windows.Forms.ComboBox();
            this.occurenceInput = new System.Windows.Forms.TextBox();
            this.occurenceLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.showDateLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(543, 241);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subjectInput);
            this.groupBox1.Controls.Add(this.locationInput);
            this.groupBox1.Controls.Add(this.lengthMenu);
            this.groupBox1.Controls.Add(this.startTimeMenu);
            this.groupBox1.Controls.Add(this.frequencyMenu);
            this.groupBox1.Controls.Add(this.occurenceInput);
            this.groupBox1.Controls.Add(this.occurenceLabel);
            this.groupBox1.Controls.Add(this.frequencyLabel);
            this.groupBox1.Controls.Add(this.lengthLabel);
            this.groupBox1.Controls.Add(this.startTimeLabel);
            this.groupBox1.Controls.Add(this.showDateLabel);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.locationLabel);
            this.groupBox1.Controls.Add(this.subjectLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 210);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // subjectInput
            // 
            this.subjectInput.Location = new System.Drawing.Point(95, 18);
            this.subjectInput.Name = "subjectInput";
            this.subjectInput.Size = new System.Drawing.Size(600, 20);
            this.subjectInput.TabIndex = 30;
            // 
            // locationInput
            // 
            this.locationInput.Location = new System.Drawing.Point(95, 53);
            this.locationInput.Name = "locationInput";
            this.locationInput.Size = new System.Drawing.Size(600, 20);
            this.locationInput.TabIndex = 29;
            // 
            // lengthMenu
            // 
            this.lengthMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lengthMenu.FormattingEnabled = true;
            this.lengthMenu.Items.AddRange(new object[] {
            "0 minutes",
            "30 minutes",
            "1 hour",
            "1 hours 30 minutes",
            "2 hours",
            "2 hours 30 minutes",
            "3 hours ",
            "3 hours 30 minutes",
            "4 hours",
            "4 hours 30 minutes",
            "5 hours",
            "5 hours 30 minutes",
            "6 hours",
            "6 hours 30 minutes",
            "7 hours",
            "7 hours 30 minutes",
            "8 hours",
            "8 hours 30 minutes",
            "9 hours",
            "9 hours 30 minutes",
            "10 hours ",
            "10 hours 30 minutes",
            "11 hours",
            "11 hours 30 minutes",
            "12 hours",
            "12 hours 30 minutes",
            "13 hours",
            "13 hours 30 minutes",
            "14 hours",
            "14 hours 30 minutes",
            "15 hours",
            "15 hours 30 minutes",
            "16 hours",
            "16 hours 30 minutes",
            "17 hours",
            "17 hours 30 minutes",
            "18 hours",
            "18 hours 30 minutes",
            "19 hours",
            "19 hours 30 minutes",
            "20 hours",
            "20 hours 30 minutes",
            "21 hours",
            "21 hours 30 minutes",
            "22 hours",
            "22 hours 30 minutes",
            "23 hours",
            "23 hours 30 minutes"});
            this.lengthMenu.Location = new System.Drawing.Point(574, 93);
            this.lengthMenu.Name = "lengthMenu";
            this.lengthMenu.Size = new System.Drawing.Size(121, 21);
            this.lengthMenu.TabIndex = 27;
            // 
            // startTimeMenu
            // 
            this.startTimeMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startTimeMenu.FormattingEnabled = true;
            this.startTimeMenu.Items.AddRange(new object[] {
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.startTimeMenu.Location = new System.Drawing.Point(323, 93);
            this.startTimeMenu.Name = "startTimeMenu";
            this.startTimeMenu.Size = new System.Drawing.Size(121, 21);
            this.startTimeMenu.TabIndex = 26;
            // 
            // frequencyMenu
            // 
            this.frequencyMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frequencyMenu.FormattingEnabled = true;
            this.frequencyMenu.Items.AddRange(new object[] {
            "Daily",
            "Forthnightly",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.frequencyMenu.Location = new System.Drawing.Point(91, 126);
            this.frequencyMenu.Name = "frequencyMenu";
            this.frequencyMenu.Size = new System.Drawing.Size(109, 21);
            this.frequencyMenu.TabIndex = 25;
            // 
            // occurenceInput
            // 
            this.occurenceInput.Location = new System.Drawing.Point(475, 129);
            this.occurenceInput.Name = "occurenceInput";
            this.occurenceInput.Size = new System.Drawing.Size(100, 20);
            this.occurenceInput.TabIndex = 24;
            // 
            // occurenceLabel
            // 
            this.occurenceLabel.AutoSize = true;
            this.occurenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occurenceLabel.Location = new System.Drawing.Point(338, 132);
            this.occurenceLabel.Name = "occurenceLabel";
            this.occurenceLabel.Size = new System.Drawing.Size(0, 17);
            this.occurenceLabel.TabIndex = 23;
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyLabel.Location = new System.Drawing.Point(6, 128);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(0, 17);
            this.frequencyLabel.TabIndex = 20;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(488, 94);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(0, 17);
            this.lengthLabel.TabIndex = 17;
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeLabel.Location = new System.Drawing.Point(240, 93);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(0, 17);
            this.startTimeLabel.TabIndex = 16;
            // 
            // showDateLabel
            // 
            this.showDateLabel.AutoSize = true;
            this.showDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDateLabel.Location = new System.Drawing.Point(95, 93);
            this.showDateLabel.Name = "showDateLabel";
            this.showDateLabel.Size = new System.Drawing.Size(0, 17);
            this.showDateLabel.TabIndex = 15;
            this.showDateLabel.Click += new System.EventHandler(this.showDateLabel_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(6, 93);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 17);
            this.dateLabel.TabIndex = 14;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(6, 53);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(0, 17);
            this.locationLabel.TabIndex = 12;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(6, 21);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(0, 17);
            this.subjectLabel.TabIndex = 10;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(642, 241);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // RecurringAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 276);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RecurringAppointmentForm";
            this.Text = "Recurring Appointment";
            this.Load += new System.EventHandler(this.NewRecurringAppointmentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label showDateLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label occurenceLabel;
        private System.Windows.Forms.TextBox locationInput;
        private System.Windows.Forms.ComboBox lengthMenu;
        private System.Windows.Forms.ComboBox startTimeMenu;
        private System.Windows.Forms.ComboBox frequencyMenu;
        private System.Windows.Forms.TextBox occurenceInput;
        private System.Windows.Forms.TextBox subjectInput;
    }
}