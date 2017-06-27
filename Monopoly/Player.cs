using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Player
    {
        private string name;
        private int space;
        private int money;
        private int turn;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Space
        {
            get { return space; }
            set { space = value; }
        }

        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        public int Turn
        {
            get { return turn; }
            set { turn = value; }
        }
        public Player()
        {
            space = 0;
            money = 1500;
        }

        public int Rolldice()
        {
            Random rnd = new Random();
            int die1 = rnd.Next(1, 7);
            int die2 = rnd.Next(1, 7);
            return die1 + die2;
        }
    }
}
