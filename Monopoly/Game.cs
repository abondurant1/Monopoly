using System;
using System.Collections.Generic;
using System.Linq;


namespace Monopoly
{
    public class Game
    {
        private Board board;
        private List<Player> players;
        private int[] rounds;
        private static Random rnd = new Random();
        private String[] tokens = { "Horse", "Car", "Boot", "Wheelbarrow",
            "Iron", "Sack of Money", "Thimble", "Top Hat" };

        public List<Player> Players
        {
            get { return players; }
        }

        public int[] Rounds
        {
            get { return rounds; }
        }


        public Game(int players, int rounds)
        {
            if (players >= 2 || players <= 8)
            {
                board = new Board();
                this.players = new List<Player>(players);
                this.rounds = new int[rounds];
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
        }

        public void PlayATurn(Player p)
        {
            p.Rolldice();
        }

    }
}

