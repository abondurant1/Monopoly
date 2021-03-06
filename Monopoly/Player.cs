﻿using System;
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
        private int turn = -1;
        private static Random rnd = new Random();
        private List<ILocation> properties;
        
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

        public List<ILocation> Properties
        {
            get { return properties; }
        }


        public Player()
        {
            space = 0;
            money = 1500;
            properties = new List<ILocation>();
        }

        public int Rolldice()
        {
            int total;
            int die1 = GetRandom();
            int die2 = GetRandom();
            total = die1 + die2;
            return total;
        }

        public int GetRandom()
        {
            return rnd.Next(1, 6);
        }

        public void MovePlayer(int spaces)
        {
            int previousSpace = this.space;
            this.Space = ((this.Space + spaces) % 40);
            //passing Go logic here
            if (previousSpace > this.space && this.space != 0)
                this.money += 200;
        }
    }
}
