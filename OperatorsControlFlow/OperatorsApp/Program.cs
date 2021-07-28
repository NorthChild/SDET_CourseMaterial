using System;

namespace OperatorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //int y = 5;

            //int a = x++;
            //int b = ++y;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //for (int i = 0; i <= 5; i++) {

            //    Console.WriteLine(i);
            //}

            //var c = 5 / 2;
            //var d = 5.0 / 2;
            //var e = 5 / 3;

            //double f = 5 / 2;

            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine(f);


            var daysInAWeek = 7;
            var totalDaysToBirthday = 23;
            var weeksToBirthday = totalDaysToBirthday / daysInAWeek;
            var days = totalDaysToBirthday % daysInAWeek;

            var res = EvenOdd(23);
            Console.WriteLine(res);
        }

        public static bool EvenOdd(int num) {

            return num % 2 == 0;
        }



    }
}
