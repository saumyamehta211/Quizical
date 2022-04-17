using System;
using System.Collections.Generic;

namespace Quizical
{
    //Singleton Factory class
    internal class QuizModelFactory
    {

        private static QuizModelFactory? quizModelFactory;
        private Dictionary<string,QuizModel> quizModelDictionary = new Dictionary<string, QuizModel>();
        

        private QuizModelFactory() { }

        public static QuizModelFactory GetInstance()
        {
            if (quizModelFactory == null)
            {
                quizModelFactory = new QuizModelFactory();
            }
            return quizModelFactory;
        }

        internal IQuizModel GetQuizModel(string quizModel)
        {
            if (!quizModelDictionary.ContainsKey(quizModel))
            {
                quizModelDictionary.Add(quizModel, new QuizModel(quizModel));
            }
            return quizModelDictionary[quizModel];
        }

        //Private Flyweight model class
        private class QuizModel : IQuizModel
        {
            private int score;

            //Model constructor
            public QuizModel(string quizModel)
            {
                score = 0;
            }

            public void checkAnswer()
            {
                throw new NotImplementedException();
            }

            public void displayScore()
            {
                Console.WriteLine("Your score is : "+score);
            }
        }

        
    }
}