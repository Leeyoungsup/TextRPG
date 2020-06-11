﻿using System;

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
        static void Main(string[] args)
        {
            while(true)
            {
                ClassType Choice = Program.ChooseClass();
                if(Choice!=ClassType.None)
                {
                    break;
                }
            }
            
            
        }
    }
}
