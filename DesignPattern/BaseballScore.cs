using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    public class BaseballScore : ScoreBoard
    {
        private int _away;
        public int AwayScore
        {
            set
            {
                _away = value;
                Notify();
            }
        }
        int _home;
        public int HomeScore
        {
            set
            {
                _home = value;
                Notify();
            }
        }

        public override string GetState()
        {
            return $"홈팀 : {_away} / 어웨이팀 : {_home}";
        }
    }
}
