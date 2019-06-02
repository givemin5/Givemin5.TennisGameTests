using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Givemin5.TennisGameTests
{
    [TestClass]
    public class TennisGameTests
    {
        [TestMethod]
        public void Love_All()
        {
            TennisGame tennisGame = new TennisGame();
            Assert.AreEqual("Love All", tennisGame.Score());
        }
    }
}