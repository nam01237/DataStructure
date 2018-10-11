using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    public class Platform
    {
        private string _name;
        private ScoreBoard _scoreBoard;

        public Platform(string name, ScoreBoard scoreBoard)
        {
            _name = name;
            _scoreBoard = scoreBoard;
            scoreBoard.Add(this);
        }

        public void Update()
        {
            Console.WriteLine($"{_name} / {_scoreBoard.GetState()}");
        }
    }
}
