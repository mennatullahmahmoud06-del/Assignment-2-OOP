using System;

namespace Common
{
    // Part 2: represents the hiring date data (day, month, year).
    public class HiringDate
    {
        private int _day;
        private int _month;
        private int _year;

        // Properties with validation so no invalid value can ever be stored,
        // and no runtime exception is thrown even on bad input.
        public int Day
        {
            get { return _day; }
            set { _day = (value >= 1 && value <= 31) ? value : 1; }
        }

        public int Month
        {
            get { return _month; }
            set { _month = (value >= 1 && value <= 12) ? value : 1; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = (value >= 1950 && value <= DateTime.Now.Year) ? value : DateTime.Now.Year; }
        }

        public HiringDate()
        {
            Day = 1;
            Month = 1;
            Year = DateTime.Now.Year;
        }

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return string.Format("{0:D2}/{1:D2}/{2:D4}", Day, Month, Year);
        }
    }
}
