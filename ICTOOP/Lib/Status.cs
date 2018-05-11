namespace ICTOOP.Lib
{
    class Status
    {
        float _maximum;
        float _current;

        public float Maximum => _maximum;
        public float Current => _current;

        public bool IsEmpty => _current <= 0;


        public Status(float current, float maximum)
        {
            _current = current;
            _maximum = maximum;
        }

        public void Clear()
        {
            _current = 0;
        }

        public void FullRestore()
        {
            _current = _maximum;
        }

        public void Restore(float value)
        {
            _current = (_current + value) > _maximum ? _maximum : (_current + value);
        }

        public void Remove(float value)
        {
            _current = (_current - value) < 0 ? 0 : (_current - value);
        }
    }
}
