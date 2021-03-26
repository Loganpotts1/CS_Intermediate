using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection
{
    class Enemy
    {
        // Instead of Inheriting or Composing the killMove object, the class creates a Dependency for an Interface, allowing any object with that interface to be used
        private readonly IKillMove _killMove;

        public Enemy(IKillMove killMove)
        {
            _killMove = killMove;
        }

        public void Attack(int health)
        {
            int newHealth = health - 50;

            if (newHealth <= 0)
            {
                _killMove.Finisher();
            }
        }
    }
}
