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
        private Random _random = new Random();

        public List<Line> Lines { get; set; }

        private List<Attacker> _attackers;

        private Queue<Attacker> _attackersQueue = new Queue<Attacker>();

        private int _lineCount = 3;

        public int Money { get; private set; }

        private int _amountHealthPoints;
        public int AmountHealthPoints
        {
            get
            {
                _amountHealthPoints = 0;
                foreach (var line in Lines)
                    _amountHealthPoints+=line.AmountHealthPoints;
                return _amountHealthPoints;
            }
            private set
            {
                _amountHealthPoints = value;
            }
        }

        public Game(int formWidth)
        {
            Lines = new List<Line>();

            for(int i = 0; i < _lineCount; i++)
                Lines.Add(new Line());

            Type attackerType = typeof(Attacker);

            var attackers = Assembly.GetAssembly(attackerType).GetTypes().Where(type=>type.IsSubclassOf(attackerType));

            _attackers = new List<Attacker>();

            foreach(var attacker in attackers)
            {
                _attackers.Add((Attacker)Activator.CreateInstance(attacker, formWidth));
            }
        }

        public void InitAttackers(int lvl)
        {
            while(lvl != 0)
            {
                var attackerNumber = _random.Next(0, _attackers.Count);
                if (_attackers[attackerNumber].Cost > lvl)
                    continue;

                _attackersQueue.Enqueue(_attackers[attackerNumber]);
                lvl -= _attackers[attackerNumber].Cost;
            }
            while(_attackersQueue.Count != 0)
            {
                var lineNumber = _random.Next(0, Lines.Count);
                Lines[lineNumber].Attackers.Add(_attackersQueue.Dequeue());
            }
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}
