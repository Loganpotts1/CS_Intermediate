using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection
{
    class KillMove_Fireball : IKillMove
    {
        public void Finisher()
        {
            Console.WriteLine("Fireball!!");
        }
    }
}
