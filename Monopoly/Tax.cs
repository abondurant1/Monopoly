using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Tax : ILocation
    {
        public string Name { get; set; }

        public int Space { get; set; }

        int Fee { get; set; }

        public Tax(int space, String name, int fee)
        {
            this.Space = space;
            this.Name = name;
            this.Fee = fee;
        }

        public void LandOn(Player player)
        {
            if (Fee == 75)
                player.Money -= 75;
            else
            if (player.Money > 2000)
                player.Money -= 200;
            else
                player.Money -= (Convert.ToInt32(player.Money * 0.1));
        }
    }
}
