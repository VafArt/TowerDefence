using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefence.Defenders;

namespace TowerDefence.Factories
{
    public class PistolManFactory : DefenderFactory
    {
        public override Defender Create()
        {
            return new PistolMan();
        }
    }
}
