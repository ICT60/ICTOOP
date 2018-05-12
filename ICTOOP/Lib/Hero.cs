namespace ICTOOP.Lib
{
    abstract class Hero : Actor, IImprovable
    {
        public uint Level { get; set; }


        public Hero() : base()
        {

        }

        public Hero(string name) : base(name)
        {

        }

        public Hero(string name, float health, float maxHealth) : base(name, health, maxHealth)
        {

        }

        public void LevelUp()
        {
            Level += 1;
        }
    }
}
