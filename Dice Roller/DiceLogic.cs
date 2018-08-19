using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roller
{
    class DiceLogic
    {

        public int D4()
        {
            int result;
            Random roll = new Random();
            result = roll.Next(1, 5);
            return result;
        }

        public int D6()
        {
            int result;
            Random roll = new Random();
            result = roll.Next(1, 7);
            return result;
        }

        public int D8()
        {
            int result;
            Random roll = new Random();
            result = roll.Next(1, 9);
            return result;
        }

        public int D10()
        {
            int result;
            Random roll = new Random();
            result = roll.Next(1, 11);
            return result;
        }

        public int D12()
        {
            int result;
            Random roll = new Random();
            result = roll.Next(1, 13);
            return result;
        }

        public int D20()
        {
            int result;
            Random roll = new Random();
            result = roll.Next(1, 21);
            return result;
        }

        public int D100()
        {
            int result;
            Random roll = new Random();
            result = roll.Next(1, 101);
            return result;
        }
    }
}
