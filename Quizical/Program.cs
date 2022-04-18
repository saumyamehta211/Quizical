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

            var QuizModel = modelFactory.GetQuizModel(playerSelectedCategory);

            var QuestionStack = QuizModel.generateRandomQuestions();
            
            foreach(var question in QuestionStack.FirstOrDefault())
            {
                Console.WriteLine(question.Value.Question);
                
                Console.WriteLine("Please select the option number!!");

                int answer = Convert.ToInt32(Console.ReadLine());
                QuizModel.checkAnswer(question.Key, answer);      
            }

            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Now calculation score:");
            Thread.Sleep(2000);
            QuizModel.displayScore();
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("thanks for playing!!!");

        }
    }
}