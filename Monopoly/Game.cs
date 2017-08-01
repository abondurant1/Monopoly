using System;
using System.Collections.Generic;
using System.Linq;


namespace Monopoly
{
    public class Game
    {
        private Board board;
        private List<Player> players;
        private int round;
        private int totalRounds;
        private Rules rules;
        private static Random rnd = new Random();
        private String[] tokens = { "Horse", "Car", "Boot", "Wheelbarrow",
            "Iron", "Sack of Money", "Thimble", "Top Hat" };

        public List<Player> Players
        {
            get { return players; }
        }

        public int Round
        {
            get { return round; }
            set { round = value; }
        }

        public int TotalRounds
        {
            get { return totalRounds; }
        }

        public Board Board
        {
            get { return board; }
        }


        public Game(int players, int rounds)
        {
            if (players >= 2 || players <= 8)
            {
                board = new Board();
                board.PopulateBoard();
                rules = new Rules();
                this.players = new List<Player>(players);
                this.round = 0;
                this.totalRounds = rounds;
                for (int i = 0; i < players; i++)
                {
                    this.players.Add(new Player());
                }
            }
            else
            {
                Console.Out.WriteLine("This game requires 2 - 8 players");
            }
        }

        public void DeterminePlayOrder()
        {
            for (int i = 0; i < players.Count; i++)
            {
                int[] turns = CreateTurnList();
                int rnd = GetRandom();

                Boolean found = false;
                do
                {
                    found = false;
                    for (int j = 0; j < turns.Length; j++)
                    {
                        if (rnd == turns[j])
                        {
                            found = true;
                            rnd = GetRandom();
                            break;
                        }
                    }
                } while (found);
                players[i].Turn = rnd;
                players[i].Name = tokens[rnd];
            }
            players = players.OrderBy(p => p.Turn).ToList();
        }

        public int GetRandom()
        {
            return rnd.Next(0, players.Count);
        }


        public int[] CreateTurnList()
        {
            int[] turns = new int[players.Count];
            for (int i = 0; i < players.Count; i++)
            {
                turns[i] = players[i].Turn;
            }
            return turns;
        }

        public void PlayRound()
        {
            foreach (Player player in players)
                PlayATurn(player);

            this.round++;
        }

        public void PlayATurn(Player p)
        {
            int travel = p.Rolldice();
            p.MovePlayer(travel);
            PerformSpaceAction(p, p.Space);
        }

        public void PerformSpaceAction(Player player, int space)
        {
            //rules.PlayRule(player, space);
            Board.Spaces[space].LandOn(player);
        }

    }
}

