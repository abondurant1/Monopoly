using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Go : ILocation
    {
        public string Name { get; set; }

        public int Space { get; set; }

        public Go(int space, String name)
        {
            this.Space = space;
            this.Name = name;
        }

        public void LandOn(Player player)
        {
            player.Money += 200;
        }
    }
}
