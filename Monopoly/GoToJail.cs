using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class GoToJail : ILocation
    {
        public string Name { get; set; }

        public int Space { get; set; }

        public GoToJail(int space, String name)
        {
            this.Space = space;
            this.Name = name;
        }

        public void LandOn(Player player)
        {
            player.Space = 10;
        }
    }
}
