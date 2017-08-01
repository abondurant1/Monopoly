using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Property : ILocation
    {
        public string Name { get; set; }
        public int Space { get; set; }
        public String Color { get; set; }
        public int Price { get; set; }
        public Boolean Owned { get; set; }
        public Boolean Mortgaged { get; set; }

        public Property(int space, String name, int price, String color)
        {
            this.Space = space;
            this.Name = name;
            this.Price = price;
            this.Color = color;
        }

        public void LandOn(Player player)
        {
            if (Owned == false)
            {
                player.Money -= Price;
                player.Properties.Add(this);
                Owned = true;
            }

        }
    }
}
