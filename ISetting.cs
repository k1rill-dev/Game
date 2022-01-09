using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal interface ISetting
    {
        // не знаю зачем, не знаю почему здесь интерфейс. Но как говорится, работает - не трожь
        string Name { get; set; }
        int Hp { get; set; }
        int Damage { get; set; }
        void Death();
        string SayHello();

        void GetDamage(int damage)
        {
            Hp -= damage;
        }
    }
}
