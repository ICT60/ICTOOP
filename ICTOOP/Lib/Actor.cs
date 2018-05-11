using System;

namespace ICTOOP.Lib
{
    abstract class Actor : GameObject, IAttackAble<Actor>, IDamageAble<float>
    {
        public uint Level { get; set; }

        public Status HealthStat { get; set; }
        public Status AttackStat { get; set; }
        public Status DefenseStat { get; set; }


        public Actor() : base()
        {
            HealthStat = new Status(0, 0);
            AttackStat = new Status(0, 0);
            DefenseStat = new Status(0, 0);
        }

        public Actor(string name) : base(name)
        {
            HealthStat = new Status(0, 0);
            AttackStat = new Status(0, 0);
            DefenseStat = new Status(0, 0);
        }

        public Actor(string name, float health, float maxHealth) : base(name)
        {
            HealthStat = new Status(health, maxHealth);
            AttackStat = new Status(0, 0);
            DefenseStat = new Status(0, 0);
        }

        public void LevelUp()
        {
            Level += 1;
        }

        public virtual void Attack(Actor actor)
        {
            string format = "{0} is attacking [ {1} ].";
            Console.WriteLine(string.Format(format, Name, actor.Name));
            actor.ReceiveDamage(AttackStat.Current);
        }

        public void ReceiveDamage(float value)
        {
            if (value < DefenseStat.Current) { return; }
            HealthStat.Remove(value - DefenseStat.Current);

            if (HealthStat.IsEmpty)
            {
                GameController.GameOver();
            }
        }

        public override string ToString()
        {
            string format = @"{0} : 
                               Health : {1}
                                Attack : {2}
                                Defense : {3}";

            return string.Format(
                format, 
                Name, 
                HealthStat.Current,
                AttackStat.Current,
                DefenseStat.Current
            );
        }
    }
}
