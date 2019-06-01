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

        private Dictionary<int, string> scoreLookup = new Dictionary<int, string>
            {
                {0,"Love" },
                {1,"Fifteen" },
                {2,"Thirty" },
                {3,"Forty" },
            };

        public string Score()
        {
            if (_firstPlayerScore != _secondPlayerScore)
            {
                if (IsReadyForWin())
                {
                    string advPlayer = AdvPlayer();
                    if (IsAdv())
                    {
                        return $"{advPlayer} Adv";
                    }
                    return $"{advPlayer} Win";
                }

                return $"{scoreLookup[_firstPlayerScore]} {scoreLookup[_secondPlayerScore]}";
            }
            if (IsDeuce())
            {
                return "Deuce";
            }
            return $"{scoreLookup[_firstPlayerScore]} All";
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1;
        }

        private bool IsReadyForWin()
        {
            return _firstPlayerScore > 3 || _secondPlayerScore > 3;
        }

        private string AdvPlayer()
        {
            string advPlayer = _firstPlayerScore > _secondPlayerScore ? _firstPlayerName : _secondPlayerName;
            return advPlayer;
        }

        private bool IsDeuce()
        {
            return _firstPlayerScore >= 3;
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