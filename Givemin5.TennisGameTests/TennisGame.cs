using System;
using System.Collections.Generic;

namespace Givemin5.TennisGameTests
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        private Dictionary<int, string> scoreLookup = new Dictionary<int, string>
            {
                {0,"Love" },
                {1,"Fifteen" },
                {2,"Thirty" },
                {3,"Forty" },
            };

        private string _secondPlayerName;
        private string _firstPlayerName;

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public string Score()
        {
            if (IsScoreDifferent())
            {
                if (IsReadyForWin())
                {
                    var advPlayer = AdvPlayer();
                    if (IsAdv())
                    {
                        return $"{advPlayer} Adv";
                    }

                    return $"{advPlayer} Win";
                }

                return $"{scoreLookup[_firstPlayerScoreTimes]} {scoreLookup[_secondPlayerScoreTimes]}";
            }
            if (IsDeuce())
            {
                return "Deuce";
            }
            return $"{scoreLookup[_firstPlayerScoreTimes]} All";
        }

        private bool IsScoreDifferent()
        {
            return _firstPlayerScoreTimes != _secondPlayerScoreTimes;
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes) == 1;
        }

        private bool IsReadyForWin()
        {
            return _firstPlayerScoreTimes > 3 || _secondPlayerScoreTimes > 3;
        }

        private bool IsDeuce()
        {
            return _firstPlayerScoreTimes >= 3;
        }

        private string AdvPlayer()
        {
            var advPlayer = _firstPlayerScoreTimes > _secondPlayerScoreTimes
                ? _firstPlayerName
                : _secondPlayerName;
            return advPlayer;
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