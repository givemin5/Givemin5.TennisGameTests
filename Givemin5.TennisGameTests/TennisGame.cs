using System.Collections.Generic;

namespace Givemin5.TennisGameTests
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        public string Score()
        {
            var scoreLookup = new Dictionary<int, string>
            {
                {1,"Fifteen" },
                {2,"Thirty" },
                {3,"Forty" },
            };
            if (_firstPlayerScoreTimes >= 1)
            {
                return $"{scoreLookup[_firstPlayerScoreTimes]} Love";
            }
            if (_secondPlayerScoreTimes == 1)
            {
                return "Love Fifteen";
            }
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }
    }
}