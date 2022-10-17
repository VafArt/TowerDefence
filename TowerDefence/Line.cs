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
        public List<Attacker> Attackers { get; set; } = new List<Attacker>();

        public List<Defender> Defenders { get; set; } = new List<Defender>();

        private int _amountHealthPoints;
        public int AmountHealthPoints 
        {
            get
            {
                _amountHealthPoints = 0;
                foreach (Attacker attacker in Attackers)
                    _amountHealthPoints += attacker.HealthPoints;
                return _amountHealthPoints;
            }
            private set
            {
                _amountHealthPoints = value;
            }
        }
    }
}
