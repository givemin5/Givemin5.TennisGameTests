using System;
using System.Collections.Generic;

namespace Givemin5.TennisGameTests
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;

        public String Score()
        {
            Dictionary<int, string> scoreLookup = new Dictionary<int, string>
            {
                {1,"Fifteen" },
                {2,"Thirty" },
                {3,"Forty" },
            };
            if (_firstPlayerScoreTimes >= 1)
            {
                return $"{scoreLookup[_firstPlayerScoreTimes]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            throw new NotImplementedException();
        }
    }
}