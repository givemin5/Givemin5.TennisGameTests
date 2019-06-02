using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Givemin5.TennisGameTests
{
    [TestClass]
    public class TennisGameTests
    {
        private TennisGame tennisGame = new TennisGame();

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            FirstPlayerScoreTimes(1);
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            SecondPlayerScoreTimes(1);
            ScoreShouldBe("Love Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            SecondPlayerScoreTimes(2);
            ScoreShouldBe("Love Thirty");
        }

        [TestMethod]
        public void Love_Forty()
        {
            SecondPlayerScoreTimes(3);
            ScoreShouldBe("Love Forty");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            FirstPlayerScoreTimes(1);
            SecondPlayerScoreTimes(1);
            ScoreShouldBe("Fifteen All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            FirstPlayerScoreTimes(2);
            SecondPlayerScoreTimes(2);
            ScoreShouldBe("Thirty All");
        }

        private void SecondPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.SecondPlayerScore();
            }
        }

        [TestMethod]
        public void Thirty_Love()
        {
            FirstPlayerScoreTimes(2);
            ScoreShouldBe("Thirty Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            FirstPlayerScoreTimes(3);
            ScoreShouldBe("Forty Love");
        }

        private void FirstPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.FirstPlayerScore();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, tennisGame.Score());
        }
    }
}