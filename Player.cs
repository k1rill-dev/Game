using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;

namespace Game
{
    internal class Player : ISetting
    {
        public string Name { get; set; } = null!;
        public int Hp { get; set; } = 100;
        public int Strengh { get; set; } = 30;
        
        public List<string> Inventory = new List<string>();
        public int Money { get; set; } = 10000;
        public Enemy enemy { get; set; } = null!;
        int ISetting.Damage { get; set; } = 5;
        public string SayHello() => $"Твое имя - {Name}";
        public void Death() => Console.WriteLine("Ты умер");
        public void GetDamage(int damage)
        {
            Hp -= damage;
        }

    }
}
