using System;
using System.Collections.Generic;

namespace Monopoly
{
    public class Game
    {
        private Board board;
        private List<Player> players;
        private int[] rounds;
        private Random rnd = new Random();

        public List<Player> Players
        {
            get { return players; }
        }


        public Game(int players, int rounds)
        {
            board = new Board();
            this.players = new List<Player>(players);
            this.rounds = new int[rounds];
            for (int i = 0; i < players; i++)
            {
                this.players.Add(new Player());
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
            }
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

        }

        public void MovePlayer()
        {

        }


    }
}

