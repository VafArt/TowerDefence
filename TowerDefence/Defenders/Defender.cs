using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Defenders
{
    public abstract class Defender
    {
        public int DamagePerSecond { get; protected set; }

        public int Cost { get; protected set; }
    }
}
