using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class RecurringAppointmentEntry : SingleAppointmentEntry
    {
        protected int _repeat;
        protected RecurringFrequency _frequency;

        public RecurringAppointmentEntry()
        {

        }

        public RecurringAppointmentEntry(string newSavedData)
        {
            Split(newSavedData);
        }

        public int repeat
        {
            get
            {
                return _repeat;
            }
            set
            {
                _repeat = value;
            }
        }

        public RecurringFrequency Frequency
        {
            get
            {
                return _frequency;
            }
            set
            {
                _frequency = value;
            }
        }

        public override void Split(string savedData)
        {
            if (savedData != null)
            {
                string[] lines = savedData.Split('\t');

                DateTime.TryParse(lines[0], out _Start);
                _displayText = string.Format("{0}\t{1}\t{2}\t{3}", lines[1], lines[2], lines[3], lines[4]);
                int.TryParse(lines[4], out _repeat);
                int.TryParse(lines[5], out _length);
            }
        }

        public override bool OccursOnDate(DateTime date)
        {
            int x;
            List<DateTime> frequencyList = new List<DateTime>();
            DateTime addFrequency = new DateTime();
            
            switch (_frequency)
            {
                case RecurringFrequency.Daily:                
                    for (x = 0; x <=  _repeat; x++)
                    {
                        addFrequency = _Start.AddDays(x);
                        frequencyList.Add(addFrequency);
                    }
                    break;

                case RecurringFrequency.Fortnightly:
                    for (x = 0; x <=  _repeat; x++)
                    {

                        addFrequency = _Start.AddDays(x*14);
                        frequencyList.Add(addFrequency);
                    }
                    break;

                case RecurringFrequency.Weekly:
                    for (x = 0; x <=  _repeat; x++)
                    {
                        addFrequency = _Start.AddDays(x*7);
                        frequencyList.Add(addFrequency);
                    }
                    break;


                case RecurringFrequency.Monthly:

                    for (x = 0; x <= _repeat; x++)
                    {
                        addFrequency = _Start.AddMonths(x);
                        frequencyList.Add(addFrequency);
                    }
                    break;


                case RecurringFrequency.Yearly:

                    for (x = 0; x <= _repeat; x++)
                    {
                        addFrequency = _Start.AddYears(x);
                        frequencyList.Add(addFrequency);
                    }
                    break;
            }

            foreach (DateTime newDate in frequencyList)
            {
                if (date.Date == newDate.Date)
                {
                    return true;
                }                
            }
            return false;
        }
    }
}



