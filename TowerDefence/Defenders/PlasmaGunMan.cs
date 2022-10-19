using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefence.Properties;

namespace TowerDefence.Defenders
{
    public class PlasmaGunMan : Defender
    {
        public PlasmaGunMan()
        {
            Damage = 400;
            Cost = 600;
            Image = Properties.Resources._2_lvl_tower;
            WidthScale = 0.27;
            HeightScale = 0.18;
        }
    }
}
