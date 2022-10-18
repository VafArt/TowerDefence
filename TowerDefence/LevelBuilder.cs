using SolutionItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TowerDefence.Attackers;
using TowerDefence.Builders;

namespace TowerDefence
{
    public class LevelBuilder : ILevelBuilder
    {
        private List<Line> _lines;

        private List<Attacker> _attackers;

        private int _lineCount = 3;

        private int _money; //сюда записать минимальное количество денег которое дается пользователю

        private int _levelNumber;

        public LevelBuilder(int formWidth, int levelNumber)
        {
            _levelNumber = levelNumber;

            _lines = new List<Line>();
            for (int i = 0; i < _lineCount; i++)
                _lines.Add(new Line());

            Type attackerType = typeof(Attacker);

            var attackers = Assembly.GetAssembly(attackerType).GetTypes().Where(type => type.IsSubclassOf(attackerType));

            _attackers = new List<Attacker>();

            foreach (var attacker in attackers)
            {
                _attackers.Add((Attacker)Activator.CreateInstance(attacker, formWidth));
            }
        }

        public ILevelBuilder AddAttackers()
        {
            int lvl = _levelNumber;
            Queue<Attacker> _attackersQueue = new Queue<Attacker>();
            Random _random = new Random();
            while (lvl != 0)
            {
                var attackerNumber = _random.Next(0, _attackers.Count);
                if (_attackers[attackerNumber].Cost > lvl)
                    continue;

                _attackersQueue.Enqueue(_attackers[attackerNumber]);
                lvl -= _attackers[attackerNumber].Cost;
            }
            while (_attackersQueue.Count != 0)
            {
                var lineNumber = _random.Next(0, _lines.Count);
                _lines[lineNumber].Attackers.Add(_attackersQueue.Dequeue());
            }

            return this;
        }

        public ILevel Build()
        {
            var result = new Level();
            result.LevelNumber = _levelNumber;
            // реализовать подсчет минимального количества денег игрока result.PlayersMoney = _money;
            result.Lines = _lines;

            return result;
        }
    }
}
