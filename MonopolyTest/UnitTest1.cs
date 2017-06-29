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
        public void NoFourPlayersHaveSameTurn()
        {
            g.DeterminePlayOrder();
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
    }
}
