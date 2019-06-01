using System.Collections.Generic;

namespace Givemin5.TennisGameTests
{
    public class TennisGame
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;

        public string Score()
        {
            var scoreLookup = new Dictionary<int, string>
            {
                {0,"Love" },
                {1,"Fifteen" },
                {2,"Thirty" },
                {3,"Forty" },
            };
            if (_firstPlayerScore != _secondPlayerScore)
            {
                return $"{scoreLookup[_firstPlayerScore]} {scoreLookup[_secondPlayerScore]}";
            }
            if (_firstPlayerScore >= 3)
            {
                return "Deuce";
            }
            return $"{scoreLookup[_firstPlayerScore]} All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScore++;
        }
    }
}