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
            private MyStack<Dictionary<int, Genre>>? stack;
            private int questionLength = 3;
            private List<int> list = new List<int>();
            private Dictionary<int,Genre> questionBank = new Dictionary<int,Genre>();

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

            public MyStack<Dictionary<int, Genre>> generateRandomQuestions()
            {
                if (this.gb1 != null)
                {
                    var questionDetails = this.gb1.getQuestionDetails();
                    for (var i = 0; i <= questionLength; i++)
                    {
                        Random rand = new Random();
                        int randnum = rand.Next(1, 5);
                        if (!list.Contains(randnum))
                        {
                            questionBank.Add(randnum,questionBank[randnum]);
                            stack.Push(questionBank);
                            list.Add(randnum);
                        }
                        
                    }
                    return stack;
                }
                else
                {
                    return null;
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