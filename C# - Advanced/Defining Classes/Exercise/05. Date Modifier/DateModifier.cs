using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
         public int DaysDifference(string fromDate, string toDate)
        {
            DateTime d1 = DateTime.ParseExact(fromDate, "yyyy MM dd", null);
            DateTime d2 = DateTime.ParseExact(toDate, "yyyy MM dd", null);

            int result = (d2.Date - d1.Date).Days;
            if (result < 0)
            {
                result *= -1;
            }
            return result;
        }
    }
}
