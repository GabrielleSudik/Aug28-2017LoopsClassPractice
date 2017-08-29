using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug28_2017LoopsClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //LOOPS. There are four kinds.

            //FOREACH LOOP
            //iterates over a collection. repeats through a set of things.

            string[] months = { "Jan", "Feb", "March", "Apr", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
            foreach(string month in months)  
            {
                Console.WriteLine(month);
                if (month == "Aug")
                {
                    Console.WriteLine("August is the best month!");
                }

                else
                {
                    Console.WriteLine("That's a decent month.");
                }
            }

            string[] musicians = { "U2", "Maroon 5", "Ed Sheeran", "Nas", "Jarryd" };
            foreach(string band in musicians)
            {
                Console.WriteLine(band);
            }

            //class exercises

            string[] faveFoods = new string[4];

            Console.WriteLine("What's one of four favorite foods?");
            faveFoods[0] = Console.ReadLine();

            Console.WriteLine("What's one of four favorite foods?");
            faveFoods[1] = Console.ReadLine();

            Console.WriteLine("What's one of four favorite foods?");
            faveFoods[2] = Console.ReadLine();

            Console.WriteLine("What's one of four favorite foods?");
            faveFoods[3] = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("\nYour favorite foods are:");
            foreach(string food in faveFoods)
            {
                Console.WriteLine(food);
            }

            Console.WriteLine("Yum!\n");

            int[] luckies = { 5, 10, 15, 40, 45, 50 };

            foreach (int number in luckies)
            {
                Console.WriteLine($"One of your lucky numbers is {number}!");
            }



        }
    }
}
