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
        }

        [TestMethod]
        public void NoPlayersHaveSameTurn()
        {
            g.DeterminePlayOrder();
            int[] turns = new int[g.Players.Count];
            for (int i = 0; i < g.Players.Count; i++)
            {
                turns[i] = g.Players[i].Turn;
            }

        }
    }
}
