using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQl_Day_05
{
    public class hireDate
    {
        #region Attribute
        private int Day;
        private int Month;
        private int Year;
        #endregion

        #region Ctor
        public hireDate(int _Day, int _Month, int _Year)
        {
            Day = _Day;
            Month = _Month;
            Year = _Year;
        }
        #endregion

        #region Getters
        public int getDay()
        {
            return Day;
        }

        public int getMonth()
        {
            return Month;
        }

        public int getYear()
        {
            return Year;
        }
        #endregion
    }
}
