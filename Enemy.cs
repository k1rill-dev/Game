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


        public int Hp { get; set; }

        public void Death() => Console.WriteLine("Ti ubil monstra");

        public string SayHello() => $"Klass monstra - {Name}";

        public int 
        
    }
}
