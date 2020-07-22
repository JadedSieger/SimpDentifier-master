using SimpDentiier_1._2.Information;
using System;

namespace SimpDentifier_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Thank you for taking the SimpDentifier Test!");
            Console.WriteLine("Rules\n10 for yes,\n5 for maybe,\n0 for no");
            Console.ReadLine();
           


            int r, q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, t;
            float p;
            string n;
            Console.Write("Enter Testee Number: ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Have you ever ditched plans for a girl/boy?: ");
            q1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("do you usually discuss relationships with girls/boys?: ");
            q2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Do You Hate Your Opposite Gender?: ");
            q3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your Favorite Youtuber Has Channel Memberships on for a dollar, Will you pay for it?: ");
            q4 = Convert.ToInt32(Console.ReadLine());
           Console.Write("Your friend who you have secret feelings for asked you a favor to treat her some Ice Cream,will you pay for it?: ");
            q5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Will you do anything for a best Friend?: ");
            q6 = Convert.ToInt32(Console.ReadLine());
            Console.Write("A boy/girl your age walks up to you and introduces oneself. Will you do the same?: ");
            q7 = Convert.ToInt32(Console.ReadLine());
            Console.Write("You saw (A Pregnant Woman/Old Man) standing on the bus, will you come to your senses, Give your chair up and be the good guy?: ");
            q8 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give Me a Number not exceceding 10: ");
            q9 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Now think of a number between Odd numbers.(still not exceeding 10): ");
            q10 = Convert.ToInt32(Console.ReadLine());
            t = q1 + q2 + q3 + q4 + q5 + q6 + q7 + q8 + q9 + q10 ;
            p = t / 1.0f;
            Console.WriteLine("Total: " + t);
            Console.WriteLine("Simpness Percentage: " + p + "%");
            Console.WriteLine(" ");


            if (p < 30 && p < 40)
            {
                Console.WriteLine("You are a Chad");
            }
            else
            {

            }
            if (p >= 30 && p < 30)
            {
                Console.WriteLine("You have a Low Level of Simp-idity");

            }
            else
            {


            }
            if (p >= 50 && p <= 50)
            {
                Console.WriteLine("You are at the Midline of Simp and Chad-ness, How did you manage to do that.");

            }
            else
            {
                
            }
            if (p >= 60 && p <=70)
            {
                Console.WriteLine("Holy Shit you took Simping to the next level, Still a decentlevel of Simping tho.");
            }
            else
            {
                
            }
            if (p >= 80 && p <= 100)
            {
                Console.WriteLine("Shit! My predictions were correct, you did Tier Three sub. Now That's Bravery");
            }
            else
            {

            }
            Console.WriteLine(" ");
            Console.WriteLine("Thank You For Taking the SimpDentifier Test");
            Console.WriteLine(" ");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
