using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Defenders
{
    public class PistolMan : Defender
    {
        public PistolMan()
        {
            DamagePerSecond = 200;
            Cost = 300;
        }
    }
}
