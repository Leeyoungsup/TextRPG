using System;
using System.Data;

namespace Debuging
{
    //메소드 호출 =>Inception
    //현실 -> 1차꿈 ->2차꿈
    class Program
    {
        static void Print(int value)
        {
            Console.WriteLine(value);
        }
        static int AddAndPrint(int a,int b)
        {
            int ret = a + b;
            Print(ret);
            return ret;
        }
        static void Main(string[] args)
        {
            Program.AddAndPrint(10, 20);
            Program.AddAndPrint(9, 20);
            Program.AddAndPrint(8, 20);
            Program.AddAndPrint(7, 20);
            Program.AddAndPrint(6, 20);

        }
    }
}
