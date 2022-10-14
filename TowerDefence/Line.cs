using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefence.Attackers;
using TowerDefence.Defenders;

namespace SolutionItems
{
    public class Line
    {
        public List<Attacker> Attackers { get; set; }

        public List<Defender> Defenders { get; set; }
    }
}
