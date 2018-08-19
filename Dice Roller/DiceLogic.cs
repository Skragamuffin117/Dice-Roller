using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roller
{
    class DiceLogic
    {
        public int Roll(int value)
        {
            int result;
            Random roll = new Random();
            result = roll.Next(1, value);
            return result;
        }
    }
}
