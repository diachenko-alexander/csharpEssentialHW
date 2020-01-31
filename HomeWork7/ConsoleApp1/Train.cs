using System;

namespace Task2
{
    struct Train
    {
        string station;
        int number;
        DateTime time;

        public Train(string station, int number, DateTime time)
        {
            this.station = station;
            this.number = number;
            this.time = time;
        }

        public string Station { get { return station; } }
        public int Number { get { return number; } }
        public DateTime Time { get { return time; } }
    }
}
