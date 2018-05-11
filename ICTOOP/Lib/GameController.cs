namespace ICTOOP.Lib
{
    class GameController
    {
        public delegate void Func();

        public static event Func OnGameStart;
        public static event Func OnGameOver;

        public static bool IsGameStart { get { return isGameStart; } private set => isGameStart = value; }


        static bool isGameStart;


        static void FireEvent_OnGameStart()
        {
            OnGameStart?.Invoke();
        }

        static void FireEvent_OnGameOver()
        {
            OnGameOver?.Invoke();
        }

        public static void GameStart()
        {
            if (isGameStart) { return;  }
            isGameStart = true;
            FireEvent_OnGameStart();
        }

        public static void GameOver()
        {
            if (!isGameStart) { return; }
            isGameStart = false;
            FireEvent_OnGameOver();
        }
    }
}
