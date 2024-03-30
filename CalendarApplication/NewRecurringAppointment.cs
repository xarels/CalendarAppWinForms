using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class NewRecurringAppointment : ICalendarEntry
    {
        DateTime _Start;
        int _length;
        string _displayText;
        string _savedData;

        public NewRecurringAppointment(DateTime NewStart, int newLength, string newDisplayText, string newSavedData)
        {
            _Start = NewStart;
            _length = newLength;
            _displayText = newDisplayText;
            _savedData = newSavedData;
        }

        DateTime ICalendarEntry.Start
        {
            get
            {
                return _Start;
            }
        }

        int ICalendarEntry.Length
        {
            get
            {
                return _length;
            }
        }

        string ICalendarEntry.DisplayText
        {
            get
            {
                return _displayText;
            }
        }
        string ICalendarEntry.SavedData
        {
            get
            {
                return _savedData;
            }
        }

        bool ICalendarEntry.OccursOnDate(DateTime date)
        {
            if (date != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}