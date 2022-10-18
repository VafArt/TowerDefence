using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Builders
{
    public interface IGameBuilder
    {
        public IGameBuilder AddAttackers(int lvl);

        public IGame Build();
    }
}
