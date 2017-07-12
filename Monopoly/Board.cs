using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Board
    {
        private List<ILocation> spaces;

        public Board()
        {
            this.spaces = new List<ILocation>(40);
        }

        public void PopulateBoard()
        {
            spaces.Insert(0, new Go(0, "Go"));
            spaces.Insert(1, new Property(1, "Mediterranean Avenue", 60, "Brown"));
            spaces.Insert(2, new CommunityChance(2, "Community Chest", "Community Chest"));
            spaces.Insert(3, new Property(3, "Baltic Avenue", 60, "Brown"));
            spaces.Insert(4, new Tax(4, "Income Tax", 200));
            spaces.Insert(5, new Railroad(5, "Reading Railroad", 200));
            spaces.Insert(6, new Property(6, "Oriental Avenue", 100, "Light Blue"));
            spaces.Insert(7, new CommunityChance(7, "Chance", "Chance"));
            spaces.Insert(8, new Property(8, "Vermont Avenue", 100, "Light Blue"));
            spaces.Insert(9, new Property(9, "Connecticut Avenue", 100, "Light Blue"));
            spaces.Insert(10, new JailOrJustVisiting(10, "In Jail / Just Visiting"));
            spaces.Insert(11, new Property(11, "St. Charles Place", 60, "Purple"));
            spaces.Insert(12, new Company(12, "Electric Company", 150));
            spaces.Insert(13, new Property(13, "States Avenue", 140, "Purple"));
            spaces.Insert(14, new Property(14, "Virginia Avenue", 160, "Purple"));
            spaces.Insert(15, new Railroad(15, "Pennsylvania Railroad", 200));
            spaces.Insert(16, new Property(16, "St. James Place", 180, "Orange"));
            spaces.Insert(17, new CommunityChance(17, "Community Chest", "Community Chest"));
            spaces.Insert(18, new Property(18, "Tennesse Avenue", 180, "Orange"));
            spaces.Insert(19, new Property(19, "New York Avenue", 200, "Orange"));
            spaces.Insert(20, new FreeParking(20, "Free Parking"));
            spaces.Insert(21, new Property(21, "Kentucky Avenue", 220, "Red"));
            spaces.Insert(22, new CommunityChance(22, "Chance", "Chance"));
            spaces.Insert(23, new Property(23, "Indiana Avenue", 220, "Red"));
            spaces.Insert(24, new Property(24, "Illinois Avenue", 240, "Red"));
            spaces.Insert(25, new Railroad(25, "B. & O. Railroad", 200));
            spaces.Insert(26, new Property(26, "Atlantic Avenue", 260, "Yellow"));
            spaces.Insert(27, new Property(27, "Ventnor Avenue", 260, "Yellow"));
            spaces.Insert(28, new Company(28, "Water Works", 150));
            spaces.Insert(29, new Property(29, "Marvin Gardens", 280, "Yellow"));
            spaces.Insert(30, new GoToJail(30, "Go To Jail"));
            spaces.Insert(31, new Property(31, "Pacific Avenue", 300, "Green"));
            spaces.Insert(32, new Property(32, "North Carolina Avenue", 300, "Green"));
            spaces.Insert(33, new CommunityChance(33, "Community Chest", "Community Chest"));
            spaces.Insert(34, new Property(34, "Pennsylvania Avenue", 320, "Green"));
            spaces.Insert(35, new Railroad(35, "Short Line", 200));
            spaces.Insert(36, new CommunityChance(36, "Chance", "Chance"));
            spaces.Insert(37, new Property(37, "Park Place", 350, "Dark Blue"));
            spaces.Insert(38, new Tax(38, "Luxury Tax", 100));
            spaces.Insert(39, new Property(39, "BoardWalk", 400, "Dark Blue"));
        }
    }
}
