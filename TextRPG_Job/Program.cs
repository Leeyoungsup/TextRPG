using System;

namespace TextRPG_Job
{
    class Program
    {
        
        enum ClassType
        {
            Knight = 1,
            None=0,
            Archer=2,
            Mage=3


        }
        static ClassType ChooseClass()
        {
            ClassType Choice1 = ClassType.None;
            while (true)
            {
                Console.WriteLine("직업을 선택하세요");
                Console.WriteLine("[1] 기사");
                Console.WriteLine("[2] 궁수");
                Console.WriteLine("[3] 법사");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Choice1 = ClassType.Knight;
                    Console.WriteLine("기사를 선택하셨습니다.");
                    break;
                }
                else if (input == "2")
                {
                    Choice1 = ClassType.Archer;
                    Console.WriteLine("궁수를 선택하셨습니다.");
                    break;
                }
                else if (input == "3")
                {
                    Choice1 = ClassType.Mage;
                    Console.WriteLine("법사를 선택하셨습니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("잘못 입력하셨습니다.");
                    continue;
                }
                
            }
            return Choice1;
        }
        static void Main(string[] args)
        {
            ClassType Choice = Program.ChooseClass();
            
        }
    }
}
