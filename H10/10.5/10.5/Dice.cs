using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._5
{
    internal class Dice
    {

        private int _Value = 6;

        public string Throw()
        {
            var rand = new Random();
            _Value = rand.Next(1, 7);
            return _Value.ToString();
        }
    }
}
