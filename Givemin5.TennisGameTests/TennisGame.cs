﻿using System;
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

        private string _firstPlayerName;
        private string _secondPlayerName;

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public string Score()
        {
            if (_firstPlayerScoreTimes != _secondPlayerScoreTimes)
            {
                if (_firstPlayerScoreTimes > 3 || _secondPlayerScoreTimes > 3)
                {
                    if (Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes) == 1)
                    {
                        var advPlayer = _firstPlayerScoreTimes > _secondPlayerScoreTimes
                            ? _firstPlayerName
                            : _secondPlayerName;
                        return $"{advPlayer} Adv";
                    }
                }

                return $"{scoreLookup[_firstPlayerScoreTimes]} {scoreLookup[_secondPlayerScoreTimes]}";
            }
            if (_firstPlayerScoreTimes >= 3)
            {
                return "Deuce";
            }
            return $"{scoreLookup[_firstPlayerScoreTimes]} All";
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