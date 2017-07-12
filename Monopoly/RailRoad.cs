using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Railroad : ILocation
    {
        public string Name { get; set; }

        public int Space { get; set; }

        int Price { get; set; }

        public Railroad(int space, String name, int price)
        {
            this.Space = space;
            this.Name = name;
            this.Price = price;
        }
    }
}
