using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal interface ISetting
    {
        string Name { get; }
        int Hp { get; }
        void Death();
        string SayHello();
    }
}
