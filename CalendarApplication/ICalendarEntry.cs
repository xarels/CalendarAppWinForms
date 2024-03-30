using System;

namespace Calendar
{
    public interface ICalendarEntry
    {
        DateTime Start { get; }
        int Length { get; }
        string DisplayText { get; }
        string SavedData { get; }
        bool OccursOnDate(DateTime date);
    }
}
