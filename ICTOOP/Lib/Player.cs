using System;

namespace ICTOOP.Lib
{
    class Player : Actor, IControlable 
    {
        public Player() : base()
        {

        }

        public Player(string name) : base(name)
        {

        }

        public Player(string name, float health, float maxHealth) : base(name, health, maxHealth)
        {

        }

        public void InputHandler()
        {

        }
    }
}
