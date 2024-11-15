using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus
{
    internal struct TimeSpan
    {
        #region hours full property
        private int hours;

        public int Hours
        {
            get { return hours; }
            set
            {
                if (value >= 1 && value <= 12)
                    hours = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        #endregion

        #region minutes full property
        private int minutes;

        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value >= 0 && value < 60)
                    minutes = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        #endregion

        #region seconds full property
        private int seconds;

        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 0 && value < 60)
                    seconds = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        #endregion

        

        #region Convert to Seconds
        public long TotalSeconds()
        {
            return (this.hours * 60 * 60) + (this.minutes * 60) + this.seconds;
        }
        #endregion

        #region print
        public void GetString()
        {
            Console.WriteLine($"{this.hours} :: {this.minutes} :: {this.seconds}");
        }
        #endregion
    }
}
