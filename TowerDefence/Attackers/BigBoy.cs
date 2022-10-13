using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Attackers
{
    public class BigBoy : Attacker
    {
        public BigBoy(int formWidth)
            : base(formWidth)
        {
            HealthPoints = 800;
        }
    }
}
