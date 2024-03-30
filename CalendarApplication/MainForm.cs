using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

// Main form class for the Calendar application.
//
// Feel free to explore this code. I make no claims 
// that this code is the most efficent way of doing 
// things or that there are no bugs in the code.
// If you find bugs, let me know and I'll fix them.
// However, there should be no bugs that affect this
// assignment if you implement the classes according
// to the specification.
//

namespace Calendar
{
    public partial class MainForm : Form
    {
        string _calendarEntriesFile = Application.UserAppDataPath + "\\appointments.txt";

        CalendarEntries _calendarEntries;
        List<ICalendarEntry> _todaysEntries;
        ICalendarEntry _selectedCalendarEntry;
        int _selectedRow;
        
        // Number of pixels in a row in the panel
        const int PanelRowHeight = 40;
        
        // X offset from left of panel to the start of
        // a calendar entry block
        const int EntryOffset = 50;

        public MainForm()
        {
            InitializeComponent();
        }

        // Replace the contents of _todaysEntries with
        // the calendar entries for the specified date.

        private void GetEntriesOnSelectedDate(DateTime date)
        {
            _todaysEntries.Clear();
            foreach (ICalendarEntry calendarEntry in _calendarEntries.GetCalendarEntriesOnDate(date))
            {
                _todaysEntries.Add(calendarEntry);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _calendarEntries = new CalendarEntries();
            if (!_calendarEntries.Load(_calendarEntriesFile))
            {
                MessageBox.Show("No appointment file exists or an error occured while trying to load the appointments file",
                                "Creating New File",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            // Initialise everything for 9am on today's date
            _todaysEntries = new List<ICalendarEntry>();
            labelDisplayedDate.Text = DateTime.Now.ToLongDateString();
            GetEntriesOnSelectedDate(DateTime.Now);
            vScrollBar.Height = panelDailyView.ClientRectangle.Size.Height;
            vScrollBar.Maximum = 47 - (panelDailyView.ClientRectangle.Size.Height / PanelRowHeight);
            // 18 is the bar corresponding to 9am.
            vScrollBar.Value = 18;
            _selectedRow = 18;
        }

        private void panelDailyView_Paint(object sender, PaintEventArgs e)
        {
            int paintWidth = panelDailyView.ClientRectangle.Size.Width - vScrollBar.Width;
            int paintHeight = panelDailyView.ClientRectangle.Size.Height;
            int displayedRowCount = paintHeight / PanelRowHeight;
            int panelTopRow;
            int nextRow;
            int entryStartRow;
            int entryLength;
            string dispTime; 
            
            Font font = new Font("Arial", 10);
            Brush drawBrush = new SolidBrush(Color.DarkBlue);
            Brush entryBrush = new SolidBrush(Color.LightBlue);

            Graphics g = e.Graphics;
            // Fill the background of the panel
            g.FillRectangle(new SolidBrush(Color.Linen), 0, 0, paintWidth, paintHeight);
            panelTopRow = vScrollBar.Value;
            if (_selectedRow >= panelTopRow &&
                _selectedRow <= panelTopRow + displayedRowCount)
            {
                // If the selected time is displayed, mark it
                g.FillRectangle(new SolidBrush(Color.DarkKhaki), 
                                0, 
                                (_selectedRow - panelTopRow) * PanelRowHeight,
                                paintWidth,
                                PanelRowHeight);
            }
            // Display the times at the start of the rows and
            // the lines separating the rows
            nextRow = panelTopRow;
            for (int i = 0; i <= displayedRowCount; i++)
            {
                dispTime = (nextRow / 2).ToString("0#") + (nextRow % 2 == 0 ? ":00" : ":30");
                nextRow++;
                g.DrawString(dispTime, font, drawBrush, 2, (i * PanelRowHeight + 4));
                g.DrawLine(Pens.DarkBlue, 0, i * PanelRowHeight, paintWidth, i * PanelRowHeight);
            }
            // Now fill in the appointments
            foreach (ICalendarEntry calendarEntry in _todaysEntries)
            {
                entryStartRow = Utility.ConvertTimeToRow(calendarEntry.Start);
                entryLength = Utility.ConvertLengthToRows(calendarEntry.Length);
                // See if the appointment is inside the part of the day displayed on the panel
                if (((entryStartRow >= panelTopRow) && 
                     (entryStartRow <= panelTopRow + displayedRowCount)) ||
                    (entryStartRow + entryLength > panelTopRow))
                {
                    // Calculate the area of the panel occupied by
                    // the appointment
                    if (entryStartRow < panelTopRow)
                    {
                        entryLength = entryLength - (panelTopRow - entryStartRow);
                        entryStartRow = panelTopRow;
                    }
                    int entryDispStart = (entryStartRow - panelTopRow) * PanelRowHeight;
                    int entryDispLength = entryLength * PanelRowHeight;
                    if (entryDispStart + entryDispLength > paintHeight)  
                    {
                        entryDispLength = paintHeight - entryDispStart;
                    }
                    Rectangle entryRectangle = new Rectangle(EntryOffset,
                                                            entryDispStart,
                                                            paintWidth - (EntryOffset * 2),
                                                            entryDispLength);
                    // Draw the block of light blue
                    g.FillRectangle(entryBrush,
                                    entryRectangle);
                    // Draw the black line around it
                    g.DrawRectangle(Pens.Black, entryRectangle);
                    if (Utility.ConvertTimeToRow(calendarEntry.Start) >= panelTopRow)
                    {
                        // If the top line of the appointment is displayed,
                        // write out the subject and location.  Temporarily
                        // reduce the clip area for the graphics object to ensure
                        // that the text does not extend beyond the rectangle
                        Region oldClip = g.Clip;
                        g.Clip = new Region(entryRectangle);
                        g.DrawString(calendarEntry.DisplayText,
                                     font,
                                     drawBrush,
                                     EntryOffset + 6,
                                     entryDispStart + 4);
                        g.Clip = oldClip;
                    }
                }
            }
        }

        private void panelDailyView_Resize(object sender, EventArgs e)
        {
            int oldMax = vScrollBar.Maximum;

            // Adjust the scroll bar range to reflect the
            // fact that the number of rows on the panel may
            // be different
            vScrollBar.Maximum = 47 - (panelDailyView.ClientRectangle.Size.Height / PanelRowHeight);
            if (vScrollBar.Value == oldMax)
            {
                vScrollBar.Value = vScrollBar.Maximum;
            }
            // Force a repaint of the panel
            panelDailyView.Invalidate();
        }

        private void panelDailyView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // See if we are on an appointment. If
                // so, display the context menu.
                ICalendarEntry calendarEntry = CheckForCalendarEntry(e);
                if (calendarEntry != null)
                {
                    _selectedCalendarEntry = calendarEntry;
                    contextMenuStrip.Show(panelDailyView, new Point(e.X, e.Y));
                }
            }
            else
            {
                // Calculate the new selected row and force
                // a repaint of the panel
                int y = e.Y / PanelRowHeight;
                _selectedRow = y + vScrollBar.Value;
                panelDailyView.Invalidate();
            }
        }

        private void panelDailyView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ICalendarEntry calendarEntry = CheckForCalendarEntry(e);
            if (calendarEntry != null)
            {
                // TODO   Add code to edit the current calendar entry (specified in calendarEntry).
            }
        }        

        private ICalendarEntry CheckForCalendarEntry(MouseEventArgs e)
        {
            bool matchFound = false;
            ICalendarEntry calendarEntry = null;

            if (e.X < EntryOffset ||
                e.X > panelDailyView.ClientRectangle.Size.Width - vScrollBar.Width - EntryOffset)
            {
                // The X co-ordinate is not inside an entry in the calendar, so simply exit
                return null;
            }
            // Determine the row corresponding to the mouse position
            int row = e.Y / PanelRowHeight + vScrollBar.Value;
            // Look through todays entriess to see if we
            // are positioned on any of them
            IEnumerator<ICalendarEntry> enumerator = _todaysEntries.GetEnumerator();
            while (enumerator.MoveNext() && !matchFound)
            {
                int apptRow = Utility.ConvertTimeToRow(enumerator.Current.Start);
                int apptLength = Utility.ConvertLengthToRows(enumerator.Current.Length);
                if (row >= apptRow &&
                    row <= apptRow + apptLength - 1)
                {
                    matchFound = true;
                    calendarEntry = enumerator.Current;
                }
            }
            return calendarEntry;
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            panelDailyView.Invalidate();
        }
        
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            labelDisplayedDate.Text = monthCalendar.SelectionRange.Start.ToLongDateString();
            GetEntriesOnSelectedDate(monthCalendar.SelectionRange.Start);
            // Force repaint of daily view panel
            panelDailyView.Invalidate();
        }

        private void buttonNewAppt_Click(object sender, EventArgs e)
        {
            NewSingleEntry();
        }

        private void newAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSingleEntry();
        }

        private void NewSingleEntry()
        {
            // TODO  Add your code that displays the form to add a new single
            //       calendar entry here.

            NewAppointmentForm singleEntry = new NewAppointmentForm();

            if (singleEntry.ShowDialog() == DialogResult.OK)
            {
                singleEntry.Dispose();
            }
        }

        private void buttonNewReccuringAppt_Click(object sender, EventArgs e)
        {
            NewRecurringEntry();
        }

        private void newRecurringAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRecurringEntry();
        }

        private void NewRecurringEntry()
        {
            // TODO  Add your code that displays the form to add a new recurring
            //       calendar entry here.

            NewRecurringAppointmentForm recurringEntry = new NewRecurringAppointmentForm();

            if (recurringEntry.ShowDialog() == DialogResult.OK)
            {
                recurringEntry.Dispose();
            }          
        }

        private void SaveCalendarEntries()
        {
            if (!_calendarEntries.Save(_calendarEntriesFile))
            {
                MessageBox.Show("An error occured while trying to save the appointments",
                                "Save Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO     Add code to edit the calendar entry specified by _selectedCalendarEntry
            //          here.
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO     Delete current calendar entry
            //          Raised by selecting Delete on the content menu
            //          The selected entry will be in _selectedCalendarEntry
        }

        private void tableLayoutPanelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanelLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}