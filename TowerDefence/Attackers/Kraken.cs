using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Attackers
{
    public class Kraken : Attacker
    {
        public Kraken(int formWidth)
            : base(formWidth)
        {
            HealthPoints = 1600;
            Cost = 4;
        }
    }
}
