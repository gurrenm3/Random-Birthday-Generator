using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Birthday_Generator
{
    struct Birthday
    {
        private static Random rand = new Random();
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        

        public void RandomizeBirthday()
        {
            Year = rand.Next(1936, 2022);
            Month = rand.Next(1, 13);

            var maxDays = DateTime.DaysInMonth(year: Year, month: Month);
            Day = rand.Next(1, maxDays + 1);
        }

        public DateTime ToDateTime()
        {
            return new DateTime(year: Year, month: Month, day: Day);
        }

        public bool IsEqual(Birthday compareTo)
        {
            var timeDifference = DateTime.Compare(this.ToDateTime(), compareTo.ToDateTime());
            return timeDifference == 0;
        }

        public override string ToString()
        {
            return this.ToDateTime().ToShortDateString().ToString();
        }
    }
}
