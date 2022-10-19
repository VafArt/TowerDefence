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
            Damage = 200;
            Cost = 300;
            Image = Properties.Resources._1_lvl_tower;
            WidthScale = 0.08;
            HeightScale = 0.21;
        }
    }
}
