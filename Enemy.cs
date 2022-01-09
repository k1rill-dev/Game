using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Enemy : ISetting
    {
        public string Name { get; set; }

        public Player Player { get; set; }

        public int Hp { get; set; } = 100;

        public int Damage { get; set; } = 10;

        public void Death() => Console.WriteLine("Ti ubil monstra");

        public string SayHello() => $"Klass monstra - {Name}";

        public void GetDamage(int damage)
        {
            Hp -= damage;
        }

    }
}
