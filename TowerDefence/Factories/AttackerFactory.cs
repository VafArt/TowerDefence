using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefence.Attackers;

namespace TowerDefence.Factories
{
    public abstract class AttackerFactory
    {
        public abstract Attacker Create(int formWidth);
    }
}
