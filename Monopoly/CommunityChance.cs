using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class CommunityChance : ILocation
    {
        public string Name { get; set; }

        public int Space { get; set; }

        public String Type { get; set; }

        public CommunityChance(int space, String name, String Type)
        {
            this.Space = space;
            this.Name = name;
            this.Type = Type;
        }
    }
}
