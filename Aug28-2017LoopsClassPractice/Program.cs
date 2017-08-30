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

            //another one

            int[] luckies = { 5, 10, 15, 40, 45, 50 };

            foreach (int number in luckies)
            {
                Console.WriteLine($"One of your lucky numbers is {number}!");
            }

            //and another... let's make these all lower case

            string[] names = { "Gabrielle", "Mike", "Jackie", "Holly" };

            /*foreach(string name in names)
            {
                //name = name.ToLower(); //that will give you an error message
                    //you can't use a variable identified in the foreach loop.
                    //so... we learn a new loop:
            } */

            //FOR LOOP

            for (int i = 0; i < names.Length; i++)  //initialize temp variable, condition, updater. fyi, i means iterator
            {
                names[i] = names[i].ToLower();
                Console.WriteLine(names[i]);
            }

            //for loops: you can tell them when to start and when to stop
            //you don't have to do a "complete" circuit

            //let's count to 10

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+1);
            }

            for (int i = 0; i < 10; i += 2) //will increase counter by 2 each time
            {
                Console.WriteLine(i+1);
            }

            for (int i = 50; i < 100; i++) //prints 51 to 100
            {
                Console.WriteLine(i + 1);
            }

            //for (int i = 0; i < 5000; i *= i)  //see if you can make a fancy counting thing
            //{
            //    Console.WriteLine();
            //}

            string words = "I like cake";

            foreach(char letter in words)
            {
                Console.WriteLine(letter);
            }


            //here's another one:

            string greetings = "My name is Gaby";
            string[] words2 = greetings.Split(); //Split

            for (int i = 0; i < words2.Length; i++)
            {
                Console.WriteLine(words2[i]);

                if(words2[i] == "Gaby") //this will change part of it...
                {
                    words2[i] = "Gabrielle";  //but it won't show up until after the for loop is all done
                }
            }

            Console.WriteLine(words2[words2.Length - 1]);

            //class practice:

            string[] months2 = { "Monday", "Tuesday", "Wednesday" };

            for (int i = 0; i < months2.Length; i++)
            {
                Console.WriteLine(months2[i]);
            }

            //next one:

            int[] numbers = new int[25];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i+1;
                Console.WriteLine($"Index is number is {i} and number is {numbers[i]}.");
            }

            Console.WriteLine($"{numbers[4]} and {numbers[11]} -- test line, should print 5 and 12.");

            //last one:
            //reverse the string

            string tale = "Once Upon A Time";
            string[] taleWords = tale.Split(); //split defaults to separate a string on white spaces

            Array.Reverse(taleWords);            for (int i = 0; i < taleWords.Length; i++)
            {
                Console.WriteLine(taleWords[i]);
            }
            Console.ReadLine();

            //while loops
            //if condition is met, execute the body
            //if condition is not met, stop.

            Console.WriteLine("\nDo you want to play a game?");
            string playAgain = Console.ReadLine();

            while (playAgain == "yes")
            {
                Console.WriteLine("It's a rematch!");
                Console.WriteLine("Do you want to play again [from loop body]?");
                playAgain = Console.ReadLine();
            }

            Console.WriteLine("If this prints, your instincts were correct. Game will end.");

            //another example. ROYGBIV

            Console.WriteLine("What is your favorite Roy G Biv color?");
            string userColor = Console.ReadLine();
            //bool isRoygbiv = false;

            while (userColor != "red" && userColor != "orange"  /*etc*/)  //note that's AND not OR here
            {
                Console.WriteLine("That's not a Roy G Biv color, foo! Try again.");
                userColor = Console.ReadLine();
            }

            Console.WriteLine($"I like {userColor} too.");
            //note to self: I think there is a recursive to repeat something earlier, instead of repeating within the loop
            //we haven't learned at WCCI yet

            //do while loop
            //the code will happen at least one time, THEN it checks whether the condition is met

            string playAgain2;

            do
            {
                Console.WriteLine("Do you want to build a snowman?");
                Console.WriteLine("That was fun");
                Console.WriteLine("Do you want to build another snowman?");
                playAgain2 = Console.ReadLine();
            }

            while (playAgain2 == "yes"); 
                
        }
    }
}
 