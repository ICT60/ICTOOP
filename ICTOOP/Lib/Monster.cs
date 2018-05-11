using System;

namespace ICTOOP.Lib
{
    class Monster : Actor, IBotBehaviour
    {
        public Monster() : base()
        {

        }

        public Monster(string name) : base(name)
        {

        }

        public Monster(string name, float health, float maxHealth) : base(name, health, maxHealth)
        {

        }

        public void AttackNearbyEnemy()
        {
            Console.WriteLine(Name + " about to attack a nearby enemy..");
        }

        public void AvoidHit()
        {
            Console.WriteLine(Name + " about to avoid a hit..");
        }

        public void AvoidObstacle()
        {
            Console.WriteLine(Name + " about to avoid an obstacl..");
        }

        public void MoveToTarget()
        {
            Console.WriteLine(Name + " about to move to target..");
        }
    }
}
