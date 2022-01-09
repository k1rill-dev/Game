using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    // Пример родительского класса нпс, который является общим прародителем для таких классов, как тороговец.
    internal class NPC
    {
        public string Name { get; set; }
        public int NPCMoney { get; set; }
        public int Hp { get; set; }

        public virtual void SayHi()
        {
            Console.WriteLine($"Приветствую тебя путник! Мое имя - {Name}");
        }
    }
}
