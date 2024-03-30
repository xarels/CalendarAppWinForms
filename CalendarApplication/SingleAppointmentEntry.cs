using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class SingleAppointmentEntry : ICalendarEntry
    {
        protected DateTime _Start;
        protected int _length;
        protected string _displayText;
        protected string _savedData;

        public SingleAppointmentEntry()
        {

        }

        public SingleAppointmentEntry(string newSavedData)
        {
            Split(newSavedData);
        }

        public DateTime Start
        {
            get
            {
                return _Start;
            }
            set
            {
                _Start = value;
            }
        }

        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }

        public string DisplayText
        {
            get
            {
                return _displayText;
            }
            set
            {
                _displayText = value;
            }
        }
        public string SavedData
        {
            get
            {
                return string.Format("{0}\t{1}\t{2}", _Start, _displayText, _length);
            }
        }

        public virtual bool OccursOnDate(DateTime date)

        {
            if (date.Date == _Start.Date)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual void Split(string savedData)
        {
            if (savedData != null)
            {
                string[] lines = savedData.Split('\t');
                DateTime.TryParse(lines[0], out _Start);
                _displayText = string.Format("{0}\t{1}", lines[1], lines[2]);
                int.TryParse(lines[3], out _length);
            }
        }
    }
}
