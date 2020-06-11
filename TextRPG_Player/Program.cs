using System;

namespace TextRPG_Player
{
    class Program
    {
        struct Player
        {
            public int hp;
            public int attack;
            
        }
        enum ClassType
        {
            Knight = 1,
            None = 0,
            Archer = 2,
            Mage = 3


        }
        static ClassType ChooseClass()
        {
            ClassType Choice = ClassType.None;
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Choice = ClassType.Knight;
                Console.WriteLine("기사를 선택하셨습니다.");

            }
            else if (input == "2")
            {
                Choice = ClassType.Archer;
                Console.WriteLine("궁수를 선택하셨습니다.");

            }
            else if (input == "3")
            {
                Choice = ClassType.Mage;
                Console.WriteLine("법사를 선택하셨습니다.");

            }
            else
            {
                Console.WriteLine("잘못 입력하셨습니다.");

            }
            return Choice;
        }
        static void CreatePlayer(ClassType Choice,out Player player)
        {
            player.hp = 0;
            player.attack = 0;
            if (Choice==ClassType.Knight)
            {
                player.hp = 100;
                player.attack = 10;
            }
            else if (Choice == ClassType.Archer)
            {
                player.hp = 75;
                player.attack = 12;
            }
            else if (Choice == ClassType.Mage)
            {
                player.hp = 50;
                player.attack = 15;
            }

        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                ClassType Choice = Program.ChooseClass();
                if (Choice != ClassType.None)
                {
                    //캐릭터생성
                    Player player;
                    CreatePlayer(Choice,out player);
                    Console.WriteLine($"HP: {player.hp}    attack: {player.attack}");
                    //createPlayer
                    //기사(100/10) 궁수(75/12) 법사(50/15)
                    //필드로 가서 pve
                }
            }


        }
    }
}
