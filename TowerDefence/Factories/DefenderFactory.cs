using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefence.Defenders;

namespace TowerDefence.Factories
{
    public abstract class DefenderFactory
    {
        public abstract Defender Create();
    }
}
