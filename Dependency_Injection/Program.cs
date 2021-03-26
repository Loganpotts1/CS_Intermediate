using System;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy wizard = new Enemy(new KillMove_Fireball());
            wizard.Attack(40);

            Enemy ogre = new Enemy(new KillMove_Smash());
            ogre.Attack(30);
        }
    }
}
