using System;

namespace Quizical
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assigning a Default value in case of missed entry from player
            string playerSelectedCategory = "Math";
            
            //Hashset to store categories of the quiz
            HashSet<string> Category = new HashSet<string>();
            
            
            // adding the category to hashset
            Category.Add("Biology");
            Category.Add("Trivia");
            Category.Add("Math");
            Category.Add("Movie");
            Category.Add("Geology");

            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|*************************************Welcome to Quizical********************************|");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("------------------------------------------------------------------------------------------");

            Console.WriteLine("Please choose the category to choose from:");
            foreach(string category in Category)
            {
                Console.WriteLine(category);
            }

            playerSelectedCategory = Console.ReadLine();

            QuizModelFactory modelFactory = QuizModelFactory.GetInstance();



        }
    }
}