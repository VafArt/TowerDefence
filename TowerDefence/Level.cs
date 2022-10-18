using SolutionItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    public class Level : ILevel
    {
        public List<Line> Lines { get; set; }

        public int PlayersMoney { get; set; }

        public int LevelNumber { get; set; }
    }
}
