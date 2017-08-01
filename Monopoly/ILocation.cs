using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public interface ILocation
    {
        String Name { get;}
        int Space { get;}
        void LandOn(Player player); 

    }
}
