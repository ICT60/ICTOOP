namespace ICTOOP.Lib
{
    interface IBotBehaviour
    {
        void AttackNearbyEnemy();
        void AvoidObstacle();
        void AvoidHit();
        void MoveToTarget();
    }
}
