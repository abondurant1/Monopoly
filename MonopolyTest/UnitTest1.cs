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
            while (round < g.TotalRounds)
            {
                g.PlayRound();
                round++;
            }
            Assert.AreEqual(round, g.TotalRounds);
        }

        [TestMethod]
        public void PlayerPassesGo()
        {
            g.Round = 5;
            g.Players[0].Money = 1000;
            g.Players[0].Space = 35;
            g.Players[0].MovePlayer(10);
            Assert.AreEqual(1200, g.Players[0].Money);
        }

        [TestMethod]
        public void PlayerLandsOnGo()
        {
            g.Round = 5;
            g.Players[0].Money = 1000;
            g.Players[0].Space = 35;
            g.Players[0].MovePlayer(5);
            g.PerformSpaceAction(g.Players[0], g.Players[0].Space);
            Assert.AreEqual(1200, g.Players[0].Money);
        }

        [TestMethod]
        public void PlayerLandsOnGoToJail()
        {
            g.Players[0].Space = 25;
            g.Players[0].MovePlayer(5);
            g.PerformSpaceAction(g.Players[0], g.Players[0].Space);
            Assert.AreEqual(10, g.Players[0].Space);
        }

        [TestMethod]
        public void PlayerLandsOnIncomeTaxWith1800Cash()
        {
            g.Players[0].Money = 1800;
            g.Players[0].Space = 0;
            g.Players[0].MovePlayer(4);
            g.PerformSpaceAction(g.Players[0], g.Players[0].Space);
            Assert.AreEqual(1620, g.Players[0].Money);
        }
        [TestMethod]
        public void PlayerLandsOnIncomeTaxWith2200Cash()
        {
            g.Players[0].Money = 2200;
            g.Players[0].Space = 0;
            g.Players[0].MovePlayer(4);
            g.PerformSpaceAction(g.Players[0], g.Players[0].Space);
            Assert.AreEqual(2000, g.Players[0].Money);
        }

        [TestMethod]
        public void PlayerLandsOnIncomeTaxWith0Cash()
        {
            g.Players[0].Money = 0;
            g.Players[0].Space = 0;
            g.Players[0].MovePlayer(4);
            g.PerformSpaceAction(g.Players[0], g.Players[0].Space);
            Assert.AreEqual(0, g.Players[0].Money);
        }

        [TestMethod]
        public void PlayerLandsOnIncomeTaxWith2000Cash()
        {
            g.Players[0].Money = 2000;
            g.Players[0].Space = 0;
            g.Players[0].MovePlayer(4);
            g.PerformSpaceAction(g.Players[0], g.Players[0].Space);
            Assert.AreEqual(1800, g.Players[0].Money);
        }

        [TestMethod]
        public void PlayerLandsOnLuxuryTaxWith2000Cash()
        {
            g.Players[0].Money = 2000;
            g.Players[0].Space = 30;
            g.Players[0].MovePlayer(8);
            g.PerformSpaceAction(g.Players[0], g.Players[0].Space);
            Assert.AreEqual(1925, g.Players[0].Money);
        }
    }
}
