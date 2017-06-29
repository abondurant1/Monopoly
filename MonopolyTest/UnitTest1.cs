using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTest
{
    [TestClass]
    public class UnitTest1
    {
        private Game g;

        [TestInitialize]
        public void Setup()
        {
            g = new Game(4, 20);
            g.DeterminePlayOrder();
        }

        [TestMethod]
        public void NoFourPlayersHaveSameTurn()
        {
            Boolean expected = true;
            Boolean[] actuals = new Boolean[4];
            int[] turns = new int[4] { 0, 1, 2, 3 };
            foreach (Player player in g.Players)
            {
                for (int i = 0; i < turns.Length; i++)
                {
                    if (player.Turn == i)
                    {
                        actuals[i] = true;
                    }
                }
            }
            foreach (Boolean actual in actuals)
            {
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void PlayerMoves7SpacesFromStart()
        {
            int expected = 7;
            g.Players[0].MovePlayer(7);
            Assert.AreEqual(expected, g.Players[0].Space);
        }

        [TestMethod]
        public void PlayerMoves6SpacesFromLocation39()
        {
            int expected = 5;
            g.Players[0].Space = 39;
            g.Players[0].MovePlayer(6);
            Assert.AreEqual(expected, g.Players[0].Space);
        }

        [TestMethod]
        public void PlayAllRounds()
        {
            int round = 0;
            while (round < g.Rounds.Length)
            {
                g.PlayRound();
                round++;
            }
            Assert.AreEqual(round, g.Rounds.Length);
        }
    }
}
