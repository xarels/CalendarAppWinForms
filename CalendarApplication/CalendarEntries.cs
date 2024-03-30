using System;
using System.Collections.Generic;
using System.IO;

namespace Calendar
{
    public class CalendarEntries : List<ICalendarEntry>
     {
        public bool Load(string calendarEntriesFile)
        {            
            StreamReader loadText = null;
            string readLine;
            string[] splitLine;

            bool status = true;

            try
            {
                loadText = new StreamReader(calendarEntriesFile);

                while (!loadText.EndOfStream)
                {
                    readLine = loadText.ReadLine();
                    splitLine = readLine.Split('\t');

                    if (splitLine.Length == 4)
                    {
                        this.Add(new SingleAppointmentEntry(readLine));
                    }
                    else
                    {
                        this.Add(new RecurringAppointmentEntry(readLine));
                    }
                }
            }
            catch
            {
                return false;
            }

            finally
            {
                if (loadText != null)
                {
                    loadText.Close();
                }
            }
            return status;
        }

        public bool Save(string calendarEntriesFile)
        {
            StreamWriter saveText = null;
            bool status = true;

            try
            {
                saveText = new StreamWriter(calendarEntriesFile, false);  
                                             
                foreach (ICalendarEntry entry in this)
                 {
                     saveText.WriteLine(entry.SavedData);
                 }
            }
            catch
            {
                return false;
            }   
            finally
            {
                if (saveText != null)
                {
                    saveText.Close();
                }
            }                   
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