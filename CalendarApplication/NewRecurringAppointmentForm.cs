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
    public partial class NewRecurringAppointmentForm : Form
    {
        public NewRecurringAppointmentForm()
        {
            InitializeComponent();
            showDateLabel.Text = DateTime.Today.ToShortDateString();
        }

        private void NewRecurringAppointmentForm_Load(object sender, EventArgs e)
        {
            DropDownMenus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void DropDownMenus()
        {
            DateTime DayTimes = new DateTime();
            DateTime Time;
            string shortTime;

            for (Time = DayTimes.AddHours(6); Time <= DayTimes.AddHours(23); Time = Time.AddMinutes(30))
            {
                shortTime = Time.ToShortTimeString();
                startTimeRecMenu.Items.AddRange(new string[] { shortTime });
            }

            string[] frequency = new string[5] { "Daily", "Weekly", "Fortnightly", "Monthly", "Yearly"};
            frequencyMenu.Items.AddRange(frequency);
        }
    }
}
