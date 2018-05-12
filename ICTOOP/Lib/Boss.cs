namespace ICTOOP.Lib
{
    class Boss : Monster
    {
        public bool IsImmortal { get; set; }


        public override void ReceiveDamage(float value)
        {
            if (IsImmortal)
            {
                return;
            }
            else
            {
                base.ReceiveDamage(value);
            }
        }
    }
}
