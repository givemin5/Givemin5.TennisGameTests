﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Givemin5.TennisGameTests
{
    [TestClass]
    public class TennisGameTests
    {
        private readonly TennisGame _tennisGame = new TennisGame();

        [TestMethod]
        public void Love_All()
        {
            ScoreShoudBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            FirstPlayerScoreTimes(1);
            ScoreShoudBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            FirstPlayerScoreTimes(2);
            ScoreShoudBe("Thirty Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            FirstPlayerScoreTimes(3);
            ScoreShoudBe("Forty Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            SecondPlayerScoreTimes(1);
            ScoreShoudBe("Love Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            SecondPlayerScoreTimes(2);
            ScoreShoudBe("Love Thirty");
        }

        [TestMethod]
        public void Love_Forty()
        {
            SecondPlayerScoreTimes(3);
            ScoreShoudBe("Love Forty");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            FirstPlayerScoreTimes(1);
            SecondPlayerScoreTimes(1);
            ScoreShoudBe("Fifteen All");
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

        private void ScoreShoudBe(string expected)
        {
            Assert.AreEqual(expected, _tennisGame.Score());
        }
    }
}