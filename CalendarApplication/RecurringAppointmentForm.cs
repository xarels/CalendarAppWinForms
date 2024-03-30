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
    public partial class RecurringAppointmentForm : Form
    {
        int repeat;

        RecurringAppointmentEntry nRA;
        public RecurringAppointmentEntry NRA
        {
            get
            {
                return nRA;
            }
            set
            {
                nRA = value;
            }
        }

        public RecurringAppointmentForm()
        {
            InitializeComponent();
        }

        private void NewRecurringAppointmentForm_Load(object sender, EventArgs e)
        {
            subjectLabel.Text = "Subject:";
            locationLabel.Text = "Location:";
            dateLabel.Text = "Date:";
            startTimeLabel.Text = "Start Time:";
            lengthLabel.Text = "Length:";
            frequencyLabel.Text = "Frequency:";
            occurenceLabel.Text = "Occurance:";
            showDateLabel.Text = nRA.Start.ToLongDateString();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            IntValidation(occurenceInput);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void DropDownMenus()
        {

        }

        public void showDateLabel_Click(object sender, EventArgs e)
        {

        }

        public void EditEntry(ICalendarEntry entry)
        {

            string[] split = entry.DisplayText.Split('\t');

            subjectInput.Text = split[0];
            locationInput.Text = split[1];
            frequencyMenu.Text = split[2];
            occurenceInput.Text = split[3];

            showDateLabel.Text = Utility.ConvertRowToDateTime(entry.Start, startTimeMenu.SelectedIndex).ToLongDateString();
            startTimeMenu.SelectedIndex = Utility.ConvertTimeToRow(entry.Start);
            lengthMenu.SelectedIndex = Utility.ConvertLengthToRows(entry.Length);

        }

        private void IntValidation(TextBox intInput)
        {           
            if (!int.TryParse(intInput.Text, out repeat))
            {
                MessageBox.Show(intInput.Name + " Needs to have only numbers. Please try again.",
                              "Invalid " + intInput.Name,
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }

            else
            {
                Validation(subjectInput, startTimeMenu);
                Validation(locationInput, lengthMenu);
                Validation(occurenceInput, frequencyMenu);
            }
        }

        private void Validation(TextBox validText, ComboBox validIndex)
        {
            if (string.IsNullOrWhiteSpace(validText.Text) || string.IsNullOrEmpty(validIndex.Text) || int.TryParse(validText.Text, out repeat))
            {
                if (int.TryParse(validText.Text, out repeat))
                {
                    if (repeat < 1 || repeat > 999)
                    {
                        MessageBox.Show(validText.Name + " Needs to be more than 0 and less or equal to 999. Please try again.",
                           "Invalid " + validText.Name,
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                        DialogResult = DialogResult.Cancel;
                    }

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
                    RecurringFrequency frequency;
                    string displayText = string.Format("{0}\t{1}\t{2}\t{3}", subjectInput.Text,
                                                                             locationInput.Text,
                                                                             frequencyMenu.Text,
                                                                             occurenceInput.Text);

                    Enum.TryParse<RecurringFrequency>(frequencyMenu.Text, out frequency);
                    nRA.DisplayText = displayText;
                    nRA.Start = Utility.ConvertRowToDateTime(nRA.Start, startTimeMenu.SelectedIndex);
                    nRA.Length = Utility.ConvertRowsToLength(lengthMenu.SelectedIndex);
                    nRA.repeat = repeat;
                    nRA.Frequency = frequency;
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
