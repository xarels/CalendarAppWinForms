namespace Calendar
{
    partial class NewRecurringAppointmentForm
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
            this.locationRecInput = new System.Windows.Forms.TextBox();
            this.lengthRecMenu = new System.Windows.Forms.ComboBox();
            this.startTimeRecMenu = new System.Windows.Forms.ComboBox();
            this.frequencyMenu = new System.Windows.Forms.ComboBox();
            this.repeatInput = new System.Windows.Forms.TextBox();
            this.timesLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.showDateLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.locationRecInput);
            this.groupBox1.Controls.Add(this.lengthRecMenu);
            this.groupBox1.Controls.Add(this.startTimeRecMenu);
            this.groupBox1.Controls.Add(this.frequencyMenu);
            this.groupBox1.Controls.Add(this.repeatInput);
            this.groupBox1.Controls.Add(this.timesLabel);
            this.groupBox1.Controls.Add(this.frequencyLabel);
            this.groupBox1.Controls.Add(this.lengthLabel);
            this.groupBox1.Controls.Add(this.startTimeLabel);
            this.groupBox1.Controls.Add(this.showDateLabel);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.label1);
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
            // locationRecInput
            // 
            this.locationRecInput.Location = new System.Drawing.Point(95, 53);
            this.locationRecInput.Name = "locationRecInput";
            this.locationRecInput.Size = new System.Drawing.Size(600, 20);
            this.locationRecInput.TabIndex = 29;
            // 
            // lengthRecMenu
            // 
            this.lengthRecMenu.FormattingEnabled = true;
            this.lengthRecMenu.Location = new System.Drawing.Point(574, 93);
            this.lengthRecMenu.Name = "lengthRecMenu";
            this.lengthRecMenu.Size = new System.Drawing.Size(121, 21);
            this.lengthRecMenu.TabIndex = 27;
            // 
            // startTimeRecMenu
            // 
            this.startTimeRecMenu.FormattingEnabled = true;
            this.startTimeRecMenu.Location = new System.Drawing.Point(323, 93);
            this.startTimeRecMenu.Name = "startTimeRecMenu";
            this.startTimeRecMenu.Size = new System.Drawing.Size(121, 21);
            this.startTimeRecMenu.TabIndex = 26;
            // 
            // frequencyMenu
            // 
            this.frequencyMenu.FormattingEnabled = true;
            this.frequencyMenu.Location = new System.Drawing.Point(91, 126);
            this.frequencyMenu.Name = "frequencyMenu";
            this.frequencyMenu.Size = new System.Drawing.Size(109, 21);
            this.frequencyMenu.TabIndex = 25;
            // 
            // repeatInput
            // 
            this.repeatInput.Location = new System.Drawing.Point(398, 127);
            this.repeatInput.Name = "repeatInput";
            this.repeatInput.Size = new System.Drawing.Size(100, 20);
            this.repeatInput.TabIndex = 24;
            // 
            // timesLabel
            // 
            this.timesLabel.AutoSize = true;
            this.timesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLabel.Location = new System.Drawing.Point(258, 130);
            this.timesLabel.Name = "timesLabel";
            this.timesLabel.Size = new System.Drawing.Size(123, 17);
            this.timesLabel.TabIndex = 23;
            this.timesLabel.Text = "How Many Times: ";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyLabel.Location = new System.Drawing.Point(6, 128);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(79, 17);
            this.frequencyLabel.TabIndex = 20;
            this.frequencyLabel.Text = "Frequency:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(488, 94);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(56, 17);
            this.lengthLabel.TabIndex = 17;
            this.lengthLabel.Text = "Length:";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeLabel.Location = new System.Drawing.Point(240, 93);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(77, 17);
            this.startTimeLabel.TabIndex = 16;
            this.startTimeLabel.Text = "Start Time:";
            // 
            // showDateLabel
            // 
            this.showDateLabel.AutoSize = true;
            this.showDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDateLabel.Location = new System.Drawing.Point(95, 93);
            this.showDateLabel.Name = "showDateLabel";
            this.showDateLabel.Size = new System.Drawing.Size(0, 17);
            this.showDateLabel.TabIndex = 15;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(6, 93);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(42, 17);
            this.dateLabel.TabIndex = 14;
            this.dateLabel.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Location:";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(6, 21);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(59, 17);
            this.subjectLabel.TabIndex = 10;
            this.subjectLabel.Text = "Subject:";
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
            // NewRecurringAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 276);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewRecurringAppointmentForm";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label timesLabel;
        private System.Windows.Forms.TextBox locationRecInput;
        private System.Windows.Forms.ComboBox lengthRecMenu;
        private System.Windows.Forms.ComboBox startTimeRecMenu;
        private System.Windows.Forms.ComboBox frequencyMenu;
        private System.Windows.Forms.TextBox repeatInput;
        private System.Windows.Forms.TextBox subjectInput;
    }
}