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
    public partial class SingleAppointmentForm : Form
    {
        SingleAppointmentEntry nA;

        public SingleAppointmentEntry NA
        {
            get
            {
                return nA;
            }
            set
            {
                nA = value;
            }
        }

        public SingleAppointmentForm()
        {
            InitializeComponent();
        }

        private void NewAppointmentForm_Load(object sender, EventArgs e)
        {
            subjectLabel.Text = "Subject:";
            locationLabel.Text = "Location:";
            dateLabel.Text = "Date:";
            startTimeLabel.Text = "Start Time:";
            lengthLabel.Text = "Length:";
            showDateLabel.Text = nA.Start.ToLongDateString();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Validation(subjectInput,startTimeMenu);
            Validation(locationInput,lengthMenu);           
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void showDateLabel_Click(object sender, EventArgs e)
        {
        }

        private void lengthMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void EditEntry(ICalendarEntry entry)
        {
            string[] split = entry.DisplayText.Split('\t');

            subjectInput.Text = split[0];
            locationInput.Text = split[1];

            showDateLabel.Text = Utility.ConvertRowToDateTime(entry.Start, startTimeMenu.SelectedIndex).ToLongDateString();
            startTimeMenu.SelectedIndex = Utility.ConvertTimeToRow(entry.Start);
            lengthMenu.SelectedIndex = Utility.ConvertLengthToRows(entry.Length);
        }
        private void Validation(TextBox validText, ComboBox validIndex)
        {
            if (string.IsNullOrWhiteSpace(validText.Text) || string.IsNullOrEmpty(validIndex.Text))
            {
                if (string.IsNullOrWhiteSpace(validText.Text))
                {
                    MessageBox.Show("You need to fill " + validText.Name + ". Please try again.",
                           "Invalid " + validText.Name,
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                }

                if (string.IsNullOrEmpty(validIndex.Text))
                {
                    MessageBox.Show("You need to fill " + validIndex.Name + ". Please try again.",
                           "Invalid " + validIndex.Name,
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                }
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                string displayText = string.Format("{0}\t{1}", subjectInput.Text,
                                        locationInput.Text);

                nA.DisplayText = displayText;
                nA.Start = Utility.ConvertRowToDateTime(nA.Start, startTimeMenu.SelectedIndex);
                nA.Length = Utility.ConvertRowsToLength(lengthMenu.SelectedIndex);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
