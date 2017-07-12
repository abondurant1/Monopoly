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
    }
}
