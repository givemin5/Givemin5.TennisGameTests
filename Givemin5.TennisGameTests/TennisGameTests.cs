using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Givemin5.TennisGameTests
{
    [TestClass]
    public class TennisGameTests
    {
        private TennisGame _tennisGame = new TennisGame("Joey", "Ming");

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
        public void Fifteen_Thirty()
        {
            FirstPlayerScoreTimes(1);
            SecondPlayerScoreTimes(2);
            ScoreShouldBe("Fifteen Thirty");
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

        [TestMethod]
        public void Deuce()
        {
            PlayerDeuce();
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void FirstPlayerAdv()
        {
            PlayerDeuce();
            FirstPlayerScoreTimes(1);
            ScoreShouldBe("Joey Adv");
        }

        [TestMethod]
        public void SecondPlayerAdv()
        {
            PlayerDeuce();
            SecondPlayerScoreTimes(1);
            ScoreShouldBe("Ming Adv");
        }

        [TestMethod]
        public void FirstPlayerWin()
        {
            PlayerDeuce();
            FirstPlayerScoreTimes(2);
            ScoreShouldBe("Joey Win");
        }

        [TestMethod]
        public void SecondPlayerWin()
        {
            PlayerDeuce();
            SecondPlayerScoreTimes(2);
            ScoreShouldBe("Ming Win");
        }

        private void PlayerDeuce()
        {
            FirstPlayerScoreTimes(3);
            SecondPlayerScoreTimes(3);
        }

        [TestMethod]
        public void Deuce4_4()
        {
            FirstPlayerScoreTimes(4);
            SecondPlayerScoreTimes(4);
            ScoreShouldBe("Deuce");
        }

        private void SecondPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennisGame.SecondPlayerScore();
            }
        }

        private void FirstPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennisGame.FirstPlayerScore();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennisGame.Score());
        }
    }
}