using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Attackers
{
    public abstract class Attacker
    {
        public int HealthPoints { get; protected set; }

        public int Speed { get; set; }

        public int Cost { get; protected set; }

        public int Width { get; protected set; }

        public int Height { get; protected set; }

        public Bitmap Image { get; protected set; }

        public Attacker(int formWidth)
        {
            Speed = formWidth / 10;
        }
    }
}
