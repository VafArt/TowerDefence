using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Defenders
{
    public class PlasmaGunMan : Defender
    {
        public PlasmaGunMan()
        {
            DamagePerSecond = 400;
            Cost = 600;
        }
    }
}
