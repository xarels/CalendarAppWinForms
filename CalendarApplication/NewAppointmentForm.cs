using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class NewAppointmentForm : Form
    {
        public NewAppointmentForm()
        {               
            InitializeComponent();
            showDateLabel.Text = DateTime.Today.ToShortDateString();
            TimeDropDownMenu();
        }

        private void NewAppointmentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DateTime Start;
            int length;

            Start = Convert.ToDateTime(startTimeMenu.SelectedItem);
            int.TryParse(lengthMenu.SelectedText, out length);
            string displayText = string.Format("Location: {0} /nSubject: {1}", locationInput, subjectInput);

            // string savedData = string.Format("Start Time: {0} /nLocation: {1} /nSubject: {2}", Start.ToShortTimeString(), locationInput, subjectInput); /* Just in case the other do not work like it should! */
            string savedData = string.Format("Start Time: {0} /n {1} /nLength {2}", Start.ToShortTimeString(), displayText, length);

            this.saveButton.Enabled = !string.IsNullOrWhiteSpace(this.subjectInput.Text) &&
                                      !string.IsNullOrWhiteSpace(this.locationInput.Text) &&
                                      !string.IsNullOrEmpty(this.startTimeMenu.SelectedText) &&
                                      !string.IsNullOrEmpty(this.lengthMenu.SelectedText);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TimeDropDownMenu()
        {
            DateTime DayTimes = new DateTime();
            DateTime Time;
            string shortTime;

            for (Time = DayTimes.AddHours(6); Time <= DayTimes.AddHours(23); Time = Time.AddMinutes(30))
            {
                shortTime = Time.ToShortTimeString();
                startTimeMenu.Items.AddRange(new string[] { shortTime });
            }
        }
    }
}
