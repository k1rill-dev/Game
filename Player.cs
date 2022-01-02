using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Player : ISetting
    {
        public string Name { get; set; }
        public int Hp { get; set; } = 100;

        public Enemy Enemy { get; set; }

        public string SayHello() => $"Твое имя - {Name}";
        public void Death() => Console.WriteLine("Ti sdoh popusk ebany");
    
    }
}
