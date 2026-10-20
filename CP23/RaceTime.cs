using System;
using System.Collections.Generic;
using System.Text;

namespace CP23
{
    class RaceTime : IComparable<RaceTime>
    {
        public double Seconds { get; set; }

        public RaceTime(double seconds)
        {
            Seconds = seconds;
        }

        public int CompareTo(RaceTime? other)
        {
            if (other == null)
                return 1;

            return Seconds.CompareTo(other.Seconds);
        }

        public override string ToString()
        {
            return $"{Seconds:F1} сек.";
        }
    }
}
