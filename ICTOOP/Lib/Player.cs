namespace ICTOOP.Lib
{
    class Player : Hero, IControlable 
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
            //implement input handling here..
        }
    }
}
