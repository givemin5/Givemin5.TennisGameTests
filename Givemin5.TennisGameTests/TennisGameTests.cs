using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Givemin5.TennisGameTests
{
    [TestClass]
    public class TennisGameTests
    {
        [TestMethod]
        public void Love_All()
        {
            var tennisGame = new TennisGame();
            Assert.AreEqual("Love All", tennisGame.Score());
        }
    }

    public class TennisGame
    {
        public string Score()
        {
            return "Love All";
        }
    }
}