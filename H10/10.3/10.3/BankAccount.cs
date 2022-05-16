using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._3
{
    internal class BankAccount
    {
        private double _CurrentValue;

        public BankAccount(double initValue)
        {
            _CurrentValue = initValue;
        }

        public double CurrentValue
        {
            get { return _CurrentValue; }
        }

        public void Transaction(double value)
        {
            _CurrentValue = Math.Round(_CurrentValue + value, 2);
        }
    }
}
