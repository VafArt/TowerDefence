using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Attackers
{
    public class Zombie : Attacker
    {
        public Zombie(int formWidth)
            : base(formWidth)
        {
            HealthPoints = 200;
            Cost = 1;
        }
    }
}
