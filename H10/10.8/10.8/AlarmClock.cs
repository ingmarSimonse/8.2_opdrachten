using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._8
{
    internal class AlarmClock
    {
        public string getTime()
        {
            DateTime time = DateTime.Now;
            return time.ToString("HH:mm:ss");
        }

        public int CheckDifference(string alarmTime)
        {
            StringToTime(alarmTime, out int h1, out int m1, out int s1);
            StringToTime(getTime(), out int h2, out int m2, out int s2);
            return GetTimeInSeconds(h1, m1, s1) - GetTimeInSeconds(h2, m2, s2);
        }

        private int GetTimeInSeconds(int h, int m, int s)
        {
            int sec = h * 3600 + m * 60 + s;
            return sec;
        }

        private void StringToTime(string time, out int h, out int m, out int s)
        {
            List<int> timeList =  time.Split(':').Select(Int32.Parse).ToList();
            h = timeList[0];
            m = timeList[1];
            s = timeList[2];
        }
    }
}
