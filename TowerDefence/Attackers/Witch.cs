using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Attackers
{
    public class Witch : Attacker
    {
        public Witch(int formWidth)
            : base(formWidth)
        {
            HealthPoints = 400;
        }
    }
}
