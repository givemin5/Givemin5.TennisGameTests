using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Givemin5.TennisGameTests
{
    [TestClass]
    public class TennisGameTests
    {
        readonly TennisGame _tennisGame = new TennisGame();
        [TestMethod]
        public void Love_All()
        {
            ScoreShoudBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            _tennisGame.FirstPlayerScore();
            ScoreShoudBe("Fifteen Love");
        }
        private void ScoreShoudBe(string expected)
        {
            Assert.AreEqual(expected, _tennisGame.Score());
        }
    }
}