using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Defenders
{
    public class MinigunOrk : Defender
    {
        public MinigunOrk()
        {
            Damage = 800;
            Cost = 1200;
            Image = Properties.Resources._3_lvl_tower;
            WidthScale = 0.25;
            HeightScale = 0.27;
        }
    }
}
