using System;

namespace TheObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bk = new Book();
            Object ck = bk;

            Diary dy = new Diary(38);
            Object ey = dy;

            int i = 9;
            Object h = i;


        }
    }
}
