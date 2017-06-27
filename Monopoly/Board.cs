using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Board
    {
        private List<Location> spaces;

        public Board()
        {
            this.spaces = new List<Location>(40);
        }
    }
}
