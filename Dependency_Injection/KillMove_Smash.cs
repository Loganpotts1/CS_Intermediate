using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection
{
    class KillMove_Smash : IKillMove
    {
        public void Finisher()
        {
            Console.WriteLine("Get SMASHED");
        }
    }
}
