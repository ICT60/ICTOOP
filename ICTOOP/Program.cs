using System;
using ICTOOP.Lib;

namespace ICTOOP
{
    class Program
    {
        Player player;
        Boss boss;


        static void Main(string[] args)
        {
            new Program().Run();
        }

        void Initialize()
        {
            SubscribeEvent();

            player = new Player();

            player.Name = "Player";
            player.HealthStat = new Status(100, 100);
            player.AttackStat = new Status(50, 50);
            player.DefenseStat = new Status(30, 30);


            boss = new Boss();

            boss.Name = "Boss";
            boss.HealthStat = new Status(40, 40);
            boss.AttackStat = new Status(100, 100);
            boss.DefenseStat = new Status(30, 30);

            boss.IsImmortal = true;
        }

        void Run()
        {
            Initialize();
            GameController.GameStart();

            AttackPhrase_1();
            AttackPhrase_2();
            AttackPhrase_3();

            Console.ReadLine();
        }

        void AttackPhrase_1()
        {
            Console.WriteLine("Attack phase : 1");
            player.Attack(boss);
            ShowCurrentGameInfo();
        }

        void AttackPhrase_2()
        {
            Console.WriteLine("Attack phase : 2");
            boss.Attack(player);
            ShowCurrentGameInfo();
        }

        void AttackPhrase_3()
        {
            Console.WriteLine("Attack phase : 3");
            player.Attack(boss);
            ShowCurrentGameInfo();
        }

        void ShowCurrentGameInfo()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Stat : ");
            Console.WriteLine(player.ToString());
            Console.WriteLine(boss.ToString());
        }

        void OnGameStart()
        {
            Console.WriteLine("Game is start.");
            Console.WriteLine("Stat on start..");

            ShowCurrentGameInfo();
        }

        void OnGameOver()
        {
            Console.WriteLine("Game is over...");
        }

        void SubscribeEvent()
        {
            GameController.OnGameStart += OnGameStart;
            GameController.OnGameOver += OnGameOver;
        }

        void UnsubscribeEvent()
        {
            GameController.OnGameStart -= OnGameStart;
            GameController.OnGameOver -= OnGameOver;
        }

        ~Program()
        {
            UnsubscribeEvent();
        }
    }
}
