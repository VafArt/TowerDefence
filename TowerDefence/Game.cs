using SolutionItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TowerDefence.Attackers;

namespace TowerDefence
{
    public class Game : IGame
    {
        public List<Line> Line { get; set; }

        private List<Attacker> Attackers { get; set; }

        private int _lineCount = 3;

        public int Money { get; private set; }

        public Game(int formWidth)
        {
            Line = new List<Line>();

            for(int i = 0; i < _lineCount; i++)
                Line.Add(new Line());

            Type attackerType = typeof(Attacker);

            var attackers = Assembly.GetAssembly(attackerType).GetTypes().Where(type=>type.IsSubclassOf(attackerType));

            Attackers = new List<Attacker>();

            foreach(var attacker in attackers)
            {
                Attackers.Add((Attacker)Activator.CreateInstance(attacker, formWidth));
            }
        }

        public void InitAttackers(int lvl)
        {
            while(lvl != 0)
            {

            }
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}
