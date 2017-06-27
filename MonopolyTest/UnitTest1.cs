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

            for (int i = 0; i < g.Players.Count; i++)
            {
                for (int j = 0; j < g.Players.Count; j++)
                    Assert.AreNotEqual(i, j);
            }
        }
    }
}
