using System;
using System.Collections.Generic;
using OperatorsApp;

namespace OperatorsApp
{
    public class Program
    {
        public static void PrimaryMain(string[] args)
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


            //var daysInAWeek = 7;
            //var totalDaysToBirthday = 23;
            //var weeksToBirthday = totalDaysToBirthday / daysInAWeek;
            //var days = totalDaysToBirthday % daysInAWeek;

            //var res = EvenOdd(23);
            //Console.WriteLine(res);

            const int NUM_ROWS = 2;
            const int NUM_COLS = 5;
            bool running = true;
            int row = 0;
            int col = 0;
            int spriteNo = -1;


            //while (running)
            //{
            //    spriteNo = ++spriteNo % (NUM_ROWS * NUM_COLS);
            //    row = spriteNo / NUM_COLS;
            //    col = spriteNo / NUM_COLS;

            //}

            //List<int> nums = new List<int> { 10, 6, 22, -17, 3 };
            List<int> nums = new List<int> { -10, -6, -22, -17, -3 };


            //Console.WriteLine("Highest foreach loop: " + LoopTypes.HighestForEachLoop(nums));
            //Console.WriteLine("Highest for loop: " + LoopTypes.HighestForLoop(nums));
            //Console.WriteLine("Highest while loop: " + LoopTypes.HighestWhileLoop(nums));
            //Console.WriteLine("Highest do-while loop: " + LoopTypes.HighestDoWhileLoop(nums));

            // operators and expressions
            //int x = < expression >
            //x < operator > = < expression > 
            //x = x < operator >< expression >

            // in code
            //int x = x + 3;
            //int x2 += 3;

            // giving precedence by using (), relying on order of operation
            //spriteNo %= NUM_ROWS * NUM_COLS;
            //spriteNo %= (NUM_ROWS * NUM_COLS);

            bool isWearingParachute = false;

            //if (isWearingParachute && JumpOutOfPlane()) 
            //{
            //    Console.WriteLine("Congratulation, you are flying");
            //}


            //string greeting = "All Right?";

            //if (greeting != null & greeting.ToLower().StartsWith('a')) 
            //{
            //    Console.WriteLine(greeting + " starts with 'a'");
            //}


            // ternary operator
            int mark = 72;
            var grade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";

            //Console.WriteLine(grade);


            //Console.WriteLine(Stones.GetStones(156));
            //Console.WriteLine(Stones.GetPounds(156));

            //Console.WriteLine(Stones.Grade(72));


            var message = Priority(2);
            Console.WriteLine(message);
            Console.WriteLine(Priority(0));
        
        
        
        }


        //public static bool EvenOdd(int num) {

        //    return num % 2 == 0;

        //}

        public static string Grade(int mark)
        {
            return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        }


        // in a switch statement if you leave out a break from a case, it will automatically drop to 
        // the lower case that has a break statement
        public static string Priority(int level)
        {
            string priority = "Code ";

            switch (level)
            {
                case 3:
                    priority = priority + "Red";
                    break;
                case 2:
                    //priority = priority + "Orange";
                    //break;
                case 1:
                    priority = priority + "Amber";
                    break;
                case 0:
                    priority = priority + "Green";
                    break;
                default:
                    priority = "Error";
                    break;
            }
            return priority;
        
        }



    }
}
