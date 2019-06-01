using System;
using System.Collections.Generic;

namespace Givemin5.TennisGameTests
{
    public class TennisGame
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;
        private string _firstPlayerName;
        private string _secondPlayerName;

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

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
                if (_firstPlayerScore > 3 || _secondPlayerScore > 3)
                {
                    if (Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1)
                    {
                        var advPlayer = _firstPlayerScore > _secondPlayerScore ? _firstPlayerName : _secondPlayerName;
                        return $"{advPlayer} Adv";
                    }
                }

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