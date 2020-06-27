using System;

namespace TextRPG_Battle
{
    class Program
    {
       
        struct Player
        {
            public int hp;
            public int attack;

        }
        enum MonsterType
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3
        }
        struct Monster
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
        static void CreatePlayer(ClassType Choice, out Player player)
        {
            player.hp = 0;
            player.attack = 0;
            if (Choice == ClassType.Knight)
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
        static void CreateRandomMonster(out Monster monster)
        {
            Random rand = new Random();
            int randMonster = rand.Next(1, 4);
            if (randMonster == (int)MonsterType.Orc)
            {
                Console.WriteLine("오크가 소환되었습니다.");
                monster.hp = 40;
                monster.attack = 4;
            }
            else if (randMonster == (int)MonsterType.Skeleton)
            {
                Console.WriteLine("스켈레톤이 소환되었습니다.");
                monster.hp = 30;
                monster.attack = 3;
            }
            else if (randMonster == (int)MonsterType.Slime)
            {
                Console.WriteLine("슬라임이 소환되었습니다.");
                monster.hp = 20;
                monster.attack = 2;
            }
            else
            {
                monster.hp = 0;
                monster.attack = 0;
            }
        }
        static void Fight(ref Player player,ref Monster monster)
        {
            while(true)
            {
                monster.hp -= player.attack;
                if(monster.hp<=0)
                {
                    Console.WriteLine("승리했습니다");
                    Console.WriteLine($"남은체력:{player.hp}");
                    break;
                }
                player.hp -= monster.attack;
                if(player.hp<=0)
                {
                    Console.WriteLine("패배했습니다");
                    break;
                }
            }
        }
        static void EnterField(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("필드에 접속했습니다!");

                //랜덤으로 1~3몬스터 중 하나를 리스폰
                Monster monster;
                CreateRandomMonster(out monster);
                Console.WriteLine("[1] 전투모드로 돌입");
                Console.WriteLine("[2] 일정 확률로 도망");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Fight(ref player, ref monster);
                }
                else if (input == "2")
                {
                    Random rand = new Random();
                    int randValue=rand.Next(0, 101);
                    if (randValue <= 33)
                    {
                        Console.WriteLine("도망치는데 성공했습니다");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("잘못입력하셨습니다");
                }
            }
            

        }
        static void EnterGame(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("마을에 접속하였습니다.");
                Console.WriteLine("[1] 필드로 간다.");
                Console.WriteLine("[2] 로비로 돌아가기");
                String input = Console.ReadLine();
                if (input == "1")
                {
                    EnterField(ref player);

                }
                else if (input == "2")
                {
                    break;
                }
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
                    CreatePlayer(Choice, out player);
                    EnterGame(ref player);

                }
            }


        }
    }
}
