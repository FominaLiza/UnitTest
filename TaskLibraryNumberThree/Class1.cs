using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibraryNumberThree
{
    public class Years
    {
        public int CalculateDaysInYearArea(int year)
        {
            if (year <= 0) throw new System.ArgumentException("Год должен быть положительным числом");

            bool isLeapYear = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
            return isLeapYear ? 366 : 365;
        }
    }
}
