using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefence.Attackers;

namespace TowerDefence.Factories
{
    public class KrakenFactory : AttackerFactory
    {
        public override Attacker Create(int formWidth)
        {
            return new Kraken(formWidth);
        }
    }
}
