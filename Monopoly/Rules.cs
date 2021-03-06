﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Rules
    {

        public Rules()
        {

        }

        public void PlayRule(Player p, int space)
        {
            switch (space)
            {
                case 0:
                    Go(p);
                    break;
                case 4:
                    IncomeTax(p);
                    break;
                case 30:
                    GoToJail(p);
                    break;
                case 38:
                    LuxuryTax(p);
                    break;
            }
        }

        public void Go(Player p)
        {
            p.Money += 200;
        }

        public void GoToJail(Player p)
        {
            p.Space = 10;
        }

        public void IncomeTax(Player player)
        {
            if (player.Money > 2000)
                player.Money -= 200;
            else
                player.Money -= (Convert.ToInt32(player.Money * 0.1));
        }

        public void LuxuryTax(Player p)
        {
            p.Money -= 75;
        }
    }
}
