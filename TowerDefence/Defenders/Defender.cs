using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Defenders
{
    public abstract class Defender
    {
        public int Damage { get; protected set; }

        public int RateOfFire { get; protected set; } = 1;

        public int Cost { get; protected set; }
    }
}
