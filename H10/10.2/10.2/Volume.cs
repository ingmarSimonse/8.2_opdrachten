using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2
{
    internal class Volume
    {
        private int _MinValue;
        private int _MaxValue;
        private int _CurrentValue;

        public int MinValue
        {
            get { return _MinValue; }
            set { _MinValue = value; }
        }

        public int MaxValue
        {
            get { return _MaxValue; }
            set { _MaxValue = value; }
        }

        public int CurrentValue
        {
            get { return _CurrentValue; }
            set { _CurrentValue = value; }
        }
    }
}
