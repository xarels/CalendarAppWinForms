using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Calendar
{
    public class CalendarEntries : List<ICalendarEntry>
     {

        public bool Load(string calendarEntriesFile)
        {
            // TODO.  Add your code to load the data from the file specified in
            //        calendarEntriesFile here.  You can edit the following two 
            //        lines if you wish.


            bool status = true;
            return status;
        }

        public bool Save(string calendarEntriesFile)
        {
            // TODO.  Add your code to save the collection to the file specified in
            //        calendarEntriesFile here.  You can edit the following two 
            //        lines if you wish.

            /*string _calendarEntriesFile = Application.UserAppDataPath + "\\appointments.txt";
            StreamWriter saveText = new StreamWriter(_calendarEntriesFile, true);
            saveText.WriteLine(subjectInput.Text);
            saveText.WriteLine(locationInput.Text);

            saveText.Close();

            //DOkoncz !!*/
            bool status = true;
            return status;
        }

        // Iterate through the collection, returning the calendar entries that
        // occur on the specified date

        public IEnumerable<ICalendarEntry> GetCalendarEntriesOnDate(DateTime date)
        {
            for (int i = 0; i < this.Count; i++ )
            {
                if (this[i].OccursOnDate(date))
                {
                    yield return this[i];                
                }
            }
        }
    }
}