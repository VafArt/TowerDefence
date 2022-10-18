using SolutionItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    public interface ILevel
    {
        public List<Line> Lines { get; set; }

        public int PlayersMoney { get; protected set; }

        private static int _amountHealthPoints;
        public int AmountHealthPoints
        {
            get
            {
                _amountHealthPoints = 0;
                foreach (var line in Lines)
                    _amountHealthPoints += line.AmountHealthPoints;
                return _amountHealthPoints;
            }
            protected set
            {
                _amountHealthPoints = value;
            }
        }

        public int LevelNumber { get; protected set; }
    }
}
