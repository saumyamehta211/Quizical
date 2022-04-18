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
            private GenreInterface? gb1 = null;

            //Model constructor
            public QuizModel(string quizModel)
            {
                score = 0;
                if (quizModel.ToLower() == "math")
                {
                    this.gb1 = new GenreMath();
                } else if (quizModel.ToLower() == "biology") { 
                    this.gb1 = new GenreBiology();
                }
                else if (quizModel.ToLower() == "movie")
                {
                    this.gb1 = new GenreMovie();
                }
                else if(quizModel.ToLower() == "geology")
                {
                    this.gb1 = new GenreGeology();
                }
                else
                {
                    this.gb1 = new GenreTrivia();
                }
            }

            public void checkAnswer(int id,int answer)
            {
                if (this.gb1 != null)
                {
                    var questionDetails = this.gb1.getQuestionDetails();
                    if (questionDetails[id].Answer == answer)
                    {
                        score++;
                    }
                }
            }

            public void displayScore()
            {
                Console.WriteLine("Your score is : "+score);
            }
        }

        
    }
}