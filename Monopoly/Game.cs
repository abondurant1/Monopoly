using System;
using System.Collections.Generic;

namespace Monopoly
{
    public class Game
    {
        private Board board;
        private List<Player> players;
        private int[] rounds;

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
            Random rnd = new Random();
            foreach (Player player in players)
            {
                player.Turn = rnd.Next(1, players.Count);
                //not working
                for (int i = 0; i < players.Count; i++)
                {
                    if (player != players[i] && player.Turn == players[i].Turn)
                        player.Turn = rnd.Next(1, players.Count);
                }
            }
        }

        public void PlayRound()
        {

        }

        public void MovePlayer()
        {

        }


    }
}

