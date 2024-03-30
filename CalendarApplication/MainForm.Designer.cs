namespace Calendar
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRecurringAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDisplayedDate = new System.Windows.Forms.Label();
            this.buttonNewAppt = new System.Windows.Forms.Button();
            this.buttonNewReccuringAppt = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDailyView = new System.Windows.Forms.Panel();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.panelDailyView.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelLeft.SuspendLayout();
            this.tableLayoutPanelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Left;
            this.monthCalendar.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.appointmentsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(776, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAppointmentToolStripMenuItem,
            this.newRecurringAppointmentToolStripMenuItem});
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // newAppointmentToolStripMenuItem
            // 
            this.newAppointmentToolStripMenuItem.Name = "newAppointmentToolStripMenuItem";
            this.newAppointmentToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.newAppointmentToolStripMenuItem.Text = "New Appointment...";
            this.newAppointmentToolStripMenuItem.Click += new System.EventHandler(this.newAppointmentToolStripMenuItem_Click);
            // 
            // newRecurringAppointmentToolStripMenuItem
            // 
            this.newRecurringAppointmentToolStripMenuItem.Name = "newRecurringAppointmentToolStripMenuItem";
            this.newRecurringAppointmentToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.newRecurringAppointmentToolStripMenuItem.Text = "New Recurring Appointment...";
            this.newRecurringAppointmentToolStripMenuItem.Click += new System.EventHandler(this.newRecurringAppointmentToolStripMenuItem_Click);
            // 
            // labelDisplayedDate
            // 
            this.labelDisplayedDate.AutoSize = true;
            this.labelDisplayedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayedDate.Location = new System.Drawing.Point(4, 9);
            this.labelDisplayedDate.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.labelDisplayedDate.Name = "labelDisplayedDate";
            this.labelDisplayedDate.Size = new System.Drawing.Size(0, 16);
            this.labelDisplayedDate.TabIndex = 3;
            // 
            // buttonNewAppt
            // 
            this.buttonNewAppt.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonNewAppt.Location = new System.Drawing.Point(21, 189);
            this.buttonNewAppt.Margin = new System.Windows.Forms.Padding(21, 9, 9, 9);
            this.buttonNewAppt.Name = "buttonNewAppt";
            this.buttonNewAppt.Size = new System.Drawing.Size(152, 37);
            this.buttonNewAppt.TabIndex = 4;
            this.buttonNewAppt.Text = "New Appointment";
            this.buttonNewAppt.UseVisualStyleBackColor = true;
            this.buttonNewAppt.Click += new System.EventHandler(this.buttonNewAppt_Click);
            // 
            // buttonNewReccuringAppt
            // 
            this.buttonNewReccuringAppt.Location = new System.Drawing.Point(21, 244);
            this.buttonNewReccuringAppt.Margin = new System.Windows.Forms.Padding(21, 9, 21, 9);
            this.buttonNewReccuringAppt.Name = "buttonNewReccuringAppt";
            this.buttonNewReccuringAppt.Size = new System.Drawing.Size(152, 37);
            this.buttonNewReccuringAppt.TabIndex = 5;
            this.buttonNewReccuringAppt.Text = "New Recurring Appointment";
            this.buttonNewReccuringAppt.UseVisualStyleBackColor = true;
            this.buttonNewReccuringAppt.Click += new System.EventHandler(this.buttonNewReccuringAppt_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // panelDailyView
            // 
            this.panelDailyView.AutoSize = true;
            this.panelDailyView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDailyView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDailyView.Controls.Add(this.vScrollBar);
            this.panelDailyView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDailyView.Location = new System.Drawing.Point(9, 43);
            this.panelDailyView.Margin = new System.Windows.Forms.Padding(9);
            this.panelDailyView.Name = "panelDailyView";
            this.panelDailyView.Size = new System.Drawing.Size(503, 302);
            this.panelDailyView.TabIndex = 2;
            this.panelDailyView.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDailyView_Paint);
            this.panelDailyView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelDailyView_MouseClick);
            this.panelDailyView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelDailyView_MouseDoubleClick);
            this.panelDailyView.Resize += new System.EventHandler(this.panelDailyView_Resize);
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar.LargeChange = 1;
            this.vScrollBar.Location = new System.Drawing.Point(478, 0);
            this.vScrollBar.Maximum = 0;
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(21, 298);
            this.vScrollBar.TabIndex = 0;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelLeft, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelRight, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(776, 362);
            this.tableLayoutPanel.TabIndex = 6;
            // 
            // tableLayoutPanelLeft
            // 
            this.tableLayoutPanelLeft.AutoSize = true;
            this.tableLayoutPanelLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelLeft.ColumnCount = 1;
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeft.Controls.Add(this.monthCalendar, 0, 0);
            this.tableLayoutPanelLeft.Controls.Add(this.buttonNewReccuringAppt, 0, 2);
            this.tableLayoutPanelLeft.Controls.Add(this.buttonNewAppt, 0, 1);
            this.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanelLeft.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 3;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(245, 360);
            this.tableLayoutPanelLeft.TabIndex = 0;
            this.tableLayoutPanelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelLeft_Paint);
            // 
            // tableLayoutPanelRight
            // 
            this.tableLayoutPanelRight.AutoSize = true;
            this.tableLayoutPanelRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelRight.ColumnCount = 1;
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRight.Controls.Add(this.panelDailyView, 0, 1);
            this.tableLayoutPanelRight.Controls.Add(this.labelDisplayedDate, 0, 0);
            this.tableLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRight.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelRight.Location = new System.Drawing.Point(251, 4);
            this.tableLayoutPanelRight.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            this.tableLayoutPanelRight.RowCount = 2;
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRight.Size = new System.Drawing.Size(521, 354);
            this.tableLayoutPanelRight.TabIndex = 1;
            this.tableLayoutPanelRight.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelRight_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(776, 386);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Appointments Calendar";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.panelDailyView.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanelLeft.ResumeLayout(false);
            this.tableLayoutPanelRight.ResumeLayout(false);
            this.tableLayoutPanelRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelDailyView;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.Label labelDisplayedDate;
        private System.Windows.Forms.Button buttonNewAppt;
        private System.Windows.Forms.Button buttonNewReccuringAppt;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRecurringAppointmentToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRight;
    }
}

