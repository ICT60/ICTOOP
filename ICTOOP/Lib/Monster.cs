using System;

namespace ICTOOP.Lib
{
    abstract class Monster : Actor, IImprovable, IBotBehaviour
    {
        public uint Level { get; set; }


        public Monster() : base()
        {

        }

        public Monster(string name) : base(name)
        {

        }

        public Monster(string name, float health, float maxHealth) : base(name, health, maxHealth)
        {

        }

        public void LevelUp()
        {
            Level += 1;
        }

        public virtual void AttackNearbyEnemy()
        {
            Console.WriteLine(Name + " about to attack a nearby enemy..");
        }

        public virtual void AvoidHit()
        {
            Console.WriteLine(Name + " about to avoid a hit..");
        }

        public virtual void AvoidObstacle()
        {
            Console.WriteLine(Name + " about to avoid an obstacl..");
        }

        public virtual void MoveToTarget()
        {
            Console.WriteLine(Name + " about to move to target..");
        }
    }
}
