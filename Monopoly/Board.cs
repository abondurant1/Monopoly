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

        public void PopulateBoard()
        {
            spaces.Insert(0, new Location(0, "Go", 0));
            spaces.Insert(1, new Location(1, "Mediterranean Avenue", 60));
            spaces.Insert(2, new Location(2, "Community Chest", 0));
            spaces.Insert(3, new Location(3, "Baltic Avenue", 60));
            spaces.Insert(4, new Location(4, "Income Tax", 200));
            spaces.Insert(5, new Location(5, "Reading Railroad", 200));
            spaces.Insert(6, new Location(6, "Oriental Avenue", 100));
            spaces.Insert(7, new Location(7, "Chance", 0));
            spaces.Insert(8, new Location(8, "Vermont Avenue", 100));
            spaces.Insert(9, new Location(9, "Connecticut Avenue", 100));
            spaces.Insert(10, new Location(10, "In Jail / Just Visiting", 0));
            spaces.Insert(11, new Location(11, "St. Charles Place", 60));
            spaces.Insert(12, new Location(12, "Electric Company", 150));
            spaces.Insert(13, new Location(13, "States Avenue", 140));
            spaces.Insert(14, new Location(14, "Virginia Avenue", 160));
            spaces.Insert(15, new Location(15, "Pennsylvania Railroad", 200));
            spaces.Insert(16, new Location(16, "St. James Place", 180));
            spaces.Insert(17, new Location(17, "Community Chest", 0));
            spaces.Insert(18, new Location(18, "Tennesse Avenue", 180));
            spaces.Insert(19, new Location(19, "New York Avenue", 200));
            spaces.Insert(20, new Location(20, "Free Parking", 0));
            spaces.Insert(21, new Location(21, "Kentucky Avenue", 220));
            spaces.Insert(22, new Location(22, "Chance", 0));
            spaces.Insert(23, new Location(23, "Indiana Avenue", 220));
            spaces.Insert(24, new Location(24, "Illinois Avenue", 240));
            spaces.Insert(25, new Location(25, "B. & O. Railroad", 200));
            spaces.Insert(26, new Location(26, "Atlantic Avenue", 260));
            spaces.Insert(27, new Location(27, "Ventnor Avenue", 260));
            spaces.Insert(28, new Location(28, "Water Works", 150));
            spaces.Insert(29, new Location(29, "Marvin Gardens", 280));
            spaces.Insert(30, new Location(30, "Go To Jail", 0));
            spaces.Insert(31, new Location(31, "Pacific Avenue", 300));
            spaces.Insert(32, new Location(32, "North Carolina Avenue", 300));
            spaces.Insert(33, new Location(33, "Community Chest", 0));
            spaces.Insert(34, new Location(34, "Pennsylvania Avenue", 320));
            spaces.Insert(35, new Location(35, "Short Line", 200));
            spaces.Insert(36, new Location(36, "Chance", 0));
            spaces.Insert(37, new Location(37, "Park Place", 350));
            spaces.Insert(38, new Location(38, "Luxury Tax", 100));
            spaces.Insert(39, new Location(39, "BoardWalk", 400));
        }
    }
}
