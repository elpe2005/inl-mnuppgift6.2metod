using System;

namespace uppgift6
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Störst(25,32));
        }
        static int Störst(int tal1,int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else if (tal1 == tal2)
            {
                return tal1 + tal2;
            }
            else
            {
                return tal2;
            }
        }
    }
}