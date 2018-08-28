using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    public abstract class ScoreBoard
    {
        private List<Platform> _platforms;

        public ScoreBoard()
        {
            _platforms = new List<Platform>();
        }

        public void Add(Platform platform)
        {
            _platforms.Add(platform);
        }

        public void Remove(Platform platform)
        {
            _platforms.Remove(platform);
        }

        public void Notify()
        {
            foreach (var item in _platforms)
            {
                item.Update();
            }
        }

        public abstract string GetState();

    }
}
